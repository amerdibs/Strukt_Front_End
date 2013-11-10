using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;

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
            qCommand.Parameters.Add(new SqlParameter("@type", "http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow"));
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



    
}
