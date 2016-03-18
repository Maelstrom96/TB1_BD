using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestQuest.Exceptions;

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
            if (conn_.State == ConnectionState.Closed) OpenConnection();
            return conn_;
        }

        static public void CloseConnection()
        {
            conn_.Close();
        }

        public static class Select
        {

            public static Question RandomQuestion(char categorie)
            {
                List<Reponse> repList = new List<Reponse>();
                Question question;

                OracleCommand questionListe = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                questionListe.CommandText = "GESTIONSQUESTIONS.CHERCHERQUESTION";
                questionListe.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                questionListe.Parameters.Add(oraReturn);

                OracleParameter oraParam = new OracleParameter("QCODE", OracleDbType.Char);
                oraParam.Direction = ParameterDirection.Input;
                oraParam.Value = categorie;
                questionListe.Parameters.Add(oraParam);

                using (OracleDataReader reader = questionListe.ExecuteReader())
                {
                    uint uid = 0;
                    String quest = null;
                    char code = '0';

                    while (reader.Read())
                    {
                        uid = uint.Parse(reader.GetDecimal(0).ToString());
                        quest = reader.GetString(1);
                        code = char.Parse(reader.GetString(2));
                    }
                    OracleCommand reponsesListe = new OracleCommand("GESTIONSREPONSES", Database_Connector.GetConnection());
                    reponsesListe.CommandText = "GESTIONSREPONSES.GETREP";
                    reponsesListe.CommandType = CommandType.StoredProcedure;

                    OracleParameter oraReturnRep = new OracleParameter("RETURN", OracleDbType.RefCursor);
                    oraReturnRep.Direction = ParameterDirection.ReturnValue;
                    reponsesListe.Parameters.Add(oraReturnRep);

                    OracleParameter ora = new OracleParameter("RCODE", OracleDbType.Int32);
                    ora.Direction = ParameterDirection.Input;
                    ora.Value = uid;
                    reponsesListe.Parameters.Add(ora);

                    using (OracleDataReader reader2 = reponsesListe.ExecuteReader())
                    {
                        while (reader2.Read())
                        {
                            repList.Add(new Reponse(uint.Parse(reader2.GetDecimal(0).ToString()), reader2.GetString(1), reader2.GetString(2).Equals("Y")));
                        }
                        question = new Question(uid, quest, code, repList.ToArray());
                    }

                    return question;
                }
            }
            public static Joueur Joueur(String alias)
            {
                OracleCommand joueurCommand = new OracleCommand("GESTIONSPLAYERS", Database_Connector.GetConnection());
                joueurCommand.CommandText = "GESTIONSPLAYERS.GETP";
                joueurCommand.CommandType = CommandType.StoredProcedure;

                OracleParameter oraReturn = new OracleParameter("RETURN", OracleDbType.RefCursor);
                oraReturn.Direction = ParameterDirection.ReturnValue;
                joueurCommand.Parameters.Add(oraReturn);

                OracleParameter oraParam = new OracleParameter("PALIAS", OracleDbType.Varchar2);
                oraParam.Direction = ParameterDirection.Input;
                oraParam.Value = alias;
                joueurCommand.Parameters.Add(oraParam);

                using (OracleDataReader reader = joueurCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Joueur(reader.GetString(0),reader.GetString(1),reader.GetString(2));
                    }
                    throw new PlayerNotFoundException(alias);
                }
            }

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
                Question question;

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
                    uint uid = 0;
                    String quest = null;
                    char code = '0';

                    while (reader.Read())
                    {
                        uid = uint.Parse(reader.GetDecimal(0).ToString());
                        quest = reader.GetString(1);
                        code = char.Parse(reader.GetString(2));

                        repList.Add(new Reponse(uint.Parse(reader.GetDecimal(3).ToString()), reader.GetString(4), reader.GetString(5).Equals("Y")));
                    }
                    question = new Question(uid, quest, code, repList.ToArray());
                }

                return question;
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

            //DELETE THE ANSWER WITH THE NUMQUESTION ID
            public static void Answer(int num)
            {
                OracleCommand answerDelete = new OracleCommand("GESTIONSREPONSES", Database_Connector.GetConnection());
                answerDelete.CommandText = "GESTIONSREPONSES.SUPPRIMER";
                answerDelete.CommandType = CommandType.StoredProcedure;

                OracleParameter numQuestion = new OracleParameter("QUESTION", OracleDbType.Int32);
                numQuestion.Direction = ParameterDirection.Input;
                numQuestion.Value = num;
                answerDelete.Parameters.Add(numQuestion);

                answerDelete.ExecuteNonQuery();
            }

            //DELETE THE QUESTION WITH THE NUMQUESTION ID
            public static void Question(int num)
            {
                OracleCommand questionDelete = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                questionDelete.CommandText = "GESTIONSQUESTIONS.SUPPRIMER";
                questionDelete.CommandType = CommandType.StoredProcedure;

                OracleParameter numQuestion = new OracleParameter("QUESTION", OracleDbType.Int32);
                numQuestion.Direction = ParameterDirection.Input;
                numQuestion.Value = num;
                questionDelete.Parameters.Add(numQuestion);

                questionDelete.ExecuteNonQuery();
            }

            //DELETE THE PLAYER WITH THE ALIAS OF THE PLAYER

            //TODO
            //CHECK IF ITS WORKING************************************************************************
            public static void Player(String pseudo)
            {
                OracleCommand questionDelete = new OracleCommand("GESTIONSPLAYERS", Database_Connector.GetConnection());
                questionDelete.CommandText = "GESTIONSPLAYERS.SUPPRIMER";
                questionDelete.CommandType = CommandType.StoredProcedure;

                OracleParameter alias = new OracleParameter("QUESTION", OracleDbType.Varchar2);
                alias.Direction = ParameterDirection.Input;
                alias.Value = pseudo;
                questionDelete.Parameters.Add(alias);

                questionDelete.ExecuteNonQuery();
            }
            
        }

        public static class Insert
        {
            //INSERT QUESTIONS WITH ANSWER IN (ADMINQUESTIONS)
            public static void Questions(String question, char selectedCategorie)
            {
                OracleCommand questionsAdd = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                questionsAdd.CommandText = "GESTIONSQUESTIONS.INSERTION";
                questionsAdd.CommandType = CommandType.StoredProcedure;

                OracleParameter paramQuestion = new OracleParameter("QUESTION", OracleDbType.Varchar2);
                paramQuestion.Direction = ParameterDirection.Input;
                paramQuestion.Value = question;
                questionsAdd.Parameters.Add(paramQuestion);

                OracleParameter paramCategorie = new OracleParameter("CATEGORIES", OracleDbType.Varchar2);
                paramCategorie.Direction = ParameterDirection.Input;
                paramCategorie.Value = selectedCategorie;
                questionsAdd.Parameters.Add(paramCategorie);

                questionsAdd.ExecuteNonQuery();

            }

            //INSERT ANSWER IN  WITH A QUERY TO GET THE NUMQUESTION WE JUST CREATED (ADMINQUESTIONS)
            public static void Answer(String question, String answer, bool goodAnswer)
            {
                string num;

                //GET QUESTION NUMBER THAT WE JUST CREATED TO INSERT THE ANSWER ACCORDINGLY TO THE QUESTION
                OracleCommand getNumQuest = new OracleCommand("GESTIONSQUESTIONS", Database_Connector.GetConnection());
                getNumQuest.CommandText = "GESTIONSQUESTIONS.GETNUMQ";
                getNumQuest.CommandType = CommandType.StoredProcedure;

                OracleParameter numQuest = new OracleParameter("NUMQUESTION", OracleDbType.Int32);
                numQuest.Direction = ParameterDirection.ReturnValue;
                getNumQuest.Parameters.Add(numQuest);

                OracleParameter getQuestion = new OracleParameter("QUESTION", OracleDbType.Varchar2);
                getQuestion.Direction = ParameterDirection.Input;
                getQuestion.Value = question;
                getNumQuest.Parameters.Add(getQuestion);

                getNumQuest.ExecuteScalar();
                num = getNumQuest.Parameters["NUMQUESTION"].Value.ToString();

                //INSERT THE ANSWER ACCORDINGLY TO THE QUESTION WE JUST INSERTED
                OracleCommand answerAdd = new OracleCommand("GESTIONSREPONSES", Database_Connector.GetConnection());
                answerAdd.CommandText = "GESTIONSREPONSES.INSERTION";
                answerAdd.CommandType = CommandType.StoredProcedure;

                OracleParameter answerToAdd = new OracleParameter("ANSWER", OracleDbType.Varchar2);
                answerToAdd.Direction = ParameterDirection.Input;
                answerToAdd.Value = answer;
                answerAdd.Parameters.Add(answerToAdd);

                OracleParameter good = new OracleParameter("GOOD", OracleDbType.Char);
                good.Direction = ParameterDirection.Input;
                if (goodAnswer) good.Value = "Y";
                else good.Value = "N";
                answerAdd.Parameters.Add(good);

                OracleParameter numQuestion = new OracleParameter("NUMQUESTION", OracleDbType.Varchar2);
                numQuestion.Direction = ParameterDirection.Input;
                numQuestion.Value = num;
                answerAdd.Parameters.Add(numQuestion);

                answerAdd.ExecuteNonQuery();
            }

            //INSERT PLAYERS IN (ADMINPLAYERS)
            public static void Player(Joueur player)
            {
                try
                {
                    Database_Connector.Select.Joueur(player.GetAlias());
                    throw new PlayerAlreadyExistException(player.GetAlias());
                }
                catch(PlayerNotFoundException pnf)
                {
                    //Nothing
                }

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
