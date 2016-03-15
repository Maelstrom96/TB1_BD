
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
    public static char GetColor(String categorie)
    {
        switch (categorie)
        {
            case "Sports": return 'O';
            case "Science": return 'V';
            case "Geographie": return 'B';
            case "Histoire": return 'R';
            default: return 'w';
        }
    }

    public static String GetName(char color)
    {
        switch (color)
        {
            case 'O': return "Sports";
            case 'V': return "Science";
            case 'B': return "Geographie";
            case 'R': return "Histoire";
            default: return "Joker";
        }
    }
}

public enum Categories
{
    // couleurs
    // Orange, vert, bleu, rouge
    Sport, Science, Geographie, Histoire, Joker
}
public enum CouleursCategorie
{
    Orange, Vert, Bleu, Rouge, Blanc
}