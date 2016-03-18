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

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
