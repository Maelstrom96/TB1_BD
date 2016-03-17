
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class GestionQuestions {

	/**
	 * 
	 */
	public GestionQuestions() {
	}

	/**
	 * 
	 */
	private HashSet<Question> QuestionsUtilise;

	/**
	 * 
	 */
	private List<CategorieQuestions> ListQuestions;

	/**
	 * @param question
	 */
	private void AjouterQuestion(Question question) {
		// TODO implement here
	}

	/**
	 * @param question
	 */
	private void SupprimerQuestion(Question question) {
		// TODO implement here
	}

	/**
	 * @param old 
	 * @param new
	 */
	public void ModifierQuestion(Question old, Question new_) {
		// TODO implement here
	}

	/**
	 * @param Category 
	 * @return
	 */
	public Question GetQuestionAleatoire(char Category) {
		// TODO implement here
		return null;
	}

	/**
	 * @param Qty 
	 * @return
	 */
    public List<Question> GetQuestionsFromDB(uint Qty, Categories cat)
    {

		return null;
	}

}