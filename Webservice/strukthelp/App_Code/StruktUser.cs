﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;

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
    
}