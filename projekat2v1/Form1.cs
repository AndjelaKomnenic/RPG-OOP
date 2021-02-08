using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projekat2v1
{
    public partial class Form1 : Form
    {
        private Igrac igrac;
        private QuestCika quest;
        private List<Oruzje> listaOruzja = null;
        private Teren teren;
        private Topovi top;
        private List<TopMeci> listaMetaka = null;
        private List<kolekcionarskiPredmet> kp = null;
        private Vrata vrata;
        private Bezobraznici bz;
        private GlavniBezobraznik gbz;
        private List<PucanjeGlavniBz> pgbz = null;
        private bool mozedaseKlikne = false;
        //private int klikX, klikY;
        private bool lol = false;
        private int brojSakupljenih;
        private int zivot = 20;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            igrac = new Igrac();
            quest = new QuestCika();
            listaOruzja = new List<Oruzje>();
            teren = new Teren();
            top = new Topovi(170, 170, 240, 180);
            listaMetaka = new List<TopMeci>(3);
            kp = new List<kolekcionarskiPredmet>();
            kolekcionarskiPredmet k = null;
            k = new kolekcionarskiPredmet(30, 90);
            kolekcionarskiPredmet m = null;
            m = new kolekcionarskiPredmet(90, 90);
            kolekcionarskiPredmet nj = null;
            nj = new kolekcionarskiPredmet(470, 50);
            kolekcionarskiPredmet dz = null;
            dz = new kolekcionarskiPredmet(470, 60);
            kolekcionarskiPredmet znj = null;
            znj = new kolekcionarskiPredmet(470, 70);
            kp.Add(k);
            kp.Add(m);
            kp.Add(nj);
            kp.Add(dz);
            kp.Add(znj);
            vrata = new Vrata();
            bz = new Bezobraznici();
            gbz = new GlavniBezobraznik();
            pgbz = new List<PucanjeGlavniBz>();
            brojSakupljenih = 0;
            timer1.Start();
            timer2.Start();
            timer3.Start();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            teren.nacrtajSe(e.Graphics);
            foreach (kolekcionarskiPredmet k in kp)
            {
                k.nacrtajSe(e.Graphics);
            }
            quest.nacrtajSe(e.Graphics);
            foreach (Oruzje o in listaOruzja) 
            {
                o.nacrtajSe(e.Graphics);
            }
            igrac.nacrtajSe(e.Graphics);
            bz.nacrtajSe(e.Graphics);
            top.nacrtajSe(e.Graphics);
            foreach (TopMeci tp in listaMetaka)
            {
                tp.nacrtajSe(e.Graphics);
            }
            gbz.nacrtajSe(e.Graphics);
            foreach (PucanjeGlavniBz q in pgbz)
            {
                q.nacrtajSe(e.Graphics);
            }
            if (!lol)
                vrata.nacrtajSe(e.Graphics);

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (igrac.pomeriIgraca(e.KeyCode, igrac))
            {
                Refresh();
            }
            /*if (brojac == 0) 
            {
                if ((e.KeyCode == Keys.E) && mozedaseKlikne == true)
                {
                    MessageBox.Show("Bravo");
                    brojac++;
                    klikuoE = true;
                }
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = string.Format("{0}/5", brojSakupljenih);
            
            foreach (Oruzje o in listaOruzja.ToList()) 
            {
                //o.pomeriSe(klikX, klikY);
                /*o.pomeriSe(o.MouseX, o.MouseY);
                Refresh();*/
                if (o.stop == false)
                {
                    o.pomeriSe(o.MouseX, o.MouseY);
                    Refresh();
                }
                else 
                {
                    listaOruzja.Remove(o);
                    Refresh();
                }
                if (gbz.sudar(o))
                    zivot--;
            }

            if (zivot == 0) 
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop(); 
                label4.Show();
            }
                

            foreach (kolekcionarskiPredmet k in kp.ToList())
            {
                if (k.sudar(igrac.X, igrac.Y))
                {
                    kp.Remove(k);
                    Refresh();
                    brojSakupljenih++;
                }
            }

            if (mozedaseKlikne/*vrata.sudar(igrac.X, igrac.A, igrac.Y)*/)
            {
                lol = true;
                Refresh();
            }

            if (bz.sudar(igrac)) 
            {
                timer1.Stop();
                timer2.Stop();
                timer3.Stop();
                label3.Show();
            }
            
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TopMeci noviMetak = new TopMeci();
            listaMetaka.Add(noviMetak);
            foreach (TopMeci tp in listaMetaka.ToList())
            {
                tp.pomeriSe();
                Refresh();
                if (tp.X >= 300)
                {
                    listaMetaka.Remove(tp);
                    Refresh();
                }
                if (listaMetaka.Count() == 4)
                    listaMetaka.Clear();

               
                if (tp.sudar(igrac)) 
                {
                    timer1.Stop();
                    timer2.Stop();
                    timer3.Stop();
                    label3.Show();
                }
            }
            bz.pomerise_X();

            if (bz.X == 90 || bz.X == 20)
            {
                bz.okreni_x();
                Refresh();
            }

            gbz.pomerise_Y();

            if (gbz.Y == 320 || gbz.Y == 500)
            {
                gbz.okreni_y();
                Refresh();
            }

            PucanjeGlavniBz novo = new PucanjeGlavniBz(gbz);
            pgbz.Add(novo);
            foreach (PucanjeGlavniBz q in pgbz.ToList())
            {
                q.pomeriSe();
                Refresh();
                if (q.X > 250) 
                {
                    pgbz.Remove(q);
                    Refresh();
                }
                if (q.sudar(igrac))
                {
                    timer1.Stop();
                    timer2.Stop();
                    label3.Show();
                }
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Oruzje novoOruzje = new Oruzje(igrac);
                listaOruzja.Add(novoOruzje);
                novoOruzje.MouseX = e.X;
                novoOruzje.MouseY = e.Y;
                //klikX = e.X;
                //klikY = e.Y;
            }
            
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (quest.uOkolini(igrac))
            {
                timer3.Stop();
                MessageBox.Show("Mozes da prodjes kroz vrata");
                mozedaseKlikne = true;
            }
            else
                mozedaseKlikne = false;
        }
    }
}
