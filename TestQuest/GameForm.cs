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
    public partial class GameForm : Form
    {
        private Wheel wheel;
        private BackgroundWorker bw = new BackgroundWorker();

        public GameForm()
        {
            InitializeComponent();

            this.SetStyle(
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint |
                ControlStyles.DoubleBuffer,
                true);

            wheel = new Wheel(lb_Categorie, this.Width / 2);
            bw.DoWork += new DoWorkEventHandler(bw_DoWork);
            bw.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_SpinComplete);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            wheel.Draw(e);
        }

        private void bw_DoWork(object sender, DoWorkEventArgs e)
        {
            wheel.RandSpin();
            while (wheel.Spinning())
            {
                Invalidate();
            }
        }

        public void Run()
        {
            wheel.RandSpin();
            while (wheel.Spinning())
            {
                Invalidate();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!bw.IsBusy)
            {
                bw.RunWorkerAsync();
            }
        }

        private void bw_SpinComplete(object sender, RunWorkerCompletedEventArgs e)
        {
            lb_Categorie.Text = wheel.GetCurrentPick().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void BTN_Admin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
