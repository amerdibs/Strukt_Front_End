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
        public string follows_id { get; set; }

        //outside Strukt system
        public string description { get; set; }
        
        public Workflow workflowChild { get; set; }
        public Workflow workflowParent { get; set; }
        public bool hasAssignmentSent { get; set; }
        public bool hasAssignmentReceived { get; set; }


        public static Task addTask(Task tParam)
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(tParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Task, global.composeJSONforStrukt(Strukt.T_Task, strObj));
                return JsonConvert.DeserializeObject<Task>(strReturn);
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static Task editTask(Task tParam)
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(tParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Task, global.composeJSONforStrukt(Strukt.T_Task, strObj));
                return JsonConvert.DeserializeObject<Task>(strReturn);

            }
            catch (Exception)
            {
                
                throw;
            }
        }

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

        public static List<Task> getTaskByID(string strID)
        {
            try
            {
                string strUser = global.getExtractValueFromRespond(
                                    global.getRespondFromStruktGet(Strukt.URL_Task, "/" + strID));

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

        //Sort the Tasks in List
        public static List<Task> sortTaskList(List<Task> ltParam)
        {
            List<Task> ltSort = new List<Task>();
            Task tFirst = ltParam.Find(o => o.follows_id == null);
            ltSort.Add(tFirst);
            ltParam.Remove(tFirst);
            int i = ltParam.Count();
            string strTaskID = tFirst.id;
            for (int j = 0; j < i; j++)
            {
                Task tEach = ltParam.Find(o => o.follows_id == strTaskID);
                strTaskID = tEach.id;
                ltSort.Add(tEach);
                ltParam.Remove(tEach);
            }
            ltSort.Reverse();
            return ltSort;
        }

        //Get deepest child Task of Task
        public static Task getDeepestChild(Task tParam)
        {
            if ((tParam.workflowChild.taskChildList == null) || (tParam.workflowChild.taskChildList.Count == 0))
            {
                return tParam;
            }
            Task tLast = tParam.workflowChild.taskChildList[0];
            return getDeepestChild(tLast);
        }

        public static string deleteTask(string strParam)
        {
            try
            {
                try
                {
                    string strSect = global.getRespondFromStruktDelete(Strukt.URL_Task, "/" + strParam);

                    if (strSect == "")
                        return null;

                    return strSect;
                }
                catch (Exception)
                {
                    throw;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
