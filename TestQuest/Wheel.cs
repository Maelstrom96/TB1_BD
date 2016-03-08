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

        float indexAngle = 0; // Middle of White;

        float diameter = 200.0F;
        float categorieAngle;

        float posx = 0.0F;
        float posy = 0.0F;

        public Wheel()
        {
            categorieAngle = 360.0F / 5.0F;
        }

        Categories GetCurrentPick()
        {
            return Categories.Vide;
        }

        public void Draw(PaintEventArgs e)
        {
            // SMOOOOOOTH
            e.Graphics.SmoothingMode =
                System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            // Create solid brush.
            SolidBrush redBrush = new SolidBrush(Color.Red);
            Pen gray = new Pen(outerGray, 5);

            for (int i = 0; i < 4; i++ )
            {
                DrawPie(colors[i], (GetIndex() + (categorieAngle / 2.0F)) + (categorieAngle * i), e);
            }

            // Fill pie to screen.
            //DrawPie(Color.Green, 180, e);
            e.Graphics.DrawEllipse(gray, posx, posy, diameter, diameter);
            indexAngle += 10;
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
