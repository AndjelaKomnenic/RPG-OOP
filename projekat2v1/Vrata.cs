using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class Vrata
    {
        private int x, y, sirina, visina;
        private SolidBrush sb;
        public Vrata() 
        {
            x = 260;
            y = 50;
            sirina = 10;
            visina = 20;
            sb = new SolidBrush(Color.Red);
        }

        public void nacrtajSe(Graphics g) 
        {
            g.FillRectangle(sb, x, y, sirina, visina);
        }

        public bool sudar(int igracX, int a, int igracY) 
        {
            if (igracX + a >= x && igracY >= 50 && igracY <= 60) 
            {
                return true;
            }
            return false;
        }
    }
}
