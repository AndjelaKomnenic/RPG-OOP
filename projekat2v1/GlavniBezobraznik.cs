using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class GlavniBezobraznik
    {
        private int x, y, a;
        private SolidBrush sb;
        private int pomeraj;

        public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public GlavniBezobraznik()
        {
            x = 30;
            y = 330;
            a = 20;
            sb = new SolidBrush(Color.Orange);
            pomeraj = 10;
        }

        public void nacrtajSe(Graphics g)
        {
            g.FillRectangle(sb, X, Y, A, A);
        }

        public void pomerise_Y()
        {
            y += pomeraj;
        }

        public void okreni_y()
        {
            pomeraj = -pomeraj;
        }

        public bool sudar(Oruzje oruzje) 
        {
            if (oruzje.X <= x + a) 
            {
                if (oruzje.Y + oruzje.R >= y && oruzje.Y <= y + a) 
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
