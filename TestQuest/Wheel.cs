using System;
using System.Collections.Generic;
using System.Drawing;
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
        Color[] colors = {Color.Orange, Color.Green, Color.Blue, Color.Red};

        // Brushes & Pens
        SolidBrush redBrush;
        Pen gray;

        float indexAngle = 0; // Middle of White;

        float diameter = 200.0F;
        float categorieAngle;

        float posx = 0.0F;
        float posy = 0.0F;

        public Wheel()
        {
            categorieAngle = 360.0F / 5.0F;

            redBrush = new SolidBrush(Color.Red);
            gray = new Pen(outerGray, 5);
        }

        Categories GetCurrentPick()
        {
            return Categories.Vide;
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Smooth

            for (int i = 0; i < 4; i++ )
            {
                DrawPie(colors[i], (GetIndex() + (categorieAngle / 2.0F)) + (categorieAngle * i), e);
            }

            // Fill pie to screen.
            e.Graphics.DrawEllipse(gray, posx, posy, diameter, diameter);
            indexAngle += 1;
        }

        private void DrawPie(Color color, float startAngle, PaintEventArgs e)
        {
            SolidBrush brush = new SolidBrush(color);
            e.Graphics.FillPie(brush, posx, posy, diameter, diameter, startAngle, categorieAngle);
        }

        private float GetIndex()
        {
            if (indexAngle > 360.0F) indexAngle = indexAngle - 360.0F;
            return indexAngle;
        }
    }
}
