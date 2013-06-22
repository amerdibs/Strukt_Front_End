using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    public class Properties_Strukt
    {
        public class Locations
        {
            public int id { get; set; }
            public string name { get; set; }
            public string l_lat { get; set; }
            public string l_long { get; set; }
        }
        public class Projects
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class ResourceTypes
        {
            public int id { get; set; }
            public string name { get; set; }
            public string ending { get; set; }
            public string icon_url { get; set; }
        }
        public class Resources
        {
            public int id { get; set; }
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
            public int id { get; set; }
            public string name { get; set; }
        }
        public class Statuses
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }
        public class Task_Types
        {
            public int id { get; set; }
            public string name { get; set; }
        }
        public class Tools
        {
            public int id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
