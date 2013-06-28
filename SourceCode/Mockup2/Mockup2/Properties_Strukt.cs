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
       public List<Properties_Strukt.Location> locationList;
       public List<Properties_Strukt.Project> projectList;
       public List<Properties_Strukt.ResourceType> resourceTypeList;
       public List<Properties_Strukt.Role> roleList;
       public List<Properties_Strukt.Status> statusList;
       public List<Properties_Strukt.TaskType> taskTypeList;
       public List<Properties_Strukt.Tool> toolList;
       // List<Properties_Strukt.Resource> resourceList;

        public static Properties_Strukt getProperties_StruktAll()
        {
            try
            {
                Properties_Strukt properties = new Properties_Strukt();
                properties.locationList = Properties_Strukt.Location.getLocationAll();
                properties.projectList = Properties_Strukt.Project.getProjectAll();
                properties.resourceTypeList = Properties_Strukt.ResourceType.getResourceTypeAll();
                properties.roleList = Properties_Strukt.Role.getRoleAll();
                properties.statusList = Properties_Strukt.Status.getStatusAll();
                properties.taskTypeList = Properties_Strukt.TaskType.getTasktypeAll();
                properties.toolList = Properties_Strukt.Tool.getToolAll();
                                 
                return properties;
            }
            catch (Exception)
            {

                throw;
            }
        }

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
            public static List<Location> getLocationByID(string locationID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Location, "/" + locationID));

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
            public static List<Project> getProjectByID(string projectID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Project, "/" + projectID));

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
            public static List<ResourceType> getResourceTypeByID(string resourceTypeID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Resource_type, "/" + resourceTypeID));

                    if (strResponse == "")
                        return null;

                    List<ResourceType> resourceType = JsonConvert.DeserializeObject<List<ResourceType>>(strResponse);
                    return resourceType;
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
            public static List<Role> getRoleByID(string roleID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Role, "/" + roleID));

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
            public static List<Status> getStatusByID(string statusID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Status, "/" + statusID));

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
            public static List<TaskType> getTasktypeAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Task_type, ""));

                    if (strResponse == "")
                        return null;

                    List<TaskType> tasktype = JsonConvert.DeserializeObject<List<TaskType>>(strResponse);
                    return tasktype;
                }
                catch (Exception)
                {
                    throw;
                }


            }
            public static List<TaskType> getTaskTypeByID(string taskTypeID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Task_type, "/" + taskTypeID));

                    if (strResponse == "")
                        return null;

                    List<TaskType> taskType = JsonConvert.DeserializeObject<List<TaskType>>(strResponse);
                    return taskType;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        public class Tool
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public static List<Tool> getToolAll()
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Tool, ""));

                    if (strResponse == "")
                        return null;

                    List<Tool> tool = JsonConvert.DeserializeObject<List<Tool>>(strResponse);
                    return tool;
                }
                catch (Exception)
                {
                    throw;
                }


            }
            public static List<Tool> getToolByID(string toolID)
            {
                try
                {
                    string strResponse = global.getExtractValueFromRespond(global.getRespondFromStruktGet(Strukt.URL_Tool, "/" + toolID));

                    if (strResponse == "")
                        return null;

                    List<Tool> tool = JsonConvert.DeserializeObject<List<Tool>>(strResponse);
                    return tool;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
        
        

    }
}
