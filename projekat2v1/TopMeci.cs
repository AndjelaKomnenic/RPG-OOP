using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class TopMeci
    {
        private int x, y;
        private SolidBrush sb;
        private int a, r; 
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
        public TopMeci()
        {
            x = 170;
            y = 170;
            a = 3;
            r = 22;
            sb = new SolidBrush(Color.MediumPurple);
        }

        public void nacrtajSe(Graphics g)
        {
            for (int i = 1; i <= 3; i++)
            {
                g.FillRectangle(sb, x, y + i * 22, a, a);
            }
            /*for (int j = 1; j <= 2; j++)
            {
                g.FillRectangle(sb, x2, y2 + j * 22, a, a);
            }*/
        }

        public void pomeriSe() 
        {
            //x += 10/r - r; za suprotni smer
            x += r;
        }

        public bool sudar(Igrac igrac) 
        {
            if (igrac.X <= x + a && igrac.X + igrac.A >= x)
            {
                if (igrac.Y + igrac.A >= y && igrac.Y <= y + a)
                {
                    return true;
                }
                return false;
            }
            return false;
        }
    }
}
