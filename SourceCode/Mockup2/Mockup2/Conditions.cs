using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Conditions
    {
        public class AlternativeContion_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string alternativecontion_id { get; set; }
        }

        public class Contributor_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string contributor_id { get; set; }
        }

        public class OptionalConditoins_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string value_id { get; set; }
        }

        public class Precondtion_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string precondition_id { get; set; }

            public static List<Precondtion_sets> getPrecondtion_setsByTaskID(string strTaskID)
            {
                try
                {
                    string strSect = global.getExtractValueFromRespond(
                                        global.getRespondFromStruktGet(Strukt.URL_Precondition_set, "?task_id=" + Strukt.Type_Task + strTaskID));

                    if (strSect == "")
                        return null;

                    List<Precondtion_sets> precondtion_sets = JsonConvert.DeserializeObject<List<Precondtion_sets>>(strSect);
                    return precondtion_sets;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public class Resource_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourcce_id { get; set; }
        }

        public class ResourceCondition_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string resourceCondition_id { get; set; }
        }

        public class Role_sets
        {
            public string id { get; set; }
            public string user_id { get; set; }
            public string role_id { get; set; }
        }

        public class RoleCondition_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string roleCondition_id { get; set; }
        }

        public class Tools_sets
        {
            public string id { get; set; }
            public string task_id { get; set; }
            public string tool_id { get; set; }
        }
    }
}
