using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Condition
    {
        List<AlternativeCondition_set> AlternativeConditionLis;
 

        public class AlternativeCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string alternativecontion_id { get; set; }
        }

        public class Contributor_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string contributor_id { get; set; }
        }

        public class OptionalCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string value_id { get; set; }
        }

        public class Precondtion_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string precondition_id { get; set; }

            public static List<Precondtion_set> getPrecondtion_setsByTaskID(string strTaskID)
            {
                try
                {
                    string strSect = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Precondition_set, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strSect == "")
                        return null;

                    List<Precondtion_set> precondtion_set = JsonConvert.DeserializeObject<List<Precondtion_set>>(strSect);
                    return precondtion_set;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public class Resource_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourcce_id { get; set; }
        }

        public class ResourceCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourceCondition_id { get; set; }

            public static List<ResourceCondition_set> setByTaskID(string strTaskID)
            {
                try
                {
                    string strResourceSet = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Resource_type, "?resourceCondition_id=" + Strukt.Type_Resource_type + strTaskID));

                    if (strResourceSet == "")
                        return null;

                    List<ResourceCondition_set> resourceCondtion_set = JsonConvert.DeserializeObject<List<ResourceCondition_set>>(strResourceSet);
                    return resourceCondtion_set;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public class Role_set
        {
            public string id { get; set; }
            public string user_id { get; set; }
            public string role_id { get; set; }
        }

        public class RoleCondition_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string roleCondition_id { get; set; }
        }

        public class Tools_set
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string tool_id { get; set; }
        }
    }
}
