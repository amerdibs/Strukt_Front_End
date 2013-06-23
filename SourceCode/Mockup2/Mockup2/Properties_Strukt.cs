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
        public class Location
        {
            public string id { get; set; }
            public string name { get; set; }
            public string l_lat { get; set; }
            public string l_long { get; set; }

            public static List<Location> getLocationAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Location, ""));
                    if (strResponse == "")
                        return null;
                    List<Location> location = JsonConvert.DeserializeObject<List<Location>>(strResponse);
                    return location;

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        public class Project
        {
            public string id { get; set; }
            public string name { get; set; }
            public static List<Project> getProjectAll()
            {
                try
                {
                    string strResponse =global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Project,""));
                    if (strResponse == "")
                        return null;
                    List<Project> project = JsonConvert.DeserializeObject<List<Project>>(strResponse);
                    return project;

                }
                catch (Exception)
                {
                    
                    throw;
                }
            }
        }
        public class ResourceType
        {
            public string id { get; set; }
            public string name { get; set; }
            public string ending { get; set; }
            public string icon_url { get; set; }
            public static List<ResourceType> getResourceTypeAll()
            {
                try
                {
                    string strRespo = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Resource_type, ""));

                    if (strRespo == "")
                        return null;

                    List<ResourceType> resource_type  = JsonConvert.DeserializeObject<List<ResourceType>>(strRespo);
                    return resource_type;
                }
                catch (Exception)
                {
                    throw;
                }

            }
        }
        public class Resource
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
        public class Role
        {
            public string id { get; set; }
            public string name { get; set; }

            public static List<Role> getRoleAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Role, ""));

                    if (strResponse == "")
                        return null;

                    List<Role> role = JsonConvert.DeserializeObject<List<Role>>(strResponse);
                    return role;
                }
                catch (Exception)
                {
                    throw;
                }
              
            }

        }
        public class Status
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }

            public static List<Status> getStatusAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Status, ""));

                    if (strResponse == "")
                        return null;

                    List<Status> status = JsonConvert.DeserializeObject<List<Status>>(strResponse);
                    return status;
                }
                catch (Exception)
                {
                    throw;
                }

            }

         

        }
        public class TaskType
        {
            public string id { get; set; }
            public string name { get; set; }
        }
        public class Tool
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
        }

    }
}
