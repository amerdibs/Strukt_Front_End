using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProcScribe
{
    public class Assignment
    {
        public string id { get; set; }
        public string target_user_id { get; set; }
        public string source_user_id { get; set; }
        public string source_task_id { get; set; }
        public string target_task_id { get; set; }
        public string acknowledged { get; set; }
        public string date { get; set; }
        public string message { get; set; }
        public DateTime created_at { set; get; }
        public DateTime updated_at { set; get; }

        public static Assignment addAssignment(Assignment asParam)
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(asParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Assignment, global.composeJSONforStrukt(Strukt.T_Assignment, strObj));
                return JsonConvert.DeserializeObject<Assignment>(strReturn);
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        public static List<Assignment> getAssignmentByTargetUserID(string strTargetUserID)
        {
            try
            {
                string strAssign = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Assignment, "?target_user_id=" + Strukt.Type_User + strTargetUserID));

                if (strAssign == "")

                    return null;

                List<Assignment> strSnoopDog = JsonConvert.DeserializeObject<List<Assignment>>(strAssign);
                return strSnoopDog;
            }
            catch(Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        public static List<Assignment> getAssignmentBySourceUserID(string strTargetUserID)
        {
            try
            {
                string strSource = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Assignment, "?source_user_id=" + Strukt.Type_User + strTargetUserID));

                if (strSource == "")

                    return null;

                List<Assignment> strAssignSource = JsonConvert.DeserializeObject<List<Assignment>>(strSource);
                return strAssignSource;
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        //set both sent and received assignment and return true If has new assignment
        public static bool checkGetAssignmentByUserID(string strTargetUserID)
        {
            bool bResult = false;
            global.assignmentReceivedList = getAssignmentByTargetUserID(strTargetUserID);
            global.assignmentSentList = getAssignmentBySourceUserID(strTargetUserID);
            if (global.assignmentReceivedList != null)
                foreach (Assignment asEach in global.assignmentReceivedList)
                {
                    if (asEach.acknowledged == "false")
                        bResult = true;
                }

            //if (global.assignmentSentList != null)
            //    foreach (Assignment asEach in global.assignmentSentList)
            //    {
            //        if (asEach.acknowledged == "false")
            //            bResult = true;
            //    }
            return bResult;
        }

        public static Assignment editAssignment(Assignment asParam)
        {
            try
            {
                string strReturn = "";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(asParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Task, global.composeJSONforStrukt(Strukt.T_Assignment, strObj));
                return JsonConvert.DeserializeObject<Assignment>(strReturn);
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }

        public static Assignment updateAssignmentAcknowledge(Assignment asParam)
        {
            try
            {
                string strReturn = "";
                asParam.acknowledged = "true";
                JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                jsSetting.NullValueHandling = NullValueHandling.Ignore;
                jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                string strObj = JsonConvert.SerializeObject(asParam, jsSetting);
                strReturn = global.postJSONintoStrukt(Strukt.URL_Assignment, global.composeJSONforStrukt(Strukt.T_Assignment, strObj));
                return JsonConvert.DeserializeObject<Assignment>(strReturn);
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
            }
        }
    }
}
