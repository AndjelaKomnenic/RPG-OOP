using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace projekat2v1
{
    class Teren
    {
        private int sirinaOlovke, razmak;
        private Pen p;
        private SolidBrush sb;

        public int Razmak 
        {
            get { return razmak; }
            set { razmak = value; }
        }

        public int SirinaOlovke 
        {
            get { return sirinaOlovke; }
            set { sirinaOlovke = value; }
        }
        public Teren() 
        {
            razmak = 15;
            sirinaOlovke = 10;
            p = new Pen(Color.CadetBlue, sirinaOlovke);
            sb = new SolidBrush(Color.Moccasin);
        }

        public void nacrtajSe(Graphics g) 
        {
            Point A = new Point(razmak, razmak);
            Point B = new Point(7 * razmak, razmak);
            Point C = new Point(7 * razmak, 3 * razmak);
            Point D = new Point(11 * razmak, 3 * razmak);
            Point E = new Point(11 * razmak, razmak);
            Point F = new Point(17 * razmak, razmak);
            Point G = new Point(17 * razmak, 3 * razmak);
            Point H = new Point(21 * razmak, 3 * razmak);
            Point I = new Point(21 * razmak, razmak);
            Point J = new Point(33 * razmak, razmak);
            Point K = new Point(33 * razmak, 7 * razmak);
            Point L = new Point(21 * razmak, 7 * razmak);
            Point M = new Point(21 * razmak, 5 * razmak);
            Point N = new Point(17 * razmak, 5 * razmak);
            Point O = new Point(17 * razmak, 7 * razmak);
            Point P = new Point(15 * razmak, 7 * razmak);
            Point Q = new Point(15 * razmak, 11 * razmak);
            Point R = new Point(17 * razmak, 11 * razmak);
            Point S = new Point(17 * razmak, 17 * razmak);
            Point T = new Point(15 * razmak, 17 * razmak);
            Point U = new Point(15 * razmak, 21 * razmak);
            Point V = new Point(23 * razmak, 21 * razmak);
            Point W = new Point(23 * razmak, 27 * razmak);
            Point X = new Point(17 * razmak, 27 * razmak);
            Point Y = new Point(17 * razmak, 35 * razmak);
            Point Z = new Point(razmak, 35 * razmak);
            Point A1 = new Point(razmak, 21 * razmak);
            Point B1 = new Point(13 * razmak, 21 * razmak);
            Point C1 = new Point(13 * razmak, 17 * razmak);
            Point D1 = new Point(11 * razmak, 17 * razmak);
            Point E1 = new Point(11 * razmak, 11 * razmak);
            Point F1 = new Point(13 * razmak, 11 * razmak);
            Point G1 = new Point(13 * razmak, 7 * razmak);
            Point H1 = new Point(razmak, 7 * razmak);
            Point I1 = new Point(razmak, razmak);
            
            Point[] okvirProstora = new Point[] { A, B, C, D, E, F, G, H, I, J, K, L, M, N, O, P, Q, R, S, T, U, V, W, X, Y, Z,
                A1, B1, C1, D1, E1, F1, G1, H1, I1,};

            g.FillPolygon(sb, okvirProstora);
            g.DrawPolygon(p, okvirProstora);
        }
    }
}
