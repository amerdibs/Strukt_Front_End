using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    public class Strukt
    {

        public static string T_Assignment = "assignment";
        public static string T_Workflow = "workflow";
        public static string T_Task = "task";
        public static string T_Precondition_set = "precondition_set";
        public static string T_Optionalcondition = "optionalcondition";
        public static string T_Alternatecondition_set = "alternativecondition_set";
        public static string T_Resourcecondition = "resourcecondition_set";
        public static string T_Rolecondition = "rolecondition_set";
        public static string T_Role = "role";
        public static string T_Resource_type = "resource_type";
        public static string T_Tool = "tool";
        public static string T_Project = "project";
        public static string T_Location = "location";
        public static string T_Workflow_model = "workflow_model";
        public static string T_Task_type = "task_type";
        public static string T_Status = "status";
        public static string T_User = "user";

        public static string URLStrukt = "http://strukt.informatik.uni-mannheim.de:8080/strukt";
        public static string URL_Assignment = "/" + T_Assignment;
        public static string URL_Workflow = "/" + T_Workflow;
        public static string URL_Task = "/" + T_Task;
        public static string URL_Precondition_set = "/" + T_Precondition_set;
        public static string URL_Optionalcondition = "/" + T_Optionalcondition;
        public static string URL_Alternatecondition_set = "/" + T_Alternatecondition_set;
        public static string URL_Resourcecondition = "/" + T_Resourcecondition;
        public static string URL_Rolecondition = "/" + T_Rolecondition;
        public static string URL_Role = "/" + T_Role;
        public static string URL_Resource_type = "/" + T_Resource_type;
        public static string URL_Tool = "/" + T_Tool;
        public static string URL_Project = "/" + T_Project;
        public static string URL_Location = "/" + T_Location;
        public static string URL_Workflow_model = "/" + T_Workflow_model;
        public static string URL_Task_type = "/" + T_Task_type;
        public static string URL_Status = "/" + T_Status;

        public static string TypeStrukt = "http://strukt.west.uni-koblenz.de";
        public static byte TypeStruktEndingChecking = 4;
        public static string TypeStruktEnding = TypeStrukt.Substring(TypeStrukt.Length - TypeStruktEndingChecking + 1) + "/"; // Use 3 characters for ending checking
        public static string Type_Assignment = TypeStrukt + "/" + T_Assignment  + "/";
        public static string Type_Workflow = TypeStrukt + "/" + T_Workflow + "/";
        public static string Type_Task = TypeStrukt + "/" + T_Task + "/";
        public static string Type_Precondition_set = TypeStrukt + "/" + T_Precondition_set + "/";
        public static string Type_Optionalcondition = TypeStrukt + "/" + T_Optionalcondition + "/";
        public static string Type_Alternatecondition_set = TypeStrukt + "/" + T_Alternatecondition_set + "/";
        public static string Type_Resourcecondition = TypeStrukt + "/" + T_Resourcecondition + "/";
        public static string Type_Rolecondition = TypeStrukt + "/" + T_Rolecondition + "/";
        public static string Type_Role = TypeStrukt + "/" + T_Role + "/";
        public static string Type_Resource_type = TypeStrukt + "/" + T_Resource_type + "/";
        public static string Type_Tool = TypeStrukt + "/" + T_Tool + "/";
        public static string Type_Project = TypeStrukt + "/" + T_Project + "/";
        public static string Type_Location = TypeStrukt + "/" + T_Location + "/";
        public static string Type_Workflow_model = TypeStrukt + "/" + T_Workflow_model + "/";
        public static string Type_Task_type = TypeStrukt + "/" + T_Task_type + "/";
        public static string Type_Status = TypeStrukt + "/" + T_Status + "/";
        public static string Type_User = TypeStrukt + "/" + T_User + "/";

        public static string Type_WeaklyStructuredWorkflow = TypeStrukt + "/WeaklyStructuredWorkflow/";


    }
}
