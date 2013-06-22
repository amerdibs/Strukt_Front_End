using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mockup2
{
    class Tasks
    {
        public int p_workflow_id { get; set; }
        public int c_workflow_id { get; set; }
        public int workflow_model_id { get; set; }
        public int user_id { get; set; }
        public string name { get; set; }
        public string deadline { get; set; }
        public string date { get; set; }
        public int status_id { get; set; }
        public int type_id { get; set; }
        public int location_id { get; set; }
        public int project_id { get; set; }
        public DateTime created_at { get; set; }
        public DateTime updated_at { get; set; }

    }
}
