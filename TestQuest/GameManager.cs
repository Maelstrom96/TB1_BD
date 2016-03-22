using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public class GameManager
    {
        private static int MaxScore = 1;
        private Joueur[] joueurs;
        private int currentPlayerIndex;
        private GestionQuestions gestionQuestions = new GestionQuestions();

        public GameManager(Joueur[] joueurs_)
        {
            currentPlayerIndex = 0;
            joueurs = joueurs_;
        }

        public Joueur GetCurrentPlayer()
        {
            return joueurs[currentPlayerIndex];
        }

        public Joueur[] GetPlayers()
        {
            return joueurs;
        }

        public void CurrentPlayerPlay(String Cat)
        {
            Question qt = gestionQuestions.GetQuestionAleatoire(Cat);
            QuestionForm form = new QuestionForm(qt, GetCurrentPlayer().GetAlias());
            DialogResult dr = form.ShowDialog();

            // Victory
            if (dr == DialogResult.Yes)
            {
                GetCurrentPlayer().IncrementScore(CategorieQuestions.GetColor(Cat));
            }
            else
            {
                SetNextPlayer();
            }
        }

        public uint GetPlayerScore(int index_, char categorie_)
        {
            return joueurs[index_].GetScore(categorie_);
        }

        public static int GetMaxScore()
        {
            return MaxScore;
        }

        private void SetNextPlayer()
        {
            if (currentPlayerIndex == joueurs.Length - 1) currentPlayerIndex = 0;
            else currentPlayerIndex++;
        }

        public Joueur VerifyVictory()
        {
            foreach(Joueur joueur in joueurs)
                if (joueur.GetAvailableCategory().Count == 0) return joueur;
            return null;
        }
    }
}
