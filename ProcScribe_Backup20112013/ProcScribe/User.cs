using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Data;

namespace ProcScribe
{
    public class User
    {
        public string id { get; set; }
        public string email { get; set; }
        public string encrypted_password { get; set; }
        public string reset_password_token { get; set; }
        public string reset_password_sent_at { get; set; }
        public string remember_created_at { get; set; }
        public string sign_in_count { get; set; }
        public string current_sign_in_at { get; set; }
        public string last_sign_in_at { get; set; }
        public string current_sign_in_ip { get; set; } 
        public string last_sign_in_ip { get; set; }
        public string created_at { get; set; }
        public string updated_at { get; set; }
        public string workflow_id { get; set; }
        public string role_id { get; set; } 
        public string username { get; set; }
        public string last_action_at { get; set; }

        //User roles
        public static string roleDesigner = "D";
        public static string roleExecutor = "E";

        public static DataRow getUserNameByStruktID(string strUserID)
        {
            if (global.userTable == null)
                return null;
            DataRow[] dtRow = global.userTable.Select("u_strukt_user_id = '" + strUserID + "'");
            if (dtRow.Length > 0)
            {
                return dtRow[0];
            }
            else
            {
                return null;
            }
        }
    }
}
