using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Assignment
    {
        public string source_task_id { get; set; }
        public string target_user_id { get; set; }
        public string target_task_id { get; set; }
        public string acknowledged { get; set; }
        public string date { get; set; }
        public string message { get; set; }
        public DateTime created_at { set; get; }
        public DateTime updated_at { set; get; }

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
            catch(Exception)
            {
                throw;
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
            catch (Exception)
            {
                throw;
            }
        }
    }
}
