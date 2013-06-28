using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;

namespace Mockup2
{
    class global
    {
        // Users Interface part --------------
        public static bool hideWindows;

        public static int currentTaskControlID;
        public static Object currentTaskControlObject;

        public static byte currentTaskControlType;
        public static byte currentTaskControlTypeMainTask = 0;
        public static byte currentTaskControlTypeSubTask = 1;

        public static int dragTaskControlID;
        public static Object dragTaskControlObject;
        public static Object dropTaskControlObject;

        public static Color ColorMainTask = Color.LightSteelBlue;
        public static Color ColorHover = Color.Tan;
        public static Color ColorSubTask = Color.Lavender;
        public static Color ColorSelect = Color.SandyBrown;


        // fix value is used for the first prototype only
        public static string strWorkflowID = "354249471";
        public static string strUserID = "4";

        //Extract the value from type
        public static string getValueFromStruktValue(string strParam)
        {
            string strExtract = "";
            strExtract = strParam.Substring(strParam.IndexOf("/", (strParam.IndexOf(Strukt.TypeStruktEnding) + Strukt.TypeStruktEndingChecking)) + 1);
            return strExtract;
        }

        //Send Get to Strukt and receive data
        public static string getRespondFromStruktGet(string strResource , string strParam)
        {
            // still did not define Proxy
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strResource + strParam);
            try
            {
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (Exception)
            {
                
                throw;
            }
            
        }

        //Arrange the Strukt's JSON structure into serialized JSON structure after GET
        public static string getExtractValueFromRespond(string strParam)
        {
            string strReturn;

            if (strParam == "{\"values\":[null]}")
                return "";

            List<string> lStrExtract = new List<string>();
            string[] aStrFirst = strParam.Split(new string[] { ":{" }, StringSplitOptions.None);
            for (int i = 1; i < aStrFirst.Length; i++)
            {

                string[] aStrSecond = aStrFirst[i].Split(new string[] { "}}" }, StringSplitOptions.None);
                lStrExtract.Add("{"+aStrSecond[0]+"}");
            }

            strReturn = "[";
            foreach (string str in lStrExtract)
            {
                strReturn += str + ',';
            }
            strReturn = strReturn.Remove(strReturn.Length - 1);
            strReturn += "]";

            return strReturn;
        }

        //Send POST with value to Strukt and receive the result
        public static string sendJSONintoStruktPost(string strResource, string strJSON)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strResource);
            //req.Proxy = new System.Net.WebProxy(ProxyString, true); // still did not define Proxy
            //Add these, as we're doing a POST
            req.ContentType = "application/json";
            req.Method = "POST";
            //We need to count how many bytes we're sending. 
            byte[] bytes = System.Text.Encoding.ASCII.GetBytes(strJSON);
            req.ContentLength = bytes.Length;
            try
            {
                System.IO.Stream os = req.GetRequestStream();
                os.Write(bytes, 0, bytes.Length); //Push it out there
                os.Close();
                System.Net.WebResponse resp = req.GetResponse();
                if (resp == null) return null;
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Arrange serialized JSON structure into Strukt's JSON structure before POST
        public static string composeJSONforStrukt(string strJSON, string strTType)
        {
            string strSect;
            strSect = "{\"values\":[{\"" + strTType + "\":" + strJSON.Substring(1).Substring(0, strJSON.Length - 2) + "}]}";
            return strSect;
        }

        


    }
}
