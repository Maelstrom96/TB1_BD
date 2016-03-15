
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Question {
	private uint ID;
	private string question;
	private char codeCategorie;
	private Reponse[] reponses;
	private Reponse bonneReponse;

	/**
	 * @param Reponses 
	 * @param Question
	 */
	public Question(uint Id, string Question, char CodeCategorie, Reponse[] Reponses) {
        ID = Id;
        question = Question;
        codeCategorie = CodeCategorie;
        reponses = Reponses;
        bonneReponse = FindBonneReponse();
	}

    private Reponse FindBonneReponse()
    {
        foreach(Reponse reponse in reponses)
        {
            if (reponse.EstBonne()) return reponse;
        }
        throw new Exception("No answer");
    }

    public String GetQuestion()
    {
        return question;
    }

    public char GetCategorie()
    {
        return codeCategorie;
    }

	public Reponse GetBonneReponse() {
		return bonneReponse;
	}

	public Reponse[] GetReponses() {
		return reponses;
	}

	public override int GetHashCode() {
		return 0;
	}

	public bool Equals(Question other) {
		// TODO implement here
		return false;
	}

}