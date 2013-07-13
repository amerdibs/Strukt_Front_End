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


        public List<Task> taskChildList { get; set; }
        public Task taskParent { get; set; }

        public static List<Workflow> getWorkflowByID(string strWorkflowID)
        {
            try
            {
                string strSect = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Workflow, "/" + strWorkflowID));

                if (strSect == "")
                    return null;

                List<Workflow> workflow = JsonConvert.DeserializeObject<List<Workflow>>(strSect);
                return workflow;
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Retreive workflows and tasks heirarchy
        public static Workflow getWorkflowHierarchybyID(string strWorkflowID)
        {
            List<Workflow> wfGet = getWorkflowByID(strWorkflowID);
            List<Task> tkList = Task.getTaskByParentWorkflowID(strWorkflowID);
            if (tkList == null)
            {
                return wfGet[0];
            }
            wfGet[0].taskChildList = Task.sortTaskList(tkList);

            foreach (Task tkUse in wfGet[0].taskChildList)
            {
                List<Workflow> wfSubGet = getWorkflowByID(global.getValueFromStruktValue(tkUse.child_workflow_id));
                tkUse.workflowParent = wfGet[0];
                //Check for assignment
                if (global.assignmentSentList != null)
                {
                    Assignment asSent = global.assignmentSentList.Find(o => o.source_task_id == tkUse.id);
                    if (asSent != null)
                        tkUse.hasAssignmentSent = true;
                }

                if (global.assignmentReceivedList != null)
                {
                    Assignment asReceived = global.assignmentReceivedList.Find(o => o.target_task_id == tkUse.id);
                    if (asReceived != null)
                        tkUse.hasAssignmentReceived = true;
                }

                wfSubGet[0].taskParent = tkUse;
                if ( !tkUse.user_id.Contains("null") )
                {
                    tkUse.workflowChild = getWorkflowHierarchybyID(global.getValueFromStruktValue(tkUse.child_workflow_id));
                }
            }
            return wfGet[0];
        }

        //Before task creating We must create new child workflow of the task
        public static Workflow addWorkflow()
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                string strInitial = "{\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}";
                strReturn = global.postJSONintoStrukt(Strukt.URL_Workflow, global.composeJSONforStrukt(Strukt.T_Workflow, strInitial));
                return JsonConvert.DeserializeObject<Workflow>(strReturn);
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static Workflow editWorkflow(Workflow tParam)
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(tParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Workflow, global.composeJSONforStrukt(Strukt.T_Workflow, strObj));
                return JsonConvert.DeserializeObject<Workflow>(strReturn);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }

    

}
