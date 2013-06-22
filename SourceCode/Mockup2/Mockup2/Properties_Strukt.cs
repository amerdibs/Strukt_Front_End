using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Properties_Strukt
    {
        public class Locations
        {
            public string id { get; set; }
            public string name { get; set; }
            public string l_lat { get; set; }
            public string l_long { get; set; }
        }
        public class Projects
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class ResourceTypes
        {
            public string id { get; set; }
            public string name { get; set; }
            public string ending { get; set; }
            public string icon_url { get; set; }
        }
        public class Resources
        {
            public string id { get; set; }
            public string type_id { get; set; }
            public string task_id { get; set; }
            public string user_id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public string size { get; set; }
            public string date { get; set; }
        }
        public class Roles
        {
            public string id { get; set; }
            public string name { get; set; }

            public static List<Roles> getRolesAll()
            {
                try
                {
                    string strSect = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Role, ""));

                    if (strSect == "")
                        return null;

                    List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(strSect);
                    return roles;
                }
                catch (Exception)
                {
                    throw;
                }
              
            }

        }
        public class Statuses
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
        public class Task_Types
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class Tools
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
