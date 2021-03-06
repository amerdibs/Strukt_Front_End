﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

/// <summary>
/// Summary description for StruktUser
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
// To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
// [System.Web.Script.Services.ScriptService]
public class StruktUser : System.Web.Services.WebService {

    public StruktUser () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string HelloWorld() {
        return "Hello World";
    }

    [WebMethod]
    public DataTable checkLogin(string strName, string strPassword)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select distinct struktUser.*, struktProcess.* from struktUser"
                        + " join struktUserProcess"
                        + " on u_id = up_user_id"
                        + " join struktProcess"
                        + " on up_process_id = p_id"
                        + " where u_name=@u_name and u_password=@u_password";

        SqlParameter spName = new SqlParameter("@u_name", strName);
        SqlParameter spPassword = new SqlParameter("@u_password", strPassword);
        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        qCommand.Parameters.Add(spName);
        qCommand.Parameters.Add(spPassword);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "StruktUserProcess";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }

    [WebMethod]
    public DataTable getProcessByUserID(string strID)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select distinct struktUser.*, struktProcess.* from struktUser"
                        + " join struktUserProcess"
                        + " on u_id = up_user_id"
                        + " join struktProcess"
                        + " on up_process_id = p_id"
                        + " where u_id=@u_id";

        SqlParameter spUserID = new SqlParameter("@u_id", strID);
        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        qCommand.Parameters.Add(spUserID);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "StruktUserProcess";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }


    [WebMethod]
    public DataTable getProcessAll()
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select * from struktProcess";

        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "StruktProcess";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }

    [WebMethod]
    public DataTable getUserAll()
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select * from struktUser";

        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "StruktProcess";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }

    [WebMethod]
    public DataTable getUserByStruktID(string strID)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select struktUser.* from struktUser"
                        + " where u_strukt_user_id = @u_id";

        SqlParameter spUserID = new SqlParameter("@u_id", strID);
        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        qCommand.Parameters.Add(spUserID);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "StruktUser";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }

    //[WebMethod]
    //public DataTable getDescriptionDetail(string strID)
    //{
    //    SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
    //    dbConnection.Open();
    //    string strD = "SELECT isnull(tk_description,'') tk_description FROM struktTaskExtend  WHERE  tk_task_id= @tk_task_id ";
    //    SqlParameter spTaskID = new SqlParameter("@tk_task_id", strID);
    //    SqlCommand qCommand= new SqlCommand(strD, dbConnection);
    //    qCommand.Parameters.Add(spTaskID);
    //    SqlDataReader qReader = qCommand.ExecuteReader();
    //    DataTable dtTable = new DataTable();
    //    dtTable.Load(qReader);
    //    dtTable.TableName = "struktTaskExtend";
    //    dbConnection.Close();
    //    if (dtTable.Rows.Count > 0)
    //    {
    //        return dtTable;
    //    }
    //    else
    //    {
    //        return null;
    //    }
    //}

    [WebMethod]
    public DataTable getTaskExtendByList(List<string> listStrTaskID)
    {
        if ((listStrTaskID == null) || (listStrTaskID.Count == 0))
            return null;

        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strTask = "(";
        foreach (string str in listStrTaskID)
        {
            strTask += "'" + str + "',";
        }
        strTask = strTask.Substring(0, strTask.Length - 1) + ")";


        string strSQL = "SELECT tk_task_id,isnull(tk_description,'') tk_description,isnull(tk_link_type,'') tk_link_type ,isnull(tk_address,'') tk_address, isnull(tk_keyword,'') tk_keyword, isnull(tk_link_detail,'') tk_link_detail  FROM struktTaskExtend  WHERE  tk_task_id in " + strTask;
        SqlCommand qCommand = new SqlCommand(strSQL, dbConnection);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "struktTaskExtend";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }

    //[WebMethod]
    //public void setUptadeTaskDescription(string strID, string Desc)
    //{
    //    SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
    //    try
    //    {
    //        dbConnection.Open();
    //        string strD = "SELECT tk_description FROM struktTaskExtend  WHERE tk_task_id= @tk_task_id ";
    //        SqlParameter spTaskID = new SqlParameter("@tk_task_id", strID);
    //        SqlCommand qCommand = new SqlCommand(strD, dbConnection);
    //        qCommand.Parameters.Add(spTaskID);
    //        SqlDataReader qReader = qCommand.ExecuteReader();
    //        DataTable dtTable = new DataTable();
    //        dtTable.Load(qReader);
    //        dtTable.TableName = "struktTaskExtend";

    //        if (dtTable.Rows.Count > 0 )
    //        {
    //            //Update
    //            strD = "update struktTaskExtend set tk_description = @tk_description WHERE tk_task_id= @tk_task_id ";
    //            SqlParameter spTaskDesc1 = new SqlParameter("@tk_task_id", strID);
    //            SqlParameter spTaskDesc = new SqlParameter("@tk_description", Desc);
    //            qCommand.Parameters.Clear();
    //            qCommand.Parameters.Add(spTaskDesc1);
    //            qCommand.Parameters.Add(spTaskDesc);
    //            qCommand.CommandText = strD;
    //            qCommand.ExecuteNonQuery();

    //        }
    //        else
    //        {
    //            //Add
    //            strD = "insert into struktTaskExtend  (tk_task_id, tk_description) values (@tk_task_id,@tk_description)  ";
    //            SqlParameter spTaskDesc1 = new SqlParameter("@tk_task_id", strID);
    //            SqlParameter spTaskDesc = new SqlParameter("@tk_description",Desc);
    //            qCommand.Parameters.Clear();
    //            qCommand.Parameters.Add(spTaskDesc1);
    //            qCommand.Parameters.Add(spTaskDesc);
    //            qCommand.CommandText = strD;
    //            qCommand.ExecuteNonQuery();
    //        }
    //    }
    //    catch (Exception)
    //    {

    //        throw;
    //    }
    //    finally
    //    {
    //        dbConnection.Close();
    //    }
        
    //}

    [WebMethod]
    public void setUpdateTaskExtend(string strID, string strDesc, string strLinkType, string strAddress, string strKeyword, string strLinkDetail)
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        try
        {
            dbConnection.Open();
            string strQuery = "SELECT * FROM struktTaskExtend  WHERE tk_task_id= @tk_task_id ";
            SqlParameter spTaskID = new SqlParameter("@tk_task_id", strID);
            SqlCommand qCommand = new SqlCommand(strQuery, dbConnection);
            qCommand.Parameters.Add(spTaskID);
            SqlDataReader qReader = qCommand.ExecuteReader();
            DataTable dtTable = new DataTable();
            dtTable.Load(qReader);
            dtTable.TableName = "struktTaskExtend";

            if (dtTable.Rows.Count > 0)
            {
                //Update
                strQuery = "update struktTaskExtend set tk_description = @tk_description,tk_link_type = @tk_link_type,tk_address = @tk_address,tk_keyword = @tk_keyword,tk_link_detail = @tk_link_detail WHERE tk_task_id= @tk_task_id ";
            }
            else
            {
                //Insert
                strQuery = "insert into struktTaskExtend  (tk_task_id, tk_description, tk_link_type, tk_address, tk_keyword, tk_link_detail ) values (@tk_task_id,@tk_description,@tk_link_type,@tk_address,@tk_keyword, @tk_link_detail)  ";
            }

            SqlParameter spDesc = new SqlParameter("@tk_description", strDesc);
            SqlParameter spLinkType = new SqlParameter("@tk_link_type", strLinkType);
            SqlParameter spAddress = new SqlParameter("@tk_address", strAddress);
            SqlParameter spKeyword = new SqlParameter("@tk_keyword", strKeyword);
            SqlParameter spLinkDetail = new SqlParameter("@tk_link_detail", strLinkDetail);

            qCommand.Parameters.Clear();
            qCommand.Parameters.Add(spTaskID);
            qCommand.Parameters.Add(spDesc);
            qCommand.Parameters.Add(spLinkType);
            qCommand.Parameters.Add(spAddress);
            qCommand.Parameters.Add(spKeyword);
            qCommand.Parameters.Add(spLinkDetail);
            qCommand.CommandText = strQuery;
            qCommand.ExecuteNonQuery();

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
    public DataTable getAppListAll()
    {
        SqlConnection dbConnection = new SqlConnection(constantClass.dbConnectStr);
        dbConnection.Open();
        string strQ = "select * from struktAppList";

        SqlCommand qCommand = new SqlCommand(strQ, dbConnection);
        SqlDataReader qReader = qCommand.ExecuteReader();
        DataTable dtTable = new DataTable();
        dtTable.Load(qReader);
        dtTable.TableName = "struktAppList";
        dbConnection.Close();
        if (dtTable.Rows.Count > 0)
        {
            return dtTable;
        }
        else
        {
            return null;
        }
    }




    
}
