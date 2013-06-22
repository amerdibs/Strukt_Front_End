using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Mockup2
{
   public class Workflows
    {

    public int id { get; set; }
    public int user_id { get; set; }
    public int task_id { get; set; }
    public string type { get; set; }
    public DateTime created_at { get; set; }
    public DateTime updated_at { get; set; }

    }
}
