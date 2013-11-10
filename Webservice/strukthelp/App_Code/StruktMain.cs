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
    public string AddWorkflow(string strWorkflow)
    {
        string strAnswer= "";
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            //Workflow wf = JsonConvert.DeserializeObject<Workflow>(strWorkflow);   
            dbConnection.Open();
            string strD = "insert into Workflow (type) values (@type)  ";
            SqlCommand qCommand = new SqlCommand(strD, dbConnection);
            qCommand.Parameters.Add(new SqlParameter("@type", "http://strukt.west.uni-koblenz.de/WeaklyStructuredWorkflow"));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            qCommand.CommandText = "SELECT SCOPE_IDENTITY()";
            SqlDataReader qReader = qCommand.ExecuteReader();
            qReader.Read();
            int intKey = qReader.GetInt32(0);
            qReader.Close();

            strD = "update Workflow set id = @id where read_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.Parameters.Add(new SqlParameter("id", Strukt.Type_Workflow + intKey.ToString()));
            qCommand.CommandText = strD;
            qCommand.ExecuteNonQuery();

            strD = "seelct * from Workflow where read_id = @real_id";
            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(new SqlParameter("real_id", intKey));
            qCommand.CommandText = strD;
            qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "WorkFlow";

            Workflow wf = new Workflow();
            wf.id = dtTable.Rows[0]["id"].ToString();
            wf.type = dtTable.Rows[0]["type"].ToString();

            JsonSerializerSettings jsSetting = new JsonSerializerSettings();
            jsSetting.NullValueHandling = NullValueHandling.Ignore;
            strAnswer = JsonConvert.SerializeObject(wf, jsSetting);

         
        }
        catch (Exception)
        {

            throw;
        }
        finally
        {
            dbConnection.Close();
        }
        


        return strAnswer;
    }



    
}
