using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace ProcScribe
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
                string strReturn = "";
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                strReturn = wsStrukt.selectWorkflow(Strukt.Type_Workflow + strWorkflowID);
                if (strReturn == null)
                    return null;
                List<Workflow> lwf = new List<Workflow>();
                lwf.Add(JsonConvert.DeserializeObject<Workflow>(strReturn));
                return lwf;


                //string strSect = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Workflow, "/" + strWorkflowID));

                //if (strSect == "")
                //    return null;

                //List<Workflow> workflow = JsonConvert.DeserializeObject<List<Workflow>>(strSect);
                //return workflow;
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        //Retreive workflows and tasks heirarchy
        public static Workflow getWorkflowHierarchybyID(string strWorkflowID, Task taskParent)
        {
            List<Workflow> wfGet = getWorkflowByID(strWorkflowID);
            List<Task> tkList = Task.getTaskByParentWorkflowID(strWorkflowID);
            wfGet[0].taskParent = taskParent;
            if (tkList == null)
            {
                return wfGet[0];
            }
            wfGet[0].taskChildList = Task.sortTaskList(tkList);

            foreach (Task tkUse in wfGet[0].taskChildList)
            {
                tkUse.workflowParent = wfGet[0];

                if ( !tkUse.user_id.Contains("null") )
                {
                    tkUse.workflowChild = getWorkflowHierarchybyID(global.getValueFromStruktValue(tkUse.child_workflow_id), tkUse);
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
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                strReturn = wsStrukt.addWorkflow();
                return JsonConvert.DeserializeObject<Workflow>(strReturn);
                //JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                //jsSetting.NullValueHandling = NullValueHandling.Ignore;
                //string strInitial = "{\"type\":\"http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow\"}";
                //strReturn = global.postJSONintoStrukt(Strukt.URL_Workflow, global.composeJSONforStrukt(Strukt.T_Workflow, strInitial));
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
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

                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                strReturn = wsStrukt.editWorkflow(strObj);
                return JsonConvert.DeserializeObject<Workflow>(strReturn);
                
                //JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                //jsSetting.NullValueHandling = NullValueHandling.Ignore;
                //jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                //string strObj = JsonConvert.SerializeObject(tParam, jsSetting);
                //strReturn = global.postJSONintoStrukt(Strukt.URL_Workflow, global.composeJSONforStrukt(Strukt.T_Workflow, strObj));
                //return JsonConvert.DeserializeObject<Workflow>(strReturn);
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        public static string deleteWorkflow(string strParam)
        {

            try
            {
                StruktMain.StruktMainSoapClient wsStrukt = new StruktMain.StruktMainSoapClient();
                String strReturn = wsStrukt.deleteWorkflow(Strukt.Type_Workflow + strParam);

                //string strSect = global.getRespondFromStruktDelete(Strukt.URL_Workflow, "/" + strParam);

                if (strReturn == "")
                    return null;

                return strReturn;
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }

        }

    }

    

}
