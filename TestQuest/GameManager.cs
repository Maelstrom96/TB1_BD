using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestQuest
{
    class GameManager
    {
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
    }
}
