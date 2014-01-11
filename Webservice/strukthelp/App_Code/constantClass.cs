using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Keep Constant
/// </summary>
public class constantClass
{
    public static string dbConnectStr = "workstation id=pakorndb.mssql.somee.com;packet size=4096;" +
                                            "user id=pakorncs_SQLLogin_1;pwd=vuoj9t4ept;data source=pakorndb.mssql.somee.com;" +
                                            "persist security info=False;initial catalog=pakorndb";
    public static string folderShared = "d:\\DZHosts\\LocalUser\\pakorncs\\www.pakorn.somee.com\\upload\\Files";
}