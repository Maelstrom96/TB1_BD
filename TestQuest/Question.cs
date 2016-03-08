
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Question {
	/**
	 * 
	 */
	private uint ID;

	/**
	 * 
	 */
	private string question;

	/**
	 * 
	 */
	private char categorie;

	/**
	 * 
	 */
	private Reponse[] Reponse;

	/**
	 * 
	 */
	private Reponse BonneReponse;

	/**
	 * @param Reponses 
	 * @param Question
	 */
	public Question(Reponse[] Reponses, string Question) {
		// TODO implement here
	}

	/**
	 * @return
	 */
	public Reponse GetBonneReponse() {
		// TODO implement here
		return null;
	}

	/**
	 * @return
	 */
	public Reponse[] GetReponses() {
		// TODO implement here
		return null;
	}

	/**
	 * @return
	 */
	public override int GetHashCode() {
		// TODO implement here
		return 0;
	}

	/**
	 * @param other 
	 * @return
	 */
	public bool Equals(Question other) {
		// TODO implement here
		return false;
	}

}