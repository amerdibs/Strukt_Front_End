using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Task object is used instead of strukt object
/// </summary>
public class Task
{


    public string real_id { get; set; }
    public string id { get; set; }
    public string precedes_id { get; set; }
    public string parent_workflow_id { get; set; }
    public string child_workflow_id { get; set; }
    public string workflow_model_id { get; set; }
    public string user_id { get; set; }
    public string name { get; set; }
    public string deadline { get; set; }
    public string date { get; set; }
    public string status_id { get; set; }
    public string type_id { get; set; }
    public string location_id { get; set; }
    public string project_id { get; set; }
    public string follows_id { get; set; }

	public Task()
	{
		//
		// TODO: Add constructor logic here
		//

	}
}