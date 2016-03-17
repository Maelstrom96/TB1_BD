
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class CategorieQuestions {

    private char Categorie;
    private List<Question> ListQuestions;

	public CategorieQuestions() {
	}
	

	public char GetCategorie() {
		// TODO implement here
		return '\0';
	}
	public Question GetQuestionAleatoire() {
		// TODO implement here
		return null;
	}
	public void AjouterQuestions(List<Question> list) {
		// TODO implement here
	}
	public void Clear() {
		// TODO implement here
	}
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