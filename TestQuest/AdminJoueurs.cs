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
    public partial class AdminJoueurs : Form
    {
        private Joueur player;
        public AdminJoueurs()
        {
            InitializeComponent();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            if (TXB_Alias.Text != "" && TXB_Name.Text != "" && TXB_Prenom.Text != "")
            {
                player = new Joueur(TXB_Alias.Text, TXB_Name.Text, TXB_Prenom.Text);
                Database_Connector.Insert.Players(player);
                this.Close();
            }
        }
    }
}
