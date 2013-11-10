using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Workflow object is used instead of strukt object
/// </summary>
public class Workflow
{

    public string real_id { get; set; }
    public string id { get; set; }
    public string user_id { get; set; }
    public string task_id { get; set; }
    public string parent_task_id { get; set; }
    public string type { get; set; }

	public Workflow()
	{
		//
		// TODO: Add constructor logic here
		//

	}
}