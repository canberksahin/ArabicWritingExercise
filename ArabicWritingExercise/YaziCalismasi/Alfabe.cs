using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabicWritingExercise
{
    public partial class Alfabe : Form
    {
        string[] alfabe = new string[30];
        Button[] butonlar = new Button[30];
        public Alfabe()
        {
            InitializeComponent();
            int c = 0;
            for (int i = 0x0627; i <= 0x064A; i++)
            {
                if (i >= 0x063B && i <= 0x0640 || i == 0x0649 || i == 0x0629)
                {
                    continue;
                }
                alfabe[c] = ((char)i).ToString();
                c++;

            }

            int y = -50;
            int x = 0;

            for (int i = 0; i < 28; i++)
            {
                butonlar[i] = new Button();
                if (i % 6 == 0)
                {
                    y = y + 80;
                    x = 0;
                }

                butonlar[i].Location = new Point(x, y);
                x = x + 80;
                butonlar[i].Size = new Size(75, 75);
                butonlar[i].Font = new Font(butonlar[i].Font.FontFamily, 40);
                butonlar[i].Name = "button";
                butonlar[i].Text = alfabe[i];
                Controls.Add(butonlar[i]);


            }
            butonlar[0].Click += Alfabe_Click;
            butonlar[1].Click += Alfabe_Click1;
            butonlar[2].Click += Alfabe_Click2; 
            butonlar[3].Click += Alfabe_Click3;
            butonlar[4].Click += Alfabe_Click4;
            butonlar[5].Click += Alfabe_Click5;
            butonlar[6].Click += Alfabe_Click6;
            butonlar[7].Click += Alfabe_Click7;
            butonlar[8].Click += Alfabe_Click8;
            butonlar[9].Click += Alfabe_Click9;
            butonlar[10].Click += Alfabe_Click10;
            butonlar[11].Click += Alfabe_Click11;
            butonlar[12].Click += Alfabe_Click12;
            butonlar[13].Click += Alfabe_Click13;
            butonlar[14].Click += Alfabe_Click14;
            butonlar[15].Click += Alfabe_Click15;
            butonlar[16].Click += Alfabe_Click16;
            butonlar[17].Click += Alfabe_Click17;
            butonlar[18].Click += Alfabe_Click18;
            butonlar[19].Click += Alfabe_Click19;
            butonlar[20].Click += Alfabe_Click20;
            butonlar[21].Click += Alfabe_Click21;
            butonlar[22].Click += Alfabe_Click22;
            butonlar[23].Click += Alfabe_Click23;
            butonlar[24].Click += Alfabe_Click24;
            butonlar[25].Click += Alfabe_Click25;
            butonlar[26].Click += Alfabe_Click26;
            butonlar[27].Click += Alfabe_Click27;

        }

        private void Alfabe_Click2(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._3_taa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click1(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._2_baa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._1_alif;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click3(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._4_thaa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click4(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._5_jeem;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click5(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._6_haa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click6(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._7_khaa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click7(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._8_daal;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click8(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._9_zaal;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click9(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._10_raa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click10(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._11_zaa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click11(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._12_seen;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click12(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._13_sheen;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click13(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._14_saad;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click14(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._15_daad;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click15(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._16_taah;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click16(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._17_zhaa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click17(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._18_ain;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click18(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._19_ghain;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click19(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._20_faa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click20(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._21_qaaf;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click21(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._22_kaaf;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click22(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._23_laam;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click23(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._24_meem;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click24(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._25_noon;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click25(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._26_haah;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }

        private void Alfabe_Click26(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._27_waw;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
        private void Alfabe_Click27(object sender, EventArgs e)
        {
            Stream str = Properties.Resources._28_yaa;
            System.Media.SoundPlayer snd = new System.Media.SoundPlayer(str);
            snd.Play();
        }
    }

}
