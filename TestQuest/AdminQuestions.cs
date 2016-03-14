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
        public ComboBox categorie { get; set; }

        public AdminQuestions()
        {
            InitializeComponent();
            categorie = CB_Categories;
            Database_Connector.Select.Categories(this);
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
