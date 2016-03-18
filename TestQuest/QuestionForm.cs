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
        public QuestionForm(Question question, String name)
        {
            InitializeComponent();
            Text = "Question (" + CategorieQuestions.GetName(question.GetCategorie()) + ") - " + name;
            DialogResult = DialogResult.Abort;
        }

        private void QuestionForm_Load(object sender, EventArgs e)
        {

        }
    }
}
