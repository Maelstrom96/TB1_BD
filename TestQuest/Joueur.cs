using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TestQuest;

public class Joueur {
	private string Alias;
	private string Nom;
	private string Prenom;
	private Score[] Scores;

	public Joueur(string alias, string nom, string prenom) {
        Alias = alias;
        Nom = nom;
        Prenom = prenom;

        CreateScores();
	}

    private void CreateScores()
    {
        DataTable dt = Database_Connector.Select.TableCategories();
        List<Score> tmpList = new List<Score>();

        foreach (DataRow row in dt.Rows)
            tmpList.Add(new Score(char.Parse(row[0].ToString())));

        Scores = tmpList.ToArray();
    }

	public string GetAlias() {
        return Alias;
	}

	public string GetNom() {
		return Nom;
	}

	public string GetPrenom() {
		return Prenom;
	}

	public Score[] GetScores() {
		// TODO implement here
		return null;
	}

    public void IncrementScore(char categorie)
    {
        foreach(Score score in Scores)
        {
            if (score.GetCategorie() == categorie) score.Increment();
        }
    }

	public uint GetScore(char codeCategorie) {
		foreach(Score score in Scores)
            if (score.GetCategorie() == codeCategorie) return score.GetScore();
        throw new Exception("Score non créé!");
	}
}