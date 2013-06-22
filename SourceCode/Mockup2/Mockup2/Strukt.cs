using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    class Strukt
    {
        public static string URLStrukt = "http://strukt.informatik.uni-mannheim.de:8080/strukt";
        public static string URL_Assignment = "/assignment";
        public static string URL_Workflow = "/workflow";
        public static string URL_Task = "/task";
        public static string URL_Precondition_set = "/precondition_set";
        public static string URL_Optionalcondition = "/optionalcondition";
        public static string URL_Role = "/role";
        public static string URL_Resource_type = "/resource_type";
        public static string URL_Tool = "/tool";
        public static string URL_Project = "/project";
        public static string URL_Location = "/location";
        public static string URL_Workflow_model = "/workflow_model";
        public static string URL_Task_type = "/task_type";
        public static string URL_Status = "/status";

        public static string TypeStrukt = "http://strukt.west.uni-koblenz.de";
        public static byte TypeStruktEndingChecking = 4;
        public static string TypeStruktEnding = TypeStrukt.Substring(TypeStrukt.Length - TypeStruktEndingChecking + 1) + "/"; // Use 3 characters for ending checking
        public static string Type_Assignment = URLStrukt + "/assignment/";
        public static string Type_Workflow = URLStrukt + "/workflow/";
        public static string Type_Task = URLStrukt + "/task/";
        public static string Type_Precondition_set = URLStrukt + "/precondition_set/";
        public static string Type_Optionalcondition = URLStrukt + "/optionalcondition/";
        public static string Type_Role = URLStrukt + "/role/";
        public static string Type_Resource_type = URLStrukt + "/resource_type/";
        public static string Type_Tool = URLStrukt + "/tool/";
        public static string Type_Project = URLStrukt + "/project/";
        public static string Type_Location = URLStrukt + "/location/";
        public static string Type_Workflow_model = URLStrukt + "/workflow_model/";
        public static string Type_Task_type = URLStrukt + "/task_type/";
        public static string Type_Status = URLStrukt + "/status/";
        public static string Type_User = URLStrukt + "/user/";
        public static string Type_WeaklyStructuredWorkflow = URLStrukt + "/WeaklyStructuredWorkflow/";


    }
}
