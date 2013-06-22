using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Mockup2
{
   public class Workflows
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string task_id { get; set; }
        public string parent_task_id { get; set; }
        public string type { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public static List<Workflows> getWorkflowByID(string strWorkflowID)
        {
            try
            {
                string strSect = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Workflow, "/" + strWorkflowID));

                if (strSect == "")
                    return null;

                List<Workflows> workflows = JsonConvert.DeserializeObject<List<Workflows>>(strSect);
                return workflows;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    

}
