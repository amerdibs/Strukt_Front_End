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
        public static string proscribePath = "SOFTWARE\\ProcScribe";
    }
}
