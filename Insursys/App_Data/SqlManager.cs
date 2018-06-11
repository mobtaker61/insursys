using System;
using System.Data;
using System.Web;
using System.Web.Security;
using System.Data.SqlClient;
using System.Configuration;

public class SqlManager
{
    // کانکشن سایت
    #region MyRegion
    public SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DATA_DEFAULT"].ConnectionString);//
    #endregion
}
