using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using System.Globalization;
using System.Data;

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

        public static Color ColorMainTask = Color.SkyBlue;
        public static Color ColorHover = Color.Tan;
        public static Color ColorSubTask = Color.Lavender;
        public static Color ColorSelect = Color.SandyBrown;

        public static int iIndentOfCheckBox = 12;
        public static int iGradientOfColor = 20;

        public static int heightControlTaskNormal = 27;
        public static int heightControlTaskReceive = heightControlTaskNormal + 50;
        public static int heightControlTaskAssign = heightControlTaskNormal + 80;


        // fix value is used for the first prototype only
        //public static string strWorkflowID = "354249471";
        //public static string strUserID = "4";
        public static Workflow workflowMain;
        public static List<Assignment> assignmentSentList;
        public static List<Assignment> assignmentReceivedList;


        public static DataTable processTable;
        public static DataTable userTable;


        //calculate height of Task control
        public static int getHeightTaskControl(Task tTask)
        {
            if (!tTask.hasAssignmentSent && !tTask.hasAssignmentReceived)
            {
                return heightControlTaskNormal;
            }
            else if (tTask.hasAssignmentSent && tTask.hasAssignmentReceived)
            {
                return heightControlTaskNormal + 130;
            }
            else if (tTask.hasAssignmentSent && !tTask.hasAssignmentReceived)
            {
                return heightControlTaskAssign;
            }
            else if (!tTask.hasAssignmentSent && tTask.hasAssignmentReceived)
            {
                return heightControlTaskReceive;
            }
            else
                return heightControlTaskNormal;
        }

        //calculate color for Task control background
        public static Color getColorTaskControlBackground(Color cColor, int iLevel)
        {
            int red = cColor.R + (global.iGradientOfColor * iLevel);
            int green = cColor.G + (global.iGradientOfColor * iLevel);
            int blue = cColor.B - (global.iGradientOfColor * iLevel);

            if (red > 255)
                red = 255;
            if (red < 0)
                red = 0;
            if (green > 255)
                green = 255;
            if (green < 0)
                green = 0;
            if (blue > 255)
                blue = 255;
            if (blue < 0)
                blue = 0;
            return Color.FromArgb(red, green, blue);
        }


        //Extract the value from type
        public static string getValueFromStruktValue(string strParam)
        {
            string strExtract = "";
            strExtract = strParam.Substring(strParam.IndexOf("/", (strParam.IndexOf(Strukt.TypeStruktEnding) + Strukt.TypeStruktEndingChecking)) + 1);
            return strExtract;
        }

        //Send Get to Strukt and receive data
        public static string getRespondFromStruktGet(string strURLResource , string strParam)
        {
            // still did not define Proxy
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strURLResource + strParam);
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

        //Send Delete to Strukt and receive data
        public static string getRespondFromStruktDelete(string strURLResource, string strParam)
        {
            // still did not define Proxy
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strURLResource + strParam);
            try
            {
                req.Method = "DELETE";
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

        //Arrange the Strukt's JSON structure into serialized JSON structure after GET FOR ONE OBJECT
        public static string getExtractValueFromRespondSingle(string strParam)
        {
            string strReturn;

            if (strParam == "{\"values\":[null]}")
                return "";

            List<string> lStrExtract = new List<string>();
            string[] aStrFirst = strParam.Split(new string[] { ":{" }, StringSplitOptions.None);
            for (int i = 1; i < aStrFirst.Length; i++)
            {

                string[] aStrSecond = aStrFirst[i].Split(new string[] { "}}" }, StringSplitOptions.None);
                lStrExtract.Add("{" + aStrSecond[0] + "}");
            }

            strReturn = "";
            foreach (string str in lStrExtract)
            {
                strReturn += str + ',';
            }
            strReturn = strReturn.Remove(strReturn.Length - 1);

            return strReturn;
        }


        //Send POST with value to Strukt and receive the object in JSON format, which we desired.
        public static string postJSONintoStrukt(string strURLResource, string strJSON)
        {
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strURLResource);
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
                string strResult = sr.ReadToEnd().Trim();
                if ((strResult == "{\"values\":[null]}") || (strResult == "{\"type\":\"error\"}"))
                {
                    return "";
                }
                return getExtractValueFromRespondSingle(strResult);
            }
            catch (Exception)
            {
                throw;
            }

        }

        //Arrange serialized JSON structure into Strukt's JSON structure before POST
        public static string composeJSONforStrukt(string strTType, string strJSON)
        {
            string strSect;
            strSect = "{\"values\":[{\"" + strTType + "\":{" + strJSON.Substring(1).Substring(0, strJSON.Length - 2) + "}}]}";
            return strSect;
        }

        //Convert date time string from Strukt into .NET datetime
        public static DateTime convertFromStruktDateTime(string strDate)
        {
            DateTimeFormatInfo dtfi = new DateTimeFormatInfo();
            dtfi.ShortDatePattern = "MM-dd-yyyy";
            dtfi.DateSeparator = "/";
            return Convert.ToDateTime(strDate, dtfi);
        }

        //Convert date time string from Strukt into .NET datetime
        public static string convertStruktDateTimeToString(DateTime dtParam)
        {
            return Convert.ToString(dtParam.Month + "/" + dtParam.Day + "/" + dtParam.Year);
        }

        


    }
}
