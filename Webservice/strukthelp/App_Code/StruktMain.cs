using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using System.IO;

/// <summary>
/// Summary description for StruktMain
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class StruktMain : System.Web.Services.WebService {

    public StruktMain () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string selectWorkflow(String strWorkflowID)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
  
            dbConnection.Open();
            string strD = "select * from Workflow where id = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("id", strWorkflowID));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "WorkFlow";

            if (dtTable.Rows.Count == 0)
                return null;

            Workflow wf = new Workflow();
            wf.id = dtTable.Rows[0]["id"].ToString();
            wf.parent_task_id = dtTable.Rows[0]["parent_task_id"].ToString();
            wf.real_id = dtTable.Rows[0]["real_id"].ToString();
            wf.task_id = dtTable.Rows[0]["task_id"].ToString();
            wf.user_id = dtTable.Rows[0]["user_id"].ToString();
            wf.type = dtTable.Rows[0]["type"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(wf, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }
       
    }
    
    [WebMethod]
    public string addWorkflow()
    {
        string strAnswer= "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            //Workflow wf = JsonConvert.DeserializeObject<Workflow>(strWorkflow);   
            dbConnection.Open();
            string strD = "insert into Workflow (type) values (@type); SELECT SCOPE_IDENTITY();";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Add(new SqlParameter("type", "http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow"));
            qCommand.CommandText = strD;
            object intKey = qCommand.ExecuteScalar();

            strD = "update Workflow set id = @id where real_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.Parameters.Add(new SqlParameter("id", Strukt.Type_Workflow + intKey.ToString()));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            strD = "select * from Workflow where real_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "WorkFlow";

            Workflow wf = new Workflow();
            wf.id = dtTable.Rows[0]["id"].ToString();
            wf.type = dtTable.Rows[0]["type"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(wf, jsSetting);
            return strAnswer;
         
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }
       
    }

    [WebMethod]
    public string editWorkflow(String strWorkflow)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            Workflow wf = JsonConvert.DeserializeObject<Workflow>(strWorkflow);   
            dbConnection.Open();
            string strD = "update Workflow set user_id = @user_id, task_id = @task_id, parent_task_id = @parent_task_id where id = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            if (wf.user_id == null)
                qCommand.Parameters.Add(new SqlParameter("user_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("user_id", wf.user_id));
            if (wf.task_id == null)
                qCommand.Parameters.Add(new SqlParameter("task_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("task_id", wf.task_id));
            if (wf.parent_task_id == null)
                qCommand.Parameters.Add(new SqlParameter("parent_task_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("parent_task_id", wf.parent_task_id));
            qCommand.Parameters.Add(new SqlParameter("id", wf.id));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            strD = "select * from Workflow where id = @id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("id", wf.id));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "WorkFlow";
            wf.user_id = dtTable.Rows[0]["user_id"].ToString() ?? "";
            wf.task_id = dtTable.Rows[0]["task_id"].ToString() ?? "";
            wf.parent_task_id = dtTable.Rows[0]["parent_task_id"].ToString() ?? "";
            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(wf, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string deleteWorkflow(String strWorkflowID)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            dbConnection.Open();
            string strD = "delete from Workflow where id = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Add(new SqlParameter("id", strWorkflowID));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();
            return "{\"type\":\"success\"}";

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string selectTask(String strTaskID)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {

            dbConnection.Open();
            string strD = "select * from Task where id = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("id", strTaskID));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "Task";

            if (dtTable.Rows.Count == 0)
                return null;

            Task tk = new Task();
            tk.real_id = dtTable.Rows[0]["real_id"].ToString();
            tk.id = dtTable.Rows[0]["id"].ToString();
            tk.precedes_id = dtTable.Rows[0]["precedes_id"].ToString();
            tk.parent_workflow_id = dtTable.Rows[0]["parent_workflow_id"].ToString();
            tk.child_workflow_id = dtTable.Rows[0]["child_workflow_id"].ToString();
            tk.workflow_model_id = dtTable.Rows[0]["workflow_model_id"].ToString();
            tk.user_id = dtTable.Rows[0]["user_id"].ToString();
            tk.name = dtTable.Rows[0]["name"].ToString();
            tk.deadline = dtTable.Rows[0]["deadline"].ToString();
            tk.date = dtTable.Rows[0]["date"].ToString();
            tk.status_id = dtTable.Rows[0]["status_id"].ToString();
            tk.type_id = dtTable.Rows[0]["type_id"].ToString();
            tk.location_id = dtTable.Rows[0]["location_id"].ToString();
            tk.project_id = dtTable.Rows[0]["project_id"].ToString();
            tk.follows_id = dtTable.Rows[0]["follows_id"].ToString();
            tk.process_workflow_id = dtTable.Rows[0]["process_workflow_id"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(tk, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string addTask(String strTaskObject)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            Task tk = JsonConvert.DeserializeObject<Task>(strTaskObject);   
            dbConnection.Open();
            string strD = "insert into Task (name) values (@name); SELECT SCOPE_IDENTITY();";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Add(new SqlParameter("name", tk.name ?? ""));
            qCommand.CommandText = strD;
            object intKey = qCommand.ExecuteScalar();

            strD = "update Task set id = @id where real_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.Parameters.Add(new SqlParameter("id", Strukt.Type_Task + intKey.ToString()));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            tk.id = Strukt.Type_Task + intKey.ToString();
            tk.real_id = intKey.ToString();

            strD = "select * from Task where real_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "Task";

            strD = "UPDATE Task " +
               "SET [precedes_id] = @precedes_id " +
               ",[parent_workflow_id] = @parent_workflow_id " +
               ",[child_workflow_id] = @child_workflow_id " +
               ",[workflow_model_id] = @workflow_model_id " +
               ",[user_id] = @user_id " +
               ",[name] = @name " +
               ",[deadline] = @deadline " +
               ",[date] = @date " +
               ",[status_id] = @status_id " +
               ",[type_id] = @type_id " +
               ",[location_id] = @location_id " +
               ",[project_id] = @project_id " +
               ",[follows_id] = @follows_id " +
               ",[process_workflow_id] = @process_workflow_id " +
               "WHERE [id] = @id";
            qCommand.Parameters.Clear();
            qCommand = new SqlCommand(strD, dbConnection);
            if (tk.precedes_id == null)
                qCommand.Parameters.Add(new SqlParameter("precedes_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("precedes_id", tk.precedes_id));

            if (tk.parent_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("parent_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("parent_workflow_id", tk.parent_workflow_id));

            if (tk.child_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("child_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("child_workflow_id", tk.child_workflow_id));

            if (tk.workflow_model_id == null)
                qCommand.Parameters.Add(new SqlParameter("workflow_model_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("workflow_model_id", tk.workflow_model_id));

            if (tk.user_id == null)
                qCommand.Parameters.Add(new SqlParameter("user_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("user_id", tk.user_id));

            if (tk.name == null)
                qCommand.Parameters.Add(new SqlParameter("name", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("name", tk.name));

            if (tk.deadline == null)
                qCommand.Parameters.Add(new SqlParameter("deadline", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("deadline", tk.deadline));

            if (tk.date == null)
                qCommand.Parameters.Add(new SqlParameter("date", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("date", tk.date));

            if (tk.status_id == null)
                qCommand.Parameters.Add(new SqlParameter("status_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("status_id", tk.status_id));

            if (tk.type_id == null)
                qCommand.Parameters.Add(new SqlParameter("type_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("type_id", tk.type_id));

            if (tk.location_id == null)
                qCommand.Parameters.Add(new SqlParameter("location_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("location_id", tk.location_id));

            if (tk.project_id == null)
                qCommand.Parameters.Add(new SqlParameter("project_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("project_id", tk.project_id));

            if (tk.follows_id == null)
                qCommand.Parameters.Add(new SqlParameter("follows_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("follows_id", tk.follows_id));

            if (tk.process_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("process_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("process_workflow_id", tk.process_workflow_id));

            qCommand.Parameters.Add(new SqlParameter("id", tk.id));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            strD = "select * from Task where id = @id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("id", tk.id));
            qCommand.CommandText = strD;
            SqlDataReader qReaderSelect = qCommand.ExecuteReader();
            DataTable dtTableSelect = new DataTable();
            dtTableSelect.Load(qReaderSelect);
            dtTableSelect.TableName = "Task";

            tk.real_id = dtTableSelect.Rows[0]["real_id"].ToString();
            tk.id = dtTableSelect.Rows[0]["id"].ToString();
            tk.precedes_id = dtTableSelect.Rows[0]["precedes_id"].ToString();
            tk.parent_workflow_id = dtTableSelect.Rows[0]["parent_workflow_id"].ToString();
            tk.child_workflow_id = dtTableSelect.Rows[0]["child_workflow_id"].ToString();
            tk.workflow_model_id = dtTableSelect.Rows[0]["workflow_model_id"].ToString();
            tk.user_id = dtTableSelect.Rows[0]["user_id"].ToString();
            tk.name = dtTableSelect.Rows[0]["name"].ToString();
            tk.deadline = dtTableSelect.Rows[0]["deadline"].ToString();
            tk.date = dtTableSelect.Rows[0]["date"].ToString();
            tk.status_id = dtTableSelect.Rows[0]["status_id"].ToString();
            tk.type_id = dtTableSelect.Rows[0]["type_id"].ToString();
            tk.location_id = dtTableSelect.Rows[0]["location_id"].ToString();
            tk.project_id = dtTableSelect.Rows[0]["project_id"].ToString();
            tk.follows_id = dtTableSelect.Rows[0]["follows_id"].ToString();
            tk.process_workflow_id = dtTableSelect.Rows[0]["process_workflow_id"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(tk, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string editTask(String strTask)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            Task tk = JsonConvert.DeserializeObject<Task>(strTask);
            dbConnection.Open();
            string strD = "UPDATE Task " +
                "SET [precedes_id] = @precedes_id " +
                ",[parent_workflow_id] = @parent_workflow_id " +
                ",[child_workflow_id] = @child_workflow_id " +
                ",[workflow_model_id] = @workflow_model_id " +
                ",[user_id] = @user_id " +
                ",[name] = @name " +
                ",[deadline] = @deadline " +
                ",[date] = @date " +
                ",[status_id] = @status_id " +
                ",[type_id] = @type_id " +
                ",[location_id] = @location_id " +
                ",[project_id] = @project_id " +
                ",[follows_id] = @follows_id " +
                ",[process_workflow_id] = @process_workflow_id " +
                "WHERE [id] = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            if (tk.precedes_id == null)
                qCommand.Parameters.Add(new SqlParameter("precedes_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("precedes_id", tk.precedes_id));

            if (tk.parent_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("parent_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("parent_workflow_id", tk.parent_workflow_id));

            if (tk.child_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("child_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("child_workflow_id", tk.child_workflow_id));

            if (tk.workflow_model_id == null)
                qCommand.Parameters.Add(new SqlParameter("workflow_model_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("workflow_model_id", tk.workflow_model_id));

            if (tk.user_id == null)
                qCommand.Parameters.Add(new SqlParameter("user_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("user_id", tk.user_id));

            if (tk.name == null)
                qCommand.Parameters.Add(new SqlParameter("name", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("name", tk.name));

            if (tk.deadline == null)
                qCommand.Parameters.Add(new SqlParameter("deadline", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("deadline", tk.deadline));

            if (tk.date == null)
                qCommand.Parameters.Add(new SqlParameter("date", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("date", tk.date));

            if (tk.status_id == null)
                qCommand.Parameters.Add(new SqlParameter("status_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("status_id", tk.status_id));

            if (tk.type_id == null)
                qCommand.Parameters.Add(new SqlParameter("type_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("type_id", tk.type_id));

            if (tk.location_id == null)
                qCommand.Parameters.Add(new SqlParameter("location_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("location_id", tk.location_id));

            if (tk.project_id == null)
                qCommand.Parameters.Add(new SqlParameter("project_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("project_id", tk.project_id));

            if (tk.follows_id == null)
                qCommand.Parameters.Add(new SqlParameter("follows_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("follows_id", tk.follows_id));

            if (tk.process_workflow_id == null)
                qCommand.Parameters.Add(new SqlParameter("process_workflow_id", DBNull.Value));
            else
                qCommand.Parameters.Add(new SqlParameter("process_workflow_id", tk.process_workflow_id));

            qCommand.Parameters.Add(new SqlParameter("id", tk.id));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            strD = "select * from Task where id = @id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("id", tk.id));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "Task";

            tk.real_id = dtTable.Rows[0]["real_id"].ToString();
            tk.id = dtTable.Rows[0]["id"].ToString();
            tk.precedes_id = dtTable.Rows[0]["precedes_id"].ToString();
            tk.parent_workflow_id = dtTable.Rows[0]["parent_workflow_id"].ToString();
            tk.child_workflow_id = dtTable.Rows[0]["child_workflow_id"].ToString();
            tk.workflow_model_id = dtTable.Rows[0]["workflow_model_id"].ToString();
            tk.user_id = dtTable.Rows[0]["user_id"].ToString();
            tk.name = dtTable.Rows[0]["name"].ToString();
            tk.deadline = dtTable.Rows[0]["deadline"].ToString();
            tk.date = dtTable.Rows[0]["date"].ToString();
            tk.status_id = dtTable.Rows[0]["status_id"].ToString();
            tk.type_id = dtTable.Rows[0]["type_id"].ToString();
            tk.location_id = dtTable.Rows[0]["location_id"].ToString();
            tk.project_id = dtTable.Rows[0]["project_id"].ToString();
            tk.follows_id = dtTable.Rows[0]["follows_id"].ToString();
            tk.process_workflow_id = dtTable.Rows[0]["process_workflow_id"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(tk, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string deleteTask(String strTaskID)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            dbConnection.Open();
            string strD = "delete from Task where id = @id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Add(new SqlParameter("id", strTaskID));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();
            return "{\"type\":\"success\"}";

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string selectTaskProcessAll()
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {

            dbConnection.Open();
            string strD = "select struktProcess.*,Task.*,isnull(s.tk_description,'') tk_description,isnull(s.tk_keyword,'') tk_keyword, isnull(s.tk_link_detail,'') tk_link_detail from Task join struktProcess " +
                    "on Task.process_workflow_id = 'http://strukt.west.uni-koblenz.de/workflow/' + [p_workflow_id] " +
                    "left join struktTaskExtend s " +
                    "on Task.[id] = 'http://strukt.west.uni-koblenz.de/task/' + s.[tk_task_id] ";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "TaskProcess";

            if (dtTable.Rows.Count == 0)
                return null;

            List<TaskProcess> listTask = new List<TaskProcess>();
            foreach (DataRow dr in dtTable.Rows)
            {
                TaskProcess tk = new TaskProcess();
                tk.real_id = dr["real_id"].ToString();
                tk.id = dr["id"].ToString();
                tk.precedes_id = dr["precedes_id"].ToString();
                tk.parent_workflow_id = dr["parent_workflow_id"].ToString();
                tk.child_workflow_id = dr["child_workflow_id"].ToString();
                tk.workflow_model_id = dr["workflow_model_id"].ToString();
                tk.user_id = dr["user_id"].ToString();
                tk.name = dr["name"].ToString();
                tk.deadline = dr["deadline"].ToString();
                tk.date = dr["date"].ToString();
                tk.status_id = dr["status_id"].ToString();
                tk.type_id = dr["type_id"].ToString();
                tk.location_id = dr["location_id"].ToString();
                tk.project_id = dr["project_id"].ToString();
                tk.follows_id = dr["follows_id"].ToString();
                tk.process_workflow_id = dr["process_workflow_id"].ToString();
                tk.process_name = dr["p_name"].ToString();
                tk.description = dr["tk_description"].ToString();
                tk.keyword = dr["tk_keyword"].ToString();
                listTask.Add(tk);
            }
            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(listTask, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string selectTaskByParentWorkflowID(String strParentWorkflowID)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {

            dbConnection.Open();
            string strD = "select * from Task where parent_workflow_id = @parent_workflow_id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("parent_workflow_id", strParentWorkflowID));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "Task";

            if (dtTable.Rows.Count == 0)
                return null;

            List<Task> listTask = new List<Task>();
            foreach (DataRow dr in dtTable.Rows)
            {
                Task tk = new Task();
                tk.real_id = dr["real_id"].ToString();
                tk.id = dr["id"].ToString();
                tk.precedes_id = dr["precedes_id"].ToString();
                tk.parent_workflow_id = dr["parent_workflow_id"].ToString();
                tk.child_workflow_id = dr["child_workflow_id"].ToString();
                tk.workflow_model_id = dr["workflow_model_id"].ToString();
                tk.user_id = dr["user_id"].ToString();
                tk.name = dr["name"].ToString();
                tk.deadline = dr["deadline"].ToString();
                tk.date = dr["date"].ToString();
                tk.status_id = dr["status_id"].ToString();
                tk.type_id = dr["type_id"].ToString();
                tk.location_id = dr["location_id"].ToString();
                tk.project_id = dr["project_id"].ToString();
                tk.follows_id = dr["follows_id"].ToString();
                tk.process_workflow_id = dtTable.Rows[0]["process_workflow_id"].ToString();
                listTask.Add(tk);
            }



            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(listTask, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string selectTaskByUserID(String strUserID)
    {
        string strAnswer = "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {

            dbConnection.Open();
            string strD = "select * from Task where user_id = @user_id";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("user_id", strUserID));
            qCommand.CommandText = strD;
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "Task";

            if (dtTable.Rows.Count == 0)
                return null;

            Task tk = new Task();
            tk.real_id = dtTable.Rows[0]["real_id"].ToString();
            tk.id = dtTable.Rows[0]["id"].ToString();
            tk.precedes_id = dtTable.Rows[0]["precedes_id"].ToString();
            tk.parent_workflow_id = dtTable.Rows[0]["parent_workflow_id"].ToString();
            tk.child_workflow_id = dtTable.Rows[0]["child_workflow_id"].ToString();
            tk.workflow_model_id = dtTable.Rows[0]["workflow_model_id"].ToString();
            tk.user_id = dtTable.Rows[0]["user_id"].ToString();
            tk.name = dtTable.Rows[0]["name"].ToString();
            tk.deadline = dtTable.Rows[0]["deadline"].ToString();
            tk.date = dtTable.Rows[0]["date"].ToString();
            tk.status_id = dtTable.Rows[0]["status_id"].ToString();
            tk.type_id = dtTable.Rows[0]["type_id"].ToString();
            tk.location_id = dtTable.Rows[0]["location_id"].ToString();
            tk.project_id = dtTable.Rows[0]["project_id"].ToString();
            tk.follows_id = dtTable.Rows[0]["follows_id"].ToString();
            tk.process_workflow_id = dtTable.Rows[0]["process_workflow_id"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(tk, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }

    }

    [WebMethod]
    public string getFileList()
    {
        string strAnswer = "";
        try
        {
            string[] files = Directory.GetFiles(constantClass.folderShared);
            List<FileList> listFileList = new List<FileList>();
            for (int iFile = 0; iFile < files.Length; iFile++)
            {
                FileList fileL = new FileList();
                FileInfo fileInf = new FileInfo(files[iFile]);
                fileL.fileName = fileInf.Name;
                fileL.fileSize = String.Format("{0:#,##0.0}", fileInf.Length / (1024)) + " KB";
                fileL.fileCreatedDate = String.Format("{0:dd-MM-yyyy}", fileInf.CreationTimeUtc);
                listFileList.Add(fileL);
            }
            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(listFileList, jsSetting);

            //dbConnection.Open();
            //string strD = "select * from Task where user_id = @user_id";
            //SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            //qCommand.Parameters.Clear();
            //qCommand.Parameters.Add(new SqlParameter("user_id", strUserID));
            //qCommand.CommandText = strD;
            //SqlDataReader qReader = qCommand.ExecuteReader();
            //DataTable dtTable = new DataTable();
            //dtTable.Load(qReader);
            //dtTable.TableName = "Task";

            //if (dtTable.Rows.Count == 0)
            //    return null;

            //Task tk = new Task();
            //tk.real_id = dtTable.Rows[0]["real_id"].ToString();
            //tk.id = dtTable.Rows[0]["id"].ToString();
            //tk.precedes_id = dtTable.Rows[0]["precedes_id"].ToString();
            //tk.parent_workflow_id = dtTable.Rows[0]["parent_workflow_id"].ToString();
            //tk.child_workflow_id = dtTable.Rows[0]["child_workflow_id"].ToString();
            //tk.workflow_model_id = dtTable.Rows[0]["workflow_model_id"].ToString();
            //tk.user_id = dtTable.Rows[0]["user_id"].ToString();
            //tk.name = dtTable.Rows[0]["name"].ToString();
            //tk.deadline = dtTable.Rows[0]["deadline"].ToString();
            //tk.date = dtTable.Rows[0]["date"].ToString();
            //tk.status_id = dtTable.Rows[0]["status_id"].ToString();
            //tk.type_id = dtTable.Rows[0]["type_id"].ToString();
            //tk.location_id = dtTable.Rows[0]["location_id"].ToString();
            //tk.project_id = dtTable.Rows[0]["project_id"].ToString();
            //tk.follows_id = dtTable.Rows[0]["follows_id"].ToString();
            //tk.process_workflow_id = dtTable.Rows[0]["process_workflow_id"].ToString();

            //JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            //jsSetting.NullValueHandling = NullValueHandling.Ignore;
            //strAnswer = JsonConvert.SerializeObject(tk, jsSetting);
            return strAnswer;

        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            //dbConnection.Close();
        }

    }

}
