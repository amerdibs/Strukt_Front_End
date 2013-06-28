using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Mockup2
{
   public class Workflow    
    {
        public string id { get; set; }
        public string user_id { get; set; }
        public string task_id { get; set; }
        public string parent_task_id { get; set; }
        public string type { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public List<Task> taskList;

        public static Workflow getWorkflowByID(string strWorkflowID)
        {
            try
            {
                string strSect = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Workflow, "/" + strWorkflowID));

                if (strSect == "")
                    return null;

                Workflow workflow = JsonConvert.DeserializeObject<Workflow>(strSect);
                return workflow;
            }
            catch (Exception)
            {
                throw;
            }
        }


        public static Workflow getWorkflowHierachybyID(string strWorkflowID)
        {
            Workflow wfGet = getWorkflowByID(global.strWorkflowID);
            List<Task> tkList = Task.getTaskByParentWorkflowID(global.strWorkflowID);
            wfGet.taskList = tkList;
            foreach (Task tkUse in tkList)
            {
                if (tkUse.child_workflow_id != null)
                {
                    tkUse.workflowMember = getWorkflowHierachybyID(global.getValueFromStruktValue(tkUse.child_workflow_id));
                }
            }
            return wfGet;
        }

    }

    

}
