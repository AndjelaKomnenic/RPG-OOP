using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace projekat2v1
{
    class QuestCika
    {
        private int x, y, a;
        private SolidBrush sb;

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

        public QuestCika()
        {
            x = 230;
            y = 30;
            a =  10;
            sb = new SolidBrush(Color.Red);

        }

        public void nacrtajSe(Graphics g)
        {
            g.FillRectangle(sb, X, Y, A, A);
        }

        public bool uOkolini(Igrac igrac) 
        {
            if (igrac.X + igrac.A >= x && igrac.X <= x + a) 
            {
                if (igrac.Y + igrac.A >= y && igrac.Y <= y + a)
                    return true;
                return false;
            }
            return false;
        }

    }
}
