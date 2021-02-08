using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class Topovi
    {
        private int a;
        private SolidBrush sb;

        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }

        public Topovi(int x1, int y1, int x2, int y2)
        {
            X1 = x1;
            Y1 = y1;
            X2 = x2;
            Y2 = y2;
            a = 10;
            sb = new SolidBrush(Color.MediumPurple);
        }

        public void nacrtajSe(Graphics g) 
        {
            for (int i = 1; i <= 3; i++)
            {
                g.FillRectangle(sb, X1, Y1 + i * 20, a, a);
            }
            /*for (int j = 1; j <= 2; j++)
            {
                g.FillRectangle(sb, X2, Y2 + j * 20, a, a);
            }*/
        }
        
    }
}
