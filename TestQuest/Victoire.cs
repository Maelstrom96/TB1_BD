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
    public partial class Victoire : Form
    {
        public Victoire(GameManager gm)
        {
            InitializeComponent();

            lb_PlayerStats.Text = gm.GetPlayers()[0].GetAlias() + " - "
                + gm.GetPlayers()[0].GetTotalScore().ToString() + " : "
                + gm.GetPlayers()[1].GetTotalScore().ToString() + " - "
                + gm.GetPlayers()[1].GetAlias();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
