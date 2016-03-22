using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestQuest
{
    public class Wheel
    {
        // Sounds
        SoundPlayer simpleSound = new SoundPlayer(Properties.Resources.tik_ori);

        // Colors
        Color outerGray = System.Drawing.ColorTranslator.FromHtml("#9EA2A3");
        SolidBrush[] colorBrushes = { new SolidBrush(Color.Orange), new SolidBrush(Color.Green), new SolidBrush(Color.Blue), new SolidBrush(Color.Red), new SolidBrush(Color.White) };
        Random rnd = new Random();

        // Brushes & Pens
        SolidBrush redBrush;
        Pen gray;
        Pen semiTransPen = new Pen(Color.FromArgb(64,Color.Black), 10);
        Pen smallline = new Pen(Color.FromArgb(200, Color.Black), 2);

        float indexAngle = 270; // Middle of White;
        float spin;
        const float maxspin = 2.93858612F;
        const float minspin = 2.748754F;
        Point center;

        const float diameter = 300.0F;
        const float radius = diameter / 2.0F;
        const float categorieAngle = 360.0F / nbCategories;
        const float halfCategorieAngle = categorieAngle / 2;
        const int nbCategories = 5;

        float posx;
        float posy;
        Label lb;

        public Wheel(Label Lb, float Posx_center = 175.0F, float Posy_center = 175.0F)
        {
            lb = Lb;
            posx = Posx_center - radius - 10;
            posy = Posy_center - radius;
            center = new Point((int)posx + (int)radius, (int)posy + (int)radius);

            redBrush = new SolidBrush(Color.Red);
            gray = new Pen(outerGray, 8);
        }

        public Categories GetCurrentPick()
        {
            if (indexAngle < 18) return Categories.Histoire;
            else if (indexAngle < 18 + (categorieAngle * 1)) return Categories.Geographie;
            else if (indexAngle < 18 + (categorieAngle * 2)) return Categories.Science;
            else if (indexAngle < 18 + (categorieAngle * 3)) return Categories.Sports;
            else if (indexAngle < 18 + (categorieAngle * 4)) return Categories.Joker;
            else return Categories.Histoire;
        }

        public Point GetCenter()
        {
            return center;
        }

        public float GetRadius()
        {
            return radius;
        }

        public void RandSpin()
        {
            spin = (float)(rnd.NextDouble() * (maxspin - minspin) + minspin);
        }

        public bool Spinning()
        {
            return spin != 0.0F;
        }

        public void PlayTicSound()
        {
            float tmp = (indexAngle + 51.0F) % categorieAngle;
            if (tmp < 2 && Spinning()) 
            {
                simpleSound.Play();
                lb.Text = GetCurrentPick().ToString();
                lb.Update();
            }
        }

        public void Draw(PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias; //Smooth

            for (int i = 0; i < nbCategories; i++)
            {
                DrawPie(i, (GetIndex() + halfCategorieAngle) + (categorieAngle * i), e);
            }

            // Fill pie to screen.
            DrawLines(e);
            e.Graphics.DrawEllipse(gray, posx, posy, diameter, diameter);
            e.Graphics.DrawEllipse(semiTransPen, posx + 8, posy + 8, diameter - 16, diameter - 16);
 
            indexAngle += spin;
            if (spin > 0) spin -= 0.0015F;
            else spin = 0.0F;

            PlayTicSound();
        }

        /**
         * Optimisé
         **/
        private Point GetLinePos(float angle)
        {
            double tmp = angle * (Math.PI / 180);
            double Bx = posx + radius + (radius * Math.Cos(tmp));
            double By = posy + radius + (radius * Math.Sin(tmp));
            return new Point((int)Bx, (int)By);
        }

        /**
         * Optimisé 
         **/
        private void DrawPie(int colorIndex, float startAngle, PaintEventArgs e)
        {
            e.Graphics.FillPie(colorBrushes[colorIndex], posx, posy, diameter, diameter, startAngle, categorieAngle);
        }

        /**
         * Optimisé
         **/ 
        private void DrawLines(PaintEventArgs e)
        {
            for (int i = 0; i < nbCategories; i ++)
                e.Graphics.DrawLine(smallline, center, GetLinePos(indexAngle + halfCategorieAngle + categorieAngle * (i + 1)));
        }

        private float GetIndex()
        {
            if (indexAngle > 360.0F) indexAngle -= 360.0F;
            return indexAngle;
        }
    }
}
