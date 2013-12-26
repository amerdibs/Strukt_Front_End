using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ProcScribeOutlook 
{

    public class TaskProcess : Task
    {
        public string process_name { get; set; }

        public static List<TaskProcess> getTaskProcessAll()
        {
            try
            {
                string strReturn = "";
                ProcScribeOutlook.StruktMain.StruktMainSoapClient wsStrukt = new ProcScribeOutlook.StruktMain.StruktMainSoapClient();
                strReturn = wsStrukt.selectTaskProcessAll();
                if (strReturn == null)
                    return null;
                List<TaskProcess> lTask = new List<TaskProcess>();
                lTask = JsonConvert.DeserializeObject<List<TaskProcess>>(strReturn);
                return lTask;

            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
