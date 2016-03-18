
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TestQuest;

/**
 * 
 */
public class GestionQuestions {

    //private HashSet<Question> QuestionsUtilise;
    private List<CategorieQuestions> ListCatQuestions = new List<CategorieQuestions>();

	public GestionQuestions() {
        LoadCategorieQuestions();
        GetQuestionsFromDB();
	}

	private void AjouterQuestion(Question question) {

	}
	private void SupprimerQuestion(Question question) {

	}

	public Question GetQuestionAleatoire(char Category) {

		return null;
	}
	private void GetQuestionsFromDB() {
        DataTable dtQuest = Database_Connector.Select.Questions();
        List<Reponse> listRep = Database_Connector.Select.Reponses();

        foreach(DataRow row in dtQuest.Rows)
        {
            Reponse[] repArray = listRep.FindAll(a => a.EqualQuestion(int.Parse(row[0].ToString()))).ToArray();
            Question qt = new Question(uint.Parse(row[0].ToString()), row[1].ToString(), CategorieQuestions.GetColor(row[2].ToString()), repArray);
            ListCatQuestions.First((a => a.GetNomCategorie() == row[2].ToString())).AjouterQuestions(qt);
        }
	}

    private void LoadCategorieQuestions()
    {
        DataTable dt = Database_Connector.Select.TableCategories();

        foreach(DataRow row in dt.Rows)
            ListCatQuestions.Add(new CategorieQuestions(char.Parse(row[0].ToString()), row[1].ToString(), row[2].ToString()));
    }
}