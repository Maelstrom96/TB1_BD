using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    class GameManager
    {
        private const int MaxScore = 3;
        private Joueur[] joueurs;
        private int currentPlayerIndex;
        private GestionQuestions gestionQuestions = new GestionQuestions();

        public GameManager(Joueur[] joueurs_)
        {
            currentPlayerIndex = 1;
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
        }

        public int GetMaxScore()
        {
            return MaxScore;
        }
    }
}
