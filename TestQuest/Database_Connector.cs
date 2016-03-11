using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    public static class Database_Connector
    {
        static private OracleConnection conn_ = new OracleConnection();
        static private string DataSource = "(DESCRIPTION="
            + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
            + "(HOST=" + Properties.Settings.Default.DB_HostName
            + ")(PORT=" + Properties.Settings.Default.DB_Port.ToString()
            + ")))(CONNECT_DATA=(SERVICE_NAME=" + Properties.Settings.Default.DB_ServiceName
            + ")))";

        static private string ConnectionString;

        static public void OpenConnection()
        {
            ConnectionString = "Data Source =" + DataSource
                + " ; User Id=" + Properties.Settings.Default.DB_Username
                + " ; Password=" + Properties.Settings.Default.DB_Password + ";";

            if (conn_.State == ConnectionState.Closed)
            {
                conn_.ConnectionString = ConnectionString;
                conn_.Open();
            }
            else
            {
                //throw new Exception("Exception_DB_Already_Open");
            }
        }

        static public OracleConnection GetConnection()
        {
            if (conn_.State == ConnectionState.Closed) conn_.Open();
            return conn_;
        }

        static public void CloseConnection()
        {
            conn_.Close();
        }

        public static class Select
        {
           
        }

        public static class Delete
        {
            
        }

        public static class Insert
        {
            
        }

        public static class Update
        {
           
        }
    }
}
