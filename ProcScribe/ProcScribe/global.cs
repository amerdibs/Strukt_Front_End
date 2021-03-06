﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Newtonsoft.Json;
using System.Globalization;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace ProcScribe
{
    public class global
    {
        // Users Interface part --------------

        public static int currentTaskControlID;
        public static Object currentTaskControlObject;

        public static byte currentTaskControlType;
        public static byte currentTaskControlTypeMainTask = 0;

        public static int dragTaskControlID;
        public static Object dragTaskControlObject;
        public static Object dropTaskControlObject;


        public static Color ColorMainTask = Color.WhiteSmoke;
        public static Color ColorHover = Color.LightGray;
        public static Color ColorSelect = Color.FromArgb(161, 202, 241);
        public static Color ColorDesc = Color.Gainsboro;

        public static Color ColorMainTaskDefault = Color.WhiteSmoke;
        public static Color ColorHoverDefault = Color.LightGray;
        public static Color ColorSelectDefault = Color.FromArgb(161, 202, 241);
        public static Color ColorDescDefault = Color.Gainsboro;


        public static int iIndentOfCheckBox = 12;
        //Developer can decide to use it in future for gradient of Task color
        public static int iGradientOfColor = 0; 

        public static int heightControlTaskNormal = 40;
        public static int heightControlTaskReceive = heightControlTaskNormal + 39;
        public static int heightControlTaskAssign = heightControlTaskNormal + 47;
        public static int heightControlTaskCollape = 0;
        public static int heightControlTaskDesc = 80;
        public static int heightControlTaskDescLong = 200;

        public static string resultSuccessStrukt = "{\"type\":\"success\"}";
        public static string registryPath = "SOFTWARE\\ProcScribe";
        
        // getting the current user information
        public static string userName;
        public static string machineName;
        public static string domainName;

        public static string processName;
        public static int processID;

        // limitation
        public static int minFrmHeight = 600;
        public static int minFrmWidth = 320;
        public static int linkDescWidth = 25;


        // fix value is used for the first prototype only
        public static Workflow workflowMain;
        public static List<Task> taskListSearch;
        public static List<TaskProcess> taskProcessListSearch;

        public static List<Assignment> assignmentSentList;
        public static List<Assignment> assignmentReceivedList;

        // ToDo: change for remote server
        //public static string PathSharedFile = "http://pakorn.somee.com/upload/files/";
        public static string PathSharedFile = "http://eris-vm02/upload/Files/";
        public static string PathUploadFile = "http://eris-vm02/upload/upload.aspx";

        public static DataTable processTable;
        public static DataTable userTable;
        public static DataTable appTable;
        public static string roleUser = "D";

        //get Exception and show in output windows
        public static void getExceptionThrow(Exception e)
        {
            Console.WriteLine("\n*** Error throwing! ***");
            Console.WriteLine(" Method: {0}", e.TargetSite);
            Console.WriteLine(" Message: {0}", e.Message);
            Console.WriteLine(" Source: {0}", e.Source);
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
            if (strParam != "" && strParam != null)
            {
                string strExtract = "";
                strExtract = strParam.Substring(strParam.IndexOf("/", (strParam.IndexOf(Strukt.TypeStruktEnding) + Strukt.TypeStruktEndingChecking)) + 1);
                return strExtract;
            }else{
                return "";
            }

        }

        //Send Get to Strukt and receive data
        public static string getRespondFromStruktGet(string strURLResource, string strParam)
        {
            // still did not define Proxy
            System.Net.WebRequest req = System.Net.WebRequest.Create(Strukt.URLStrukt + strURLResource + strParam);
            try
            {
                System.Net.WebResponse resp = req.GetResponse();
                System.IO.StreamReader sr = new System.IO.StreamReader(resp.GetResponseStream());
                return sr.ReadToEnd().Trim();
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
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
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
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
                lStrExtract.Add("{" + aStrSecond[0] + "}");
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
            //still did not define Proxy, keep code for future option
            //req.Proxy = new System.Net.WebProxy(ProxyString, true); 
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
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
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

        public static void getTaskListFromAllWorkflow(Workflow wfparm, List<Task> taskList)
        {
            if ((wfparm == null) || (wfparm.taskChildList == null))
            {
                return;
            }

            foreach (Task tEach in wfparm.taskChildList)
            {
                getTaskListFromAllWorkflow(tEach.workflowChild, taskList);
                taskList.Add(tEach);
                Console.WriteLine("\n" + tEach.id);

            }

        }

        public static void openLink(string sUrl)
        {
            try
            {
                System.Diagnostics.Process.Start(sUrl);
            }
            catch (Exception exc1)
            {
                // System.ComponentModel.Win32Exception is a known exception that occurs when Firefox is default browser.  
                // It actually opens the browser but STILL throws this exception so we can just ignore it.  If not this exception,
                // then attempt to open the URL in IE instead.
                if (exc1.GetType().ToString() != "System.ComponentModel.Win32Exception")
                {
                    // sometimes throws exception so we have to just ignore
                    // this is a common .NET bug that no one online really has a great reason for so now we just need to try to open
                    // the URL using IE if we can.
                    try
                    {
                        System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo("IExplore.exe", sUrl);
                        System.Diagnostics.Process.Start(startInfo);
                        startInfo = null;
                    }
                    catch (Exception e)
                    {
                        global.getExceptionThrow(e);
                        throw e;
                    }
                }
            }
        }

        


    }
}
