using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace Oyun
{
    public partial class Form1 : Form
    {
        WindowsMediaPlayer oyunSesi;
        WindowsMediaPlayer mermiSesi;
        WindowsMediaPlayer patlamaSesi;
        PictureBox[] yildizlar;
        PictureBox[] mermi;
        PictureBox[] dusmanlar;
        PictureBox[] dusmanMermisi;
        int arkaPlanHizi;
        int oyuncuHizi;
        int mermiHizi;
        int dusmanHizi;
        int dusmanMermiHizi;
        int puan;
        int level;
        int zorluk;
        bool durdur;
        bool oyunSonaErdi;
        Random rnd;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            durdur = false;
            oyunSonaErdi = false;
            puan = 0;
            level = 1;
            zorluk = 9;
            arkaPlanHizi = 4;
            dusmanHizi = 4;
            oyuncuHizi = 4;
            mermiHizi = 20;
            dusmanMermiHizi = 4;
            yildizlar = new PictureBox[13];
            mermi = new PictureBox[3];
            dusmanMermisi = new PictureBox[10];
            Image mermiler = Image.FromFile(@"asserts\\mermi2.png");
            rnd = new Random();

            Image dusman1 = Image.FromFile(@"asserts\\düşman1.png");
            Image dusman2 = Image.FromFile(@"asserts\\düşman 2.png");
            Image dusman3 = Image.FromFile(@"asserts\\düşman3.png");
            Image boss1 = Image.FromFile(@"asserts\\boss1.png");
            Image boss2 = Image.FromFile(@"asserts\\boss2.png");

            dusmanlar = new PictureBox[10];

            for (int i = 0; i < dusmanlar.Length; i++)
            {
                dusmanlar[i] = new PictureBox();
                dusmanlar[i].Size = new Size(40, 40);
                dusmanlar[i].SizeMode = PictureBoxSizeMode.Zoom;
                dusmanlar[i].BorderStyle = BorderStyle.None;
                dusmanlar[i].Visible = false;
                this.Controls.Add(dusmanlar[i]);
                dusmanlar[i].Location = new Point((i + 1) * 50, -50);
            }

            dusmanlar[0].Image = boss1;
            dusmanlar[1].Image = dusman2;
            dusmanlar[2].Image = dusman3;
            dusmanlar[3].Image = boss2;
            dusmanlar[4].Image = dusman1;
            dusmanlar[5].Image = dusman3;
            dusmanlar[6].Image = dusman2;
            dusmanlar[7].Image = boss2;
            dusmanlar[8].Image = dusman2;
            dusmanlar[9].Image = dusman3;

            for (int i = 0; i < mermi.Length; i++)
            {
                mermi[i] = new PictureBox();
                mermi[i].Size = new Size(12, 12);
                mermi[i].Image = mermiler;
                mermi[i].SizeMode = PictureBoxSizeMode.Zoom;
                mermi[i].BorderStyle = BorderStyle.None;
                this.Controls.Add(mermi[i]);
            }

            for (int i = 0; i < dusmanMermisi.Length; i++)
            {
                dusmanMermisi[i] = new PictureBox();
                dusmanMermisi[i].Size = new Size(2, 20);
                dusmanMermisi[i].Visible = false;
                dusmanMermisi[i].BackColor = Color.Red;
                int x = rnd.Next(0, 10);
                dusmanMermisi[i].Location = new Point(dusmanlar[x].Location.X, dusmanlar[x].Location.Y-20 );
                this.Controls.Add(dusmanMermisi[i]);

            }

            oyunSesi = new WindowsMediaPlayer();
            mermiSesi = new WindowsMediaPlayer();
            patlamaSesi = new WindowsMediaPlayer();

            oyunSesi.URL = "songs\\GameSong.mp3";
            mermiSesi.URL = "songs\\shoot.mp3";
            patlamaSesi.URL = "songs\\boom.mp3";

            oyunSesi.settings.setMode("loop", true);
            oyunSesi.settings.volume = 5;
            mermiSesi.settings.volume = 1;
            patlamaSesi.settings.volume = 6;
            oyunSesi.controls.play();


            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i] = new PictureBox();
                yildizlar[i].BorderStyle = BorderStyle.None;
                yildizlar[i].Location = new Point(rnd.Next(10, 500), rnd.Next(-10, 400));

                if (i % 2 == i) 
                {
                    yildizlar[i].Size = new Size(3, 2);
                    yildizlar[i].BackColor = Color.White;
                }
                else
                {
                    yildizlar[i].Size = new Size(4, 4);
                    yildizlar[i].BackColor = Color.DarkGray;
                }
                this.Controls.Add(yildizlar[i]);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < yildizlar.Length; i++)
            {
                yildizlar[i].Top += arkaPlanHizi;
                if (yildizlar[i].Top >= this.Height)
                {
                    yildizlar[i].Top = -yildizlar[i].Height;
                }
            }

            for (int i= yildizlar.Length / 2; i < yildizlar.Length; i++)
            {
                yildizlar[i].Top += arkaPlanHizi - 2;
                if (yildizlar[i].Top >= this.Height)
                {
                    yildizlar[i].Top = -yildizlar[i].Height;
                }
            }
        }

        private void solTimer2_Tick(object sender, EventArgs e)
        {
            if (oyuncu.Left > 10)
            {
                oyuncu.Left -= oyuncuHizi;
            }
        }

        private void sagTimer3_Tick(object sender, EventArgs e)
        {
            if (oyuncu.Right < 435)
            {
                oyuncu.Left += oyuncuHizi;
            }
        }

        private void asagiTimer4_Tick(object sender, EventArgs e)
        {
            if (oyuncu.Top < 320)
            {
                oyuncu.Top += oyuncuHizi;
            }
        }

        private void yukariTimer5_Tick(object sender, EventArgs e)
        {
            if (oyuncu.Top > 10) 
            {
                oyuncu.Top -= oyuncuHizi;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(!durdur)
            {
                if (e.KeyCode == Keys.Right)
                {
                    sagTimer3.Start();
                }
                if (e.KeyCode == Keys.Left)
                {
                    solTimer2.Start();
                }
                if (e.KeyCode == Keys.Down)
                {
                    asagiTimer4.Start();
                }
                if (e.KeyCode == Keys.Up)
                {
                    yukariTimer5.Start();
                }
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            sagTimer3.Stop();
            solTimer2.Stop();
            asagiTimer4.Stop();
            yukariTimer5.Stop();

            if(e.KeyCode==Keys.Space)
            {
                if(!oyunSonaErdi)
                {
                    if(durdur)
                    {
                        saatleriBaslat();
                        label1.Visible = false;
                        oyunSesi.controls.play(); ;
                        durdur = false;
                    }
                    else
                    {
                        
                        label1.Text = "DURDURULDU";
                        label1.Visible = true;
                        oyunSesi.controls.pause();
                        saatleriDurdur();
                        durdur = true;
                    }
                }
            }
            
        }

        private void mermiTimer2_Tick(object sender, EventArgs e)
        {
            mermiSesi.controls.play();
            for (int i = 0; i < mermi.Length; i++)
            {
                if (mermi[i].Top > 0)
                {
                    mermi[i].Visible = true;
                    mermi[i].Top -= mermiHizi;

                    patlama();

                }
                else
                {
                    mermi[i].Visible = false;
                    mermi[i].Location = new Point(oyuncu.Location.X + 15, oyuncu.Location.Y - i * 30);
                }
            }
        
        }

        private void dusmanTimer2_Tick(object sender, EventArgs e)
        {
            dusmanHareketi(dusmanlar, dusmanHizi);
        }

        private void dusmanHareketi(PictureBox[] array, int hız)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i].Visible = true;
                array[i].Top += hız;

                if(array[i].Top>this.Height)
                {
                    array[i].Location = new Point((i + 1) * 50, -200);
                }
            }
        }

        private void patlama()
        {
            for (int i = 0; i < dusmanlar.Length; i++)
            {
                if (mermi[0].Bounds.IntersectsWith(dusmanlar[i].Bounds) || mermi[1].Bounds.IntersectsWith(dusmanlar[i].Bounds) || mermi[2].Bounds.IntersectsWith(dusmanlar[i].Bounds))
                {
                    patlamaSesi.controls.play();
                    puan += 1;
                    puanLabel2.Text = (puan > 10) ? "Puan:   " + puan.ToString() : puan.ToString();



                    if (puan%30==0)
                    {
                        level += 1;
                        levelLabel2.Text = (level < 10) ? "Level:0" + level.ToString() : level.ToString();

                        if (dusmanHizi <= 10 && dusmanMermiHizi <= 10 && zorluk >= 0)
                        {
                            zorluk --;
                            dusmanHizi++;
                            dusmanMermiHizi++;
                        }
                        if(level==10)
                        {
                            oyunBitti("TEBRİKLER");
                        }
                    }


                    if (oyuncu.Bounds.IntersectsWith(dusmanlar[i].Bounds))
                    {
                        patlamaSesi.settings.volume = 30;
                        patlamaSesi.controls.play();
                        oyuncu.Visible = false;
                        oyunBitti("OYUN BİTTİ");
                    }
                    dusmanlar[i].Location = new Point((i + 1) * 50, -100);
                }
            }
        }

        private void oyunBitti(String str)
        {
            label1.Text = str;
            label1.Visible = true;
            baslatButton2.Visible = true;
            cikisButton1.Visible = true;
            oyunSesi.controls.stop();
            saatleriDurdur();
        }

        private void saatleriDurdur()
        {
            timer1.Stop();
            dusmanTimer2.Stop();
            mermiTimer2.Stop();
            dusmanMermiTimer2.Stop();
        }
        
        private void saatleriBaslat()
        {
            timer1.Start();
            dusmanTimer2.Start();
            mermiTimer2.Start();
            dusmanMermiTimer2.Start();
        }

        private void dusmanMermiTimer2_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < (dusmanMermisi.Length-zorluk); i++)
            {
                if (dusmanMermisi[i].Top < this.Height)
                {
                    dusmanMermisi[i].Visible = true;
                    dusmanMermisi[i].Top += dusmanMermiHizi;

                    dusmanMermiPatlaması();
                }
                else
                {
                    dusmanMermisi[i].Visible = false;
                    int x = rnd.Next(0, 10);
                    dusmanMermisi[i].Location = new Point(dusmanlar[x].Location.X + 20, dusmanlar[x].Location.Y + 30);              
                }
            }
            
        }

        private void dusmanMermiPatlaması()
        {
            for (int i = 0; i < dusmanMermisi.Length; i++)
            {
                if(dusmanMermisi[i].Bounds.IntersectsWith(oyuncu.Bounds))
                {
                    dusmanMermisi[i].Visible = false;
                    patlamaSesi.settings.volume = 30;
                    patlamaSesi.controls.play();
                    oyuncu.Visible = false;
                    oyunBitti("Oyun Bitti");
                }
            }
        }

        private void cikisButton1_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void baslatButton2_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            InitializeComponent();
            Form1_Load(e,e);
        }
    }
}
