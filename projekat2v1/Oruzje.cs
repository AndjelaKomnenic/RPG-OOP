using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace projekat2v1
{
    class Oruzje
    {
        private SolidBrush sb;
        private int brzina;
        public int X { get; set; }
        public int Y { get; set; }
        public int R { get; set; }
        public int MouseX { get; set; }
        public int MouseY { get; set; }
        public bool stop = false;

        public Oruzje(Igrac igrac) 
        {
            X = igrac.X + igrac.A / 2;
            Y = igrac.Y + igrac.A / 2;
            R = 5;
            brzina = 10;
            sb = new SolidBrush(Color.OrangeRed);
        }

        public void nacrtajSe(Graphics g) 
        {
            g.FillEllipse(sb, X, Y, R, R);
        }
        public void pomeriSe(int klikX, int klikY) 
        {
            if (Math.Abs(klikY - Y) < 10 && Math.Abs(klikX - X) < 10)
            {
                stop = true;
            }
            double alfa = Math.Atan2((klikY - Y), (klikX - X));
            double dx = brzina * Math.Cos(alfa);
            double dy = brzina * Math.Sin(alfa);

            X += (int)dx;
            Y += (int)dy;
        }

    }
}
