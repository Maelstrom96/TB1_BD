using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Joueur {
	private string Alias;
	private string Nom;
	private string Prenom;
	private Score[] Scores;

	public Joueur(string alias, string nom, string prenom) {
        Alias = alias;
        Nom = nom;
        Prenom = prenom;
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

	public uint GetScore(char categorie) {
		// TODO implement here
		return 0;
	}

}