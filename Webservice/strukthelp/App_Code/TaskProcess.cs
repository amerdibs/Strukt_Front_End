using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for TaskProject
/// </summary>
public class TaskProcess : Task
{
    public string process_name { get; set; }
    public string description { get; set; }
    public string keyword { get; set; }

	public TaskProcess()
	{
	}
}