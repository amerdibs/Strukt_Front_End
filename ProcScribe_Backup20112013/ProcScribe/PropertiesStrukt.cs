﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace ProcScribe
{
    public class PropertiesStrukt
    {
       public List<Location> locationList;
       public List<Project> projectList;
       public List<ResourceType> resourceTypeList;
       public List<Role> roleList;
       public List<Status> statusList;
       public List<TaskType> taskTypeList;
       public List<Tool> toolList;
       // List<Resource> resourceList;

        public static PropertiesStrukt getPropertiesStruktAll()
        {
            try
            {
                PropertiesStrukt properties = new PropertiesStrukt();
                properties.locationList = Location.getLocationAll();
                properties.projectList = Project.getProjectAll();
                properties.resourceTypeList = ResourceType.getResourceTypeAll();
                properties.roleList = Role.getRoleAll();
                properties.statusList = Status.getStatusAll();
                properties.taskTypeList = TaskType.getTasktypeAll();
                properties.toolList = Tool.getToolAll();
                                 
                return properties;
            }
            catch (Exception e)
            {
                global.getExceptionThrow(e);
                throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }

        }
        public class Status
        {
            public string id { get; set; }
            public string name { get; set; }
            public string url { get; set; }
            public static string statusActive = Strukt.Type_Status + "1";
            public static string statusCompleted = Strukt.Type_Status + "2";
            public static string statusNoNActive = Strukt.Type_Status + "3";
            public static string statusBlocked = Strukt.Type_Status + "4";
            
            public static void updateStatus(Task parmtask,bool status)
            {  
                
		        if (status)
                    parmtask.status_id = statusCompleted;
                else
                    parmtask.status_id = statusActive;
                Task.editTask(parmtask);         
                
                
            }

            public static void updateTaskChildStatusFromActiveToComplete(Task parmtask, List<Task> taskList)
            {
                //Pakorn - We don't need real status update 15.09.13
                //PropertiesStrukt.Status.updateStatus(parmtask, true);
                taskList.Add(parmtask);
                Workflow work = parmtask.workflowChild;
                List<Task> child = work.taskChildList;
                if (child != null)
                    foreach (Task eachTask in child)
                        updateTaskChildStatusFromActiveToComplete(eachTask, taskList);
                else
                    return;
            }
            public static void updateTaskChildStatusFromCompleteToActive(Task parmtask ,List<Task> taskList)
            {
                //Pakorn - We don't need real status update 15.09.13
                //PropertiesStrukt.Status.updateStatus(parmtask, false);
                taskList.Add(parmtask);
                Workflow work = parmtask.workflowChild;
                List<Task> child = work.taskChildList;
                if (child != null)
                    foreach (Task eachTask in child)
                        updateTaskChildStatusFromCompleteToActive(eachTask , taskList);
                else
                    return;

            }
            public static void updateTaskParentStatusFromCompleteToActive(Task parmtask,List<Task> taskList)
            {
                //Pakorn - We don't need real status update 15.09.13
                //PropertiesStrukt.Status.updateStatus(parmtask, false);
                taskList.Add(parmtask);
                Workflow work = parmtask.workflowParent;
                Task parent = work.taskParent;
                if (parent != null)
                    updateTaskParentStatusFromCompleteToActive(parent,taskList);
                else
                    return;


            }
            //Error 
            public static void updateTaskParentStatusFromActiveToComplete(Task parmtask, List<Task> taskList)
            {
                Workflow wfparent = parmtask.workflowParent;
                taskList.Add(parmtask);
                Task parent = wfparent.taskParent;
                if (parent != null)
                {
                    Workflow wfclid = parent.workflowChild;
                    List<Task> child = wfclid.taskChildList;
                    bool boolAllCheck = true;
                    foreach (Task eachTask in child)
                    {
                        if (eachTask.status_id != PropertiesStrukt.Status.statusCompleted)
                            boolAllCheck=false;
                  
                    }

                    if (boolAllCheck)
                    {
                        updateStatus(parent, true);
                        updateTaskParentStatusFromActiveToComplete(parent, taskList);

                    }

                }
            }

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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
            public static TaskType addTaskType(TaskType ttParam)
            {
                try
                {
                    string strReturn  = "";
                    JsonSerializerSettings jsSetting  = new JsonSerializerSettings();
                    jsSetting.NullValueHandling = NullValueHandling.Ignore;
                    string strObj = JsonConvert.SerializeObject(ttParam, jsSetting);
                    strReturn = global.postJSONintoStrukt(Strukt.URL_Task_type,global.composeJSONforStrukt(Strukt.T_Task_type, strObj));
                    return JsonConvert.DeserializeObject<TaskType>(strReturn);
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }    
            }

            public static TaskType editTaskType(TaskType ttParam)
            {
                try
                {
                    string strReturn = "";
                    JsonSerializerSettings jsSetting = new JsonSerializerSettings();
                    jsSetting.NullValueHandling = NullValueHandling.Ignore;
                    jsSetting.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                    string strObj = JsonConvert.SerializeObject(ttParam, jsSetting);
                    strReturn = global.postJSONintoStrukt(Strukt.URL_Task_type, global.composeJSONforStrukt(Strukt.T_Task_type, strObj));
                    return JsonConvert.DeserializeObject<TaskType>(strReturn);
                }
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
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
                catch (Exception e)
                {
                    global.getExceptionThrow(e);
                    throw e;
                }
            }
        }
        
        

    }
}
