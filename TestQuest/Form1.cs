using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public partial class Form1 : Form
    {
        Wheel wheel;
        Thread t;

        public Form1()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            wheel = new Wheel();
            t = new Thread(new ThreadStart(Run));
            t.Start();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            wheel.Draw(e);
        }

        public void Run()
        {
            while (true)
            {
                for (int i = 0; i < 30; i++)
                {
                    Invalidate();
                    Thread.Sleep(10);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t.Resume();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            t.Suspend();
        }
    }
}
