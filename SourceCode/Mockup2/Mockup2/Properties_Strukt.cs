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
                //List<Roles> roles = null;
                
                string strSect = global.getRespondFromStruktGet(Strukt.URL_Role, "");
                if (strSect != "")
                {
                    strSect = strSect.Split(new string[] {":{"}, StringSplitOptions.None)[1];
                    strSect = strSect.Split(new string[] {"}}]"}, StringSplitOptions.None)[0];
                }
                strSect = "{" + strSect + "}";
                //strSect = strSect.Replace('\"','\'');


                //string strTest = "{\"values\":[{\"role\":{\"id\":\"http://strukt.west.uni-koblenz.de/role/1\",\"name\":\"architect\"}},{\"role\":{\"id\":\"http://strukt.west.uni-koblenz.de/role/2\",\"name\":\"structural analyst\"}}]}";
                string strTest = "[{\"id\":\"http://strukt.west.uni-koblenz.de/role/1\",\"name\":\"architect\"},{\"id\":\"http://strukt.west.uni-koblenz.de/role/2\",\"name\":\"structural analyst\"}]";
                //List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(global.getRespondFromStruktGet(Strukt.URL_Role, ""));
                //strTest = strTest.Replace('\\','\0' );


                List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(strSect);
                return roles;
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
