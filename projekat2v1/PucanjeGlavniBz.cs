using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class PucanjeGlavniBz
    {
        private int pomeraj, a;
        private SolidBrush sb;
        public int X { get; set; }
        public int Y { get; set; }
        public PucanjeGlavniBz(GlavniBezobraznik gbz)
        {
            X = gbz.X + gbz.A / 2;
            Y = gbz.Y + gbz.A / 2;
            sb = new SolidBrush(Color.OrangeRed);
            pomeraj = 5;
            a = 10;
        }

        public void nacrtajSe(Graphics g)
        {
            g.FillEllipse(sb, X, Y, a, a);
        }
        public void pomeriSe()
        {
            X += pomeraj * 10;
        }

        public bool sudar(Igrac igrac)
        {
            if (igrac.X == X)
            {
                if (igrac.Y == Y)
                    return true;
                return false;
            }
            return false;
        }
    }
}
