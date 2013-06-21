using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    public class Properties
    {
        public class Locations
        {
            public int id { get; set; }
            public String name { get; set; }
            public String l_lat { get; set; }
            public String l_long { get; set; }
        }
        public class Projects
        {
            public int id { get; set; }
            public String name { get; set; }
        }
        public class ResourceTypes
        {
            public int id { get; set; }
            public String name { get; set; }
            public String ending { get; set; }
            public String icon_url { get; set; }
        }
        public class Resources
        {
            public int id { get; set; }
            public String type_id { get; set; }
            public String task_id { get; set; }
            public String user_id { get; set; }
            public String name { get; set; }
            public String url { get; set; }
            public String size { get; set; }
            public String date { get; set; }
        }
        public class Roles
        {
            public int id { get; set; }
            public String name { get; set; }
        }
        public class Statuses
        {
            public int id { get; set; }
            public String name { get; set; }
            public String url { get; set; }
        }
        public class Task_Types
        {
            public int id { get; set; }
            public String name { get; set; }
        }
        public class Tools
        {
            public int id { get; set; }
            public String name { get; set; }
            public String url { get; set; }
        }

    }
}
