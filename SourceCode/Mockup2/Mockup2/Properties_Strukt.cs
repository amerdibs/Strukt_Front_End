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

            public static List<Locations> getProjectsAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Location, ""));
                    if (strResponse == "")
                        return null;
                    List<Locations> locations = JsonConvert.DeserializeObject<List<Locations>>(strResponse);
                    return locations;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public class Projects
        {
            public string id { get; set; }
            public string name { get; set; }
            public static List<Projects> getProjectsAll()
            {
                try
                {
                    string strResponse =global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Project,""));
                    if (strResponse == "")
                        return null;
                    List<Projects> projects = JsonConvert.DeserializeObject<List<Projects>>(strResponse);
                    return projects;

                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }
        public class ResourceTypes
        {
            public string id { get; set; }
            public string name { get; set; }
            public string ending { get; set; }
            public string icon_url { get; set; }
            public static List<ResourceTypes> getResourceTypesAll()
            {
                try
                {
                    string strRespo = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Resource_type, ""));

                    if (strRespo == "")
                        return null;

                    List<ResourceTypes> resource_type  = JsonConvert.DeserializeObject<List<ResourceTypes>>(strRespo);
                    return resource_type;
                }
                catch (Exception)
                {
                    throw;
                }

            }
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
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Role, ""));

                    if (strResponse == "")
                        return null;

                    List<Roles> roles = JsonConvert.DeserializeObject<List<Roles>>(strResponse);
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
        public class TaskTypes
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
