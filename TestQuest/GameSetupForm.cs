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
    public partial class GameSetupForm : Form
    {
        public GameSetupForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_Player1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bt_Next_Click(object sender, EventArgs e)
        {
            try {
                if (tb_Player1.Text.Trim().Equals(String.Empty)) throw new Exception("Le joueur #1 ne peut avoir un nom vide.");
                if (tb_Player2.Text.Trim().Equals(String.Empty)) throw new Exception("Le joueur #2 ne peut avoir un nom vide.");

                List<Joueur> joueurs = new List<Joueur>();
                joueurs.Add(Database_Connector.Select.Joueur(tb_Player1.Text));
                joueurs.Add(Database_Connector.Select.Joueur(tb_Player2.Text));

                Hide();
                var GameForm = new GameForm(joueurs.ToArray());
                GameForm.Closed += (s, args) => this.Close();
                GameForm.Show();
            }
            catch(PlayerNotFoundException pe)
            {
                DialogResult diagr = new AdminJoueurs(pe.Message).ShowDialog();
                if (diagr != DialogResult.Cancel)
                {
                    bt_Next_Click(null, null);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
