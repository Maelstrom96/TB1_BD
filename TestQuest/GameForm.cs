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
        private Joueur[] joueurs;
        private Wheel wheel;
        private BackgroundWorker bw = new BackgroundWorker();
        private Question quest;
        private GameManager gm = new GameManager();

        public GameForm(Joueur[] joueurs_)
        {
            InitializeComponent();
            joueurs = joueurs_;

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            wheel = new Wheel(lb_Categorie, this.Width / 2);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_SpinComplete);
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

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }

        private void bw_SpinComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            LBL_Questions.Text = "";
            lb_Categorie.Text = wheel.GetCurrentPick().ToString();
            quest = Database_Connector.Select.RandomQuestion(CategorieQuestions.GetColor(lb_Categorie.Text));
            Reponse[] rep = quest.GetReponses();
            LBL_Questions.Text = quest.GetQuestion();
            BTN_Answer1.Visible = true;
            BTN_Answer1.Text = rep[0].GetReponse().ToString();
            BTN_Answer2.Visible = true;
            BTN_Answer2.Text = rep[1].GetReponse().ToString();
            BTN_Answer3.Visible = true;
            BTN_Answer3.Text = rep[2].GetReponse().ToString();
            BTN_Answer4.Visible = true;
            BTN_Answer4.Text = rep[3].GetReponse().ToString();
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }
    }
}
