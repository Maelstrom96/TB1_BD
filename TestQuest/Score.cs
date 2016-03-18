
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Score {
	private char categorie;
	private uint score = 0;

	public Score(char Categorie) {
        categorie = Categorie;
    }

	public uint GetScore() {
		return score;
	}

	public char GetCategorie() {
		return categorie;
	}

    public void Increment()
    {
        score++;
    }

}