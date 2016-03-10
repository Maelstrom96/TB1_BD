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
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            wheel.Draw(e);
        }

        public void Run()
        {
            wheel.RandSpin();
            while (wheel.Spinning())
            {
                for (int i = 0; i < 30; i++)
                {
                    Invalidate();
                }
            }
            label1.Text = wheel.GetCurrentPick().ToString();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive || t.ThreadState.Equals(ThreadState.Unstarted))
            {
                t.Abort();
                t = new Thread(new ThreadStart(Run));
                t.Start();
            }
        }
    }
}
