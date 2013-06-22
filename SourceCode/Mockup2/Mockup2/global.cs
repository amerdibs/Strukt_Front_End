using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

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

        public static Color ColorMainTask = Color.RoyalBlue;
        public static Color ColorHover = Color.Tan;
        public static Color ColorSubTask = Color.Lavender;
        public static Color ColorSelect = Color.SandyBrown;


        // fix value is used for the first prototype only
        public static int intWorkflowID = 0;
        public static int intUserID = 0;

        public static string getValueFromStruktValue(string strParam)
        {
            string strExtract = "";
            strExtract = strParam.Substring(strParam.IndexOf("/", (strParam.IndexOf(Strukt.TypeStruktEnding) + Strukt.TypeStruktEndingChecking)) + 1);
            return strExtract;
        }
    }
}
