using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            //() = FORM NAME
            //SELECT FOR QUESTIONS TO PUPOLATE THE DGV IN (ADMIN)
            public static DataTable Questions()
            {
                OracleCommand questionListe = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                questionListe.CommandText = "GESTIONSQUESTIONS.LISTER";
                questionListe.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                questionListe.Parameters.Add(oraReturn);

                OracleDataAdapter adapter = new OracleDataAdapter(questionListe);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }

            public static Question Question(int NumQuestion)
            {
                List<Reponse> repList = new List<Reponse>();

                OracleCommand questionListe = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                questionListe.CommandText = "GESTIONSQUESTIONS.GETQ";
                questionListe.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                questionListe.Parameters.Add(oraReturn);

                OracleParameter oraParam = new OracleParameter("QCODE", OracleDbType.Int32);
                oraParam.Direction = ParameterDirection.Input;
                oraParam.Value = NumQuestion;
                questionListe.Parameters.Add(oraParam);

                using (OracleDataReader reader = questionListe.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //repList
                    }
                }

                return 

            }

            //SELECT FOR CATEGORIES TO POPULATE THE COMBO BOX IN ADD QUESTIONS (ADMINQUESTIONS)
            public static List<String> Categories()
            {
                List<String> list = new List<String>();

                OracleCommand categoriesListe = new OracleCommand("GESTIONSCATEGORIES", Database_Connector.GetConnection());
                categoriesListe.CommandText = "GESTIONSCATEGORIES.LISTER";
                categoriesListe.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                categoriesListe.Parameters.Add(oraReturn);

                using (OracleDataReader reader = categoriesListe.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(reader.GetString(0));
                    }
                }

                return list;
            }

            //SELECT FOR PLAYERS TO POPULATE THE DGV IN (ADMIN)
            //TODO
        }

        public static class Delete
        {
            
        }

        public static class Insert
        {
            //INSERT QUESTIONS WITH ANSWER IN (ADMINQUESTIONS)
        }

        public static class Update
        {
           
        }
    }
}
