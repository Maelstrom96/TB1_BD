
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class CategorieQuestions {

	/**
	 * 
	 */
	public CategorieQuestions() {
	}

	/**
	 * 
	 */
	private char Categorie;

	/**
	 * 
	 */
	private List<Question> ListQuestions;

	/**
	 * @return
	 */
	public char GetCategorie() {
		// TODO implement here
		return '\0';
	}

	/**
	 * @return
	 */
	public Question GetQuestionAleatoire() {
		// TODO implement here
		return null;
	}

	/**
	 * @param list
	 */
	public void AjouterQuestions(List<Question> list) {
		// TODO implement here
	}

	/**
	 * 
	 */
	public void Clear() {
		// TODO implement here
	}

	/**
	 * @param other
	 */
	public void Equals(char other) {
		// TODO implement here
	}
}

public enum Categories
{
    // couleurs
    // Orange, vert, bleu, rouge
    Sport, Science, Geographie, Histoire, Vide
}
public enum CouleursCategorie
{
    Orange, Vert, Bleu, Rouge, Blanc
}