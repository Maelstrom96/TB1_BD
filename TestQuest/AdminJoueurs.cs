using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestQuest.Exceptions;

namespace TestQuest
{
    public partial class AdminJoueurs : Form
    {
        public AdminJoueurs()
        {
            InitializeComponent();
        }

        public AdminJoueurs(string alias) : this()
        {
            Text = "Nouveau joueur";

            DialogResult = DialogResult.Cancel;
            TXB_Alias.ReadOnly = true;
            TXB_Alias.Text = alias;
            TXB_Prenom.Focus();
        }

        private void BTN_Submit_Click(object sender, EventArgs e)
        {
            if (TXB_Alias.Text != "" && TXB_Name.Text != "" && TXB_Prenom.Text != "")
            {
                try
                {
                    Database_Connector.Insert.Player(new Joueur(TXB_Alias.Text, TXB_Name.Text, TXB_Prenom.Text));
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch(PlayerAlreadyExistException pae)
                {
                    MessageBox.Show("Le joueur possèdant l'alias " + pae.Message + " existe déjà.");
                }
            }
        }
    }
}
