using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public partial class QuestionForm : Form
    {
        private static Random rnd = new Random();
        private Question question;
        private Button[] lb;
        private DialogResult dr = DialogResult.Abort;

        public QuestionForm(Question question_, String name)
        {
            InitializeComponent();

            question = question_;
            Button[] lb_ = { bt_Rep1, bt_Rep2, bt_Rep3, bt_Rep4 };
            lb = lb_;

            Text = "Question (" + CategorieQuestions.GetName(question.GetCategorie()) + ") - " + name;
            DialogResult = DialogResult.Abort;

            LoadQuestion();
        }

        public void LoadQuestion()
        {
            lb_Question.Text = question.GetQuestion();
            List<Reponse> listRep = question.GetReponses().ToList();
            foreach(Button bt in lb)
            {
                int r = rnd.Next(listRep.Count);
                bt.Text = listRep[r].GetReponse();
                listRep.RemoveAt(r);
            }
        }

        private void bt_Answer_Click(object sender, EventArgs e)
        {
            if (sender is Button && dr == DialogResult.Abort)
            {
                Button bt = (Button)sender;
                if (bt.Text == question.GetBonneReponse().GetReponse())
                {
                    bt.BackColor = Color.Green;
                    timer.Enabled = true;
                    dr = DialogResult.Yes;
                }
                else
                {
                    bt.BackColor = Color.Red;
                    timer.Enabled = true;
                    dr = DialogResult.No;

                    foreach(Button btn in lb)
                    {
                        if (btn.Text == question.GetBonneReponse().GetReponse()) btn.BackColor = Color.Green;
                    }
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DialogResult = dr;
        }
    }
}
