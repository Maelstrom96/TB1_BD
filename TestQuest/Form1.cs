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
    public partial class Form1 : Form
    {
        Wheel wheel;

        public Form1()
        {
            InitializeComponent();
            wheel = new Wheel();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            wheel.Draw(e);
        }
    }
}
