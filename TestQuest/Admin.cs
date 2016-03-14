using Oracle.DataAccess.Client;
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
    public partial class Admin : Form
    {

        private int btn_pressed;    //1 = questions, 2 = players
        public DataGridView dgv_admin { get; set; }
        public Admin()
        {
            InitializeComponent();
            dgv_admin = DGV_Admin;
            btn_pressed = 0;
        }

        private void BTN_Questions_Click(object sender, EventArgs e)
        {
            BTN_Add.Visible = true;
            BTN_Delete.Visible = true;
            BTN_Modifier.Visible = true;
            btn_pressed = 1;

            dgv_admin.DataSource = Database_Connector.Select.Questions();
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            if (btn_pressed == 1)
            {
                AdminQuestions questions = new AdminQuestions();
                questions.ShowDialog();
            }
            if (btn_pressed == 2)
            {
                AdminJoueurs players = new AdminJoueurs();
                players.ShowDialog();
            }
        }

        private void BTN_Players_Click(object sender, EventArgs e)
        {
            BTN_Add.Visible = true;
            BTN_Delete.Visible = true;
            BTN_Modifier.Visible = true;

            btn_pressed = 2;
            dgv_admin.DataSource = Database_Connector.Select.Players();
        }
    }
}
