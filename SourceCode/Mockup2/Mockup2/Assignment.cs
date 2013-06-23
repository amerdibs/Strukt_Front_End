using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Mockup2
{
    public class Assignment
    {
        public string source_task_id { get; set; }
        public string target_user_id { get; set; }
        public string target_task_id { get; set; }
        public string acknowledged { get; set; }
        public string date { get; set; }
        public string message { get; set; }
        public DateTime created_at { set; get; }
        public DateTime updated_at { set; get; }
    }
}
