
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class CategorieQuestions {

    private char categorie;
    private List<Question> ListQuestions = new List<Question>();
    private String couleur;
    private String nomCategorie;
    static Random rnd = new Random();

	public CategorieQuestions(char cat_, String nom_, string couleur_) {
        categorie = cat_;
        nomCategorie = nom_;
        couleur = couleur_;
	}
	
    public String GetNomCategorie()
    {
        return nomCategorie;
    }

    public String GetCouleur()
    {
        return couleur;
    }

	public char GetCategorie() 
    {
		return categorie;
	}
	public Question GetQuestionAleatoire() 
    {
        if (ListQuestions.Count > 0)
        {
            int r = rnd.Next(ListQuestions.Count);
            return null;
        }
        else throw new NoQuestionException(GetCategorie().ToString());
	}
	public void AjouterQuestions(List<Question> list) 
    {
        ListQuestions.AddRange(list);
	}

    public void AjouterQuestions(Question quest)
    {
        ListQuestions.Add(quest);
    }

	public void Clear() {
        ListQuestions.Clear();
	}

	public bool Equals(char other) {
        return other.Equals(categorie);
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
    Sports, Science, Geographie, Histoire, Joker
}
public enum CouleursCategorie
{
    Orange, Vert, Bleu, Rouge, Blanc
}