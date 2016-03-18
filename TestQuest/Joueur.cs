using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Joueur {
	private string Alias;
	private string Nom;
	private string Prenom;
	private Score[] Scores;
    private uint Score;

	public Joueur(string alias, string nom, string prenom) {
        Alias = alias;
        Nom = nom;
        Prenom = prenom;
	}

    public Joueur(string alias)
    {

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

	public uint GetScore() {
		return Score;
	}

    public void SetScore(uint i)
    {
        Score += i;
    }

}