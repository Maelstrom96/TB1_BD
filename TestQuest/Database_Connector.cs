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
            public static DataTable Players()
            {
                OracleCommand playersList = new OracleCommand("GESTIONSPLAYERS", Database_Connector.GetConnection());
                playersList.CommandText = "GESTIONSPLAYERS.LISTER";
                playersList.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                playersList.Parameters.Add(oraReturn);

                OracleDataAdapter adapter = new OracleDataAdapter(playersList);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                return dt;
            }
        }

        public static class Delete
        {
            
        }

        public static class Insert
        {
            //INSERT QUESTIONS WITH ANSWER IN (ADMINQUESTIONS)
            //TODO

            //INSERT PLAYERS IN (ADMINPLAYERS)
            public static void Players(Joueur player)
            {
                OracleCommand playersAdd = new OracleCommand("GESTIONSPLAYERS", Database_Connector.GetConnection());
                playersAdd.CommandText = "GESTIONSPLAYERS.INSERTION";
                playersAdd.CommandType = CommandType.StoredProcedure;

                OracleParameter alias = new OracleParameter("ALIAS", OracleDbType.Varchar2);
                alias.Direction = ParameterDirection.Input;
                alias.Value = player.GetAlias();
                playersAdd.Parameters.Add(alias);

                OracleParameter name = new OracleParameter("NAME", OracleDbType.Varchar2);
                name.Direction = ParameterDirection.Input;
                name.Value = player.GetNom();
                playersAdd.Parameters.Add(name);

                OracleParameter prenom = new OracleParameter("PRENOM", OracleDbType.Varchar2);
                prenom.Direction = ParameterDirection.Input;
                prenom.Value = player.GetPrenom();
                playersAdd.Parameters.Add(prenom);

                playersAdd.ExecuteNonQuery();
            }
        }

        public static class Update
        {
           
        }
    }
}
