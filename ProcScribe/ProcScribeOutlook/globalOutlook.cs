using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;

namespace ProcScribeOutlook
{
    public class globalOutlook
    {
        public static ThisAddIn proscribeAddIn;
        public static string registryPath = "SOFTWARE\\ProcScribe";
        public static string proscribePath;

        public static List<TaskProcess> taskProcessFoundList;

        //Extract the value from type
        public static string getValueFromStruktValue(string strParam)
        {
            string strExtract = "";
            strExtract = strParam.Substring(strParam.IndexOf("/", (strParam.IndexOf(Strukt.TypeStruktEnding) + Strukt.TypeStruktEndingChecking)) + 1);
            return strExtract;
        }
    }

}
