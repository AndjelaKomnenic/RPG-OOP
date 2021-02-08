using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class kolekcionarskiPredmet
    {
        private int x, y;
        private SolidBrush sb;
        private int a;
        /*public int X
        {
            get { return x; }
            set { x = value; }
        }

        public int Y
        {
            get { return y; }
            set { y = value; }
        }*/
        public kolekcionarskiPredmet(int x, int y)
        {
            this.x = x;
            this.y = y;
            a = 5;
            sb = new SolidBrush(Color.DarkMagenta);
        }

        public void nacrtajSe(Graphics g) 
        {
            g.FillRectangle(sb, x, y, a, a);
        }

        public bool sudar(int igracX, int igracY) 
        {
            if (igracX == x && igracY == y) 
            {
                return true;
            }
            return false;
        }
    }
}
