using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class Bezobraznici
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

        public Bezobraznici()
        {
            x = 50;
            y = 50;
            a = 10;
            sb = new SolidBrush(Color.Purple);
            pomeraj = a;
        }

        public void nacrtajSe(Graphics g)
        {
            g.FillRectangle(sb, X, Y, A, A);
        }

        public void pomerise_X()
        {
            x += pomeraj;
        }

        public void okreni_x()
        {
            pomeraj = -pomeraj;
        }

        public bool sudar(Igrac igrac) 
        {
            if (igrac.X == x) 
            {
                if (igrac.Y == y)
                    return true;
                return false;
            }
            return false;
        }

    }
}
