using System.Data.OleDb;
using System.Configuration;
using System.Data;
static class Objects // Created by: Joshua C. Magoliman
{
    public static OleDbConnection con = new OleDbConnection(ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString);
    public static OleDbCommand cmd;
    public static OleDbDataReader dr;

    public static OleDbDataAdapter da;
    public static DataTable dt;
    public static DataSet ds;
}

