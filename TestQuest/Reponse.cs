
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Reponse {
    private int questionID_;
    private uint id_;
	private string reponse_;
    private bool bonne_;

	public Reponse(uint id, string reponse, bool bonne, int questid = 0) 
    {
        questionID_ = questid;
        id_ = id;
        reponse_ = reponse;
        bonne_ = bonne;
	}

	public string GetReponse() 
    {
		return reponse_;
	}

    public uint GetID()
    {
        return id_;
    }

    public bool EstBonne()
    {
        return bonne_;
    }

    public bool EqualQuestion(int questionID)
    {
        return questionID_.Equals(questionID);
    }

}