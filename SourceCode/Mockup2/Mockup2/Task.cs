using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Task
    {
        public string id { get; set; }
        public string precedes_id { get; set; }
        public string parent_workflow_id { get; set; }
        public string child_workflow_id { get; set; }
        public string workflow_model_id { get; set; }

        public string user_id { get; set; }
        public string name { get; set; }
        public string deadline { get; set; }
        public string date { get; set; }
        public string status_id { get; set; }
        public string type_id { get; set; }
        public string location_id { get; set; }
        public string project_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

        public Workflow workflowMember;
        public Task taskFollow;
        public Task taskPrecedes;



        public static List<Task> getTaskByParentWorkflowID(string strParentWorkflowID)
        {
            try
            {
                string strFlowID = global.getExtractValueFromRespond(
                                    global.getRespondFromStruktGet(Strukt.URL_Task, "?parent_workflow_id=" + Strukt.Type_Workflow + strParentWorkflowID));

                if (strFlowID == "")
                    return null;

                List<Task> taskList = JsonConvert.DeserializeObject<List<Task>>(strFlowID);
                return taskList;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<Task> getTaskByUserID(string strUserID)
        {
            try
            {
                string strUser = global.getExtractValueFromRespond(
                                    global.getRespondFromStruktGet(Strukt.URL_Task, "?user_id=" + Strukt.Type_User + strUserID));

                if (strUser == "")
                    return null;

                List<Task> UserList = JsonConvert.DeserializeObject<List<Task>>(strUser);
                return UserList;
            }
            catch (Exception)
            {
                throw;
            }
        }


    }
}
