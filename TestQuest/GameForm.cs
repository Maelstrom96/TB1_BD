using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public partial class GameForm : Form
    {
        private Wheel wheel;
        private BackgroundWorker bw = new BackgroundWorker();
        private Question quest;
        private GameManager gm;

        public GameForm(Joueur[] joueurs_)
        {
            InitializeComponent();
            gm = new GameManager(joueurs_);

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            wheel = new Wheel(lb_Categorie, this.Width / 2);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_SpinComplete);

            Text = "TestQuest - " + gm.GetCurrentPlayer().GetAlias();
            SetPlayerName();
            SetBaseScores();
            UpdateScores();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            wheel.Draw(e);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            wheel.RandSpin();
            while (wheel.Spinning())
            {
                Invalidate();
            }
        }

        public void Run()
        {
            wheel.RandSpin();
            while (wheel.Spinning())
            {
                Invalidate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Database_Connector.CloseConnection();
        }

        private void bw_SpinComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            lb_Categorie.Text = wheel.GetCurrentPick().ToString();

            if (wheel.GetCurrentPick().ToString() != "Joker")
            {
                if (gm.GetCurrentPlayer().GetScore(CategorieQuestions.GetColor(wheel.GetCurrentPick().ToString())) < GameManager.GetMaxScore())
                    gm.CurrentPlayerPlay(wheel.GetCurrentPick().ToString());
            }
            else
            {
                JokerForm jkform = new JokerForm(gm.GetCurrentPlayer().GetAvailableCategory());
                jkform.ShowDialog();
                gm.CurrentPlayerPlay(jkform.Choix);
            }

            Text = "TestQuest - " + gm.GetCurrentPlayer().GetAlias();

            //CHECK VICTORY
            if (gm.VerifyVictory() != null)
            {
                Hide();
                Victoire formVictoire = new Victoire(gm);
                formVictoire.ShowDialog();
                Close();
            }

            UpdateScores();
        }

        private void SetBaseScores()
        {
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    if (lbl.Name.StartsWith("lb_BaseScore"))
                        lbl.Text = GameManager.GetMaxScore().ToString();

                }
            }
        }

        private void UpdateScores()
        {
            foreach (Control control in Controls)
            {
                if (control is Label)
                {
                    Label lbl = (Label)control;
                    if (lbl.Name.StartsWith("lb_Score"))
                        lbl.Text = gm.GetPlayerScore(int.Parse(lbl.Name[lbl.Name.Length - 2].ToString()) - 1, lbl.Name[lbl.Name.Length - 1]).ToString();

                }
            }
        }

        private void SetPlayerName()
        {
            lb_Joueur1.Text = gm.GetPlayers()[0].GetAlias();
            lb_Joueur2.Text = gm.GetPlayers()[1].GetAlias();
        }

        private void GameForm_MouseClick(object sender, MouseEventArgs e)
        {
            if (Math.Pow(e.X - wheel.GetCenter().X, 2) + Math.Pow(e.Y - wheel.GetCenter().Y, 2) < Math.Pow(wheel.GetRadius(), 2))
                if (!bw.IsBusy)
                    bw.RunWorkerAsync();
        }
    }
}
