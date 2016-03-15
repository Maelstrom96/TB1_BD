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
    public partial class AdminQuestions : Form
    {
        private ComboBox categorie { get; set; }
        private String question;
        private char selectedCategorie;
        private bool modificationMode = false;
        private Question question_;

        public AdminQuestions()
        {
            InitializeComponent();
            categorie = CB_Categories;
            var categories = Database_Connector.Select.Categories();
            foreach(String categorie_ in categories)
            {
                categorie.Items.Add(categorie_);
            }
        }

        public AdminQuestions(Question questiono) : this()
        {
            int i = 1;

            question_ = questiono;
            modificationMode = true;

            TXT_Question.Text = question_.GetQuestion();

            foreach(Reponse reponse in question_.GetReponses())
            {
                String control = "TXT_Answer" + i;
                Control txtbox = this.Controls[control];
                txtbox.Text = reponse.GetReponse();

                if (reponse.EstBonne())
                {
                    String control2 = "RB_Good" + i;
                    Control rb = this.Controls[control2];
                    RadioButton cc = (RadioButton)rb;
                    cc.Checked = true;
                }
                i++;
            }
        }

        private char GetColor()
        {
            switch(CB_Categories.SelectedItem.ToString().Trim())
            {
                case "Sports":          return 'O';
                case "Science":         return 'V';
                case "Geographie":      return 'B';
                case "Histoire":        return 'R';
                default:                return 'w';
            }
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            selectedCategorie = GetColor();
            question = TXT_Question.Text;

            if (selectedCategorie != 'w')
            {
                Database_Connector.Insert.Questions(question, selectedCategorie);
                Database_Connector.Insert.Answer(question, TXT_Answer1.Text, RB_Good1.Checked ? true : false);
                Database_Connector.Insert.Answer(question, TXT_Answer2.Text, RB_Good2.Checked ? true : false);
                Database_Connector.Insert.Answer(question, TXT_Answer3.Text, RB_Good3.Checked ? true : false);
                Database_Connector.Insert.Answer(question, TXT_Answer4.Text, RB_Good4.Checked ? true : false);
            }
            this.Close();
        }
    }
}
