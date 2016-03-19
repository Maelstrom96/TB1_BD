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
    public partial class JokerForm : Form
    {
        String choice_;
        public JokerForm(ref String choice, List<String> AvailableCategories)
        {
            InitializeComponent();

            choice_ = choice;

            List<String> Categories = Database_Connector.Select.Categories();
            foreach (Control control in Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.Name.StartsWith("bt_Cat") && Categories.Count > 0)
                    {
                        btn.Text = Categories[0];

                        if (!AvailableCategories.Contains(Categories[0])) btn.Enabled = false;

                        Categories.RemoveAt(0);     
                    }
                }
            }
        }

        private void bt_Category_Click(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            choice_ = bt.Text;
            Close();
        }
    }
}
