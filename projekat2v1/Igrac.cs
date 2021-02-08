using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace projekat2v1
{
    class Igrac
    {
        private int x, y, a;
        private int pomeraj;
        private SolidBrush sb;
        private QuestCika quest;
        private Teren teren;

        public int X {
            get { return x; }
            set { x = value; }
        }

        public int Y {
            get { return y; }
            set { y = value; }
        }

        public int A {
            get { return a; }
            set { a = value; }
        }

        public Igrac() 
        {
            x = 20;
            y = 20;
            a = pomeraj = 10;
            sb = new SolidBrush(Color.Blue);
            quest = new QuestCika();
            teren = new Teren();
        }

        public void nacrtajSe(Graphics g) 
        {
            g.FillRectangle(sb, X, Y, A, A);
        }

        public void pomerise_X(int pomeraj)
        {
            x += pomeraj;
        }
        public void pomerise_Y(int pomeraj)
        {
            y += pomeraj;
        }

        public bool pomeriIgraca(Keys kljuc, Igrac igrac)
        {

            if (kljuc == Keys.A)
            {
                if (x + a <= quest.X || quest.uOkolini(igrac) == false)
                {
                    if (x == 170 && y >= 20 && y <= 40 || x == 170 && y >= 170 & y <= 240)
                    {
                        if (9 * teren.Razmak + teren.SirinaOlovke >= x)
                        {
                            pomerise_X(-pomeraj);
                            return true;
                        }
                    }
                    else if ((x == 320 && y >= 20 && y <= 40) || (x == 320 && y >= 70 && y <= 90))
                    {
                        if (19 * teren.Razmak + teren.SirinaOlovke >= x)
                        {
                            pomerise_X(-pomeraj);
                            return true;
                        }
                    }
                    else if (y >= 100 && y <= 160 && x == 200 || y >= 250 && y <= 310 && x == 200)
                    {
                        if (11 * teren.Razmak + teren.SirinaOlovke >= x)
                        {
                            pomerise_X(-pomeraj);
                            return true;
                        }
                    }
                    else
                    {
                        if (teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(-pomeraj);
                            return true;
                        }
                    }
                } 
            }
            if (kljuc == Keys.D)
            {
                if (x >= quest.X + quest.A || quest.uOkolini(igrac) == false)
                {
                    if (x == 90 && y >= 20 && y <= 40)
                    {
                        if (7 * teren.Razmak + teren.SirinaOlovke <= x || 17 * teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                    else if ((x == 240 && y >= 20 && y <= 40) || (x == 240 && y >= 70 && y <= 90))
                    {
                        if (17 * teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                    else if (y >= 100 && y <= 160 && x == 210 || y >= 250 && y <= 310 && x == 210)
                    {
                        if (15 * teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                    else if (y >= 170 && y <= 240 && x == 240 || x == 240 && y >= 400 && y <= 520)
                    {
                        if (17 * teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                    else if (x == 330 && y >= 320 && y <= 400)
                    {
                        if (23 * teren.Razmak + teren.SirinaOlovke <= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                    else
                    {
                        if (31 * teren.Razmak + teren.SirinaOlovke >= x)
                        {
                            pomerise_X(pomeraj);
                            return true;
                        }
                    }
                }
            }
            if (kljuc == Keys.W) 
            {
                if (y + a <= quest.Y || quest.uOkolini(igrac) == false)
                {
                    if ((x >= 100 && x <= 160 && y == 50) || (x >= 250 && x <= 310 && y == 50))// radi uwu
                    {
                        if (3 * teren.Razmak + teren.SirinaOlovke <= y)
                        {
                            pomerise_Y(-pomeraj);
                            return true;
                        }
                    }
                    else if (x >= 20 && x <= 190 && y == 320 || x >= 220 && x <= 330 && y == 320)
                    {
                        if (21 * teren.Razmak + teren.SirinaOlovke <= y)
                        {
                            pomerise_Y(-pomeraj);
                            return true;
                        }
                    }
                    else if (x >= 220 && x <= 240 && y == 170 || x >= 170 && x <= 190 && y == 170)
                    {
                        if (11 * teren.Razmak + teren.SirinaOlovke <= y)
                        {
                            pomerise_Y(-pomeraj);
                            return true;
                        }
                    }
                    else
                    {
                        if (teren.Razmak + teren.SirinaOlovke <= y)
                        {
                            pomerise_Y(-pomeraj);
                            return true;
                        }
                    }
                }
            }
            if (kljuc == Keys.S) 
            {
                if (y >= quest.Y + quest.A || quest.uOkolini(igrac) == false)
                {
                    if (x >= 20 && x <= 190 && y == 90 || x >= 220 && x <= 240 && y == 90 || x >= 320 && x <= 490 && y == 90) // radi uwu
                    {
                        if (5 * teren.Razmak + teren.SirinaOlovke >= y)
                        {
                            pomerise_Y(pomeraj);
                            return true;
                        }
                    }
                    else if (x >= 250 && x <= 310 && y == 60)
                    {
                        if (3 * teren.Razmak + teren.SirinaOlovke >= y)
                        {
                            pomerise_Y(pomeraj);
                            return true;
                        }
                    }
                    else if (x >= 220 && x <= 240 && y == 240 || x >= 170 && x <= 190 && y == 240)
                    {
                        if (15 * teren.Razmak + teren.SirinaOlovke >= y)
                        {
                            pomerise_Y(pomeraj);
                            return true;
                        }
                    }
                    else if (x >= 250 && x <= 330 && y == 390)
                    {
                        if (21 * teren.Razmak + teren.SirinaOlovke >= y)
                        {
                            pomerise_Y(pomeraj);
                            return true;
                        }
                    }
                    else
                    {
                        if (33 * teren.Razmak + teren.SirinaOlovke >= y)
                        {
                            pomerise_Y(pomeraj);
                            return true;
                        }
                    }
                }
            }
            return false;
        }
    }
}
