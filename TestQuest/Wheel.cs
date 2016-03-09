using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public class Wheel
    {
        //Colors
        Color outerGray = System.Drawing.ColorTranslator.FromHtml("#9EA2A3");
        Color[] colors = {Color.Orange, Color.Green, Color.Blue, Color.Red, Color.White};
        Random rnd = new Random();

        // Brushes & Pens
        SolidBrush redBrush;
        Pen gray;
        Pen semiTransPen = new Pen(Color.FromArgb(64,Color.Black), 10);
        Pen smallline = new Pen(Color.FromArgb(200, Color.Black), 2);

        float indexAngle = 0; // Middle of White;
        float spin;
        const float maxspin = 3.5F;
        const float minspin = 2.5F;
        Point center = new Point((int)posx + (int)radius, (int)posy + (int)radius);

        const float diameter = 300.0F;
        const float radius = diameter / 2.0F;
        const float categorieAngle = 360.0F / 5.0F;

        const float posx = 25.0F;
        const float posy = 25.0F;

        public Wheel()
        {
            redBrush = new SolidBrush(Color.Red);
            gray = new Pen(outerGray, 8);
        }

        Categories GetCurrentPick()
        {
            return Categories.Vide;
        }

        public void RandSpin()
        {
            spin = (float)(rnd.NextDouble() * (maxspin - minspin) + minspin);
        }

        public bool Spinning()
        {
            return spin != 0.0F;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Smooth

            for (int i = 0; i < 5; i++ )
            {
                DrawPie(colors[i], (GetIndex() + (categorieAngle / 2.0F)) + (categorieAngle * i), e);
            }

            // Fill pie to screen.
            DrawLines(e);
            e.Graphics.DrawEllipse(gray, posx, posy, diameter, diameter);
            e.Graphics.DrawEllipse(semiTransPen, posx + 8, posy + 8, diameter - 16, diameter - 16);
 
            indexAngle += spin;
            if (spin > 0) spin -= 0.0015F;
            else spin = 0.0F;
        }

        private Point GetLinePos(float angle)
        {
            double Bx = posx + radius + (radius * Math.Cos(angle * (Math.PI / 180)));
            double By = posy + radius + (radius * Math.Sin(angle * (Math.PI / 180)));
            return new Point((int)Bx, (int)By);
        }

        private void DrawPie(Color color, float startAngle, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(color);
            e.Graphics.FillPie(brush, posx, posy, diameter, diameter, startAngle, categorieAngle);
        }

        private void DrawLines(PaintEventArgs e)
        {
            for (int i = 0; i < 5; i ++)
            {
                e.Graphics.DrawLine(smallline, center, GetLinePos(indexAngle + (categorieAngle / 2) + categorieAngle * (i + 1)));
            }
        }

        private float GetIndex()
        {
            if (indexAngle > 360.0F) indexAngle = indexAngle - 360.0F;
            return indexAngle;
        }
    }
}
