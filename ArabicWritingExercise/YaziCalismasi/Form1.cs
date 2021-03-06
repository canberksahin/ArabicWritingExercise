﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ArabicWritingExercise.Properties;


namespace ArabicWritingExercise
{

    public partial class Form1 : Form
    {
        string[] yazilislar = new string[28];
        int butonSayisi;
        string[] alfebe = new string[29];
        Button[] butonlar;
        Label[] labellar;

        public Form1(int ButonSayisi)
        {
            butonSayisi = ButonSayisi;
            int j = 0;
            InitializeComponent();
            this.Width = butonSayisi * 160;
            #region Harfleri Array'e atamak
            //harfler[0] = new AlfabeFotoListesi();
            //harfler[0].AlfabePhoto = Resources.ELİF;
            //harfler[0].Tag = "ELİF";

            //harfler[1] = new AlfabeFotoListesi();
            //harfler[1].AlfabePhoto = Resources.BE;
            //harfler[1].Tag = "BE";

            //harfler[2] = new AlfabeFotoListesi();
            //harfler[2].AlfabePhoto = Resources.TE;
            //harfler[2].Tag = "TE";

            //harfler[3] = new AlfabeFotoListesi();
            //harfler[3].AlfabePhoto = Resources.PELTEK_TE;
            //harfler[3].Tag = "PELTEK_TE";

            //harfler[4] = new AlfabeFotoListesi();
            //harfler[4].AlfabePhoto = Resources.CE;
            //harfler[4].Tag = "CE";

            //harfler[5] = new AlfabeFotoListesi();
            //harfler[5].AlfabePhoto = Resources.Ha;
            //harfler[5].Tag = "HA";

            //harfler[6] = new AlfabeFotoListesi();
            //harfler[6].AlfabePhoto = Resources.KHA;
            //harfler[6].Tag = "KHA";

            //harfler[7] = new AlfabeFotoListesi();
            //harfler[7].AlfabePhoto = Resources.DE;
            //harfler[7].Tag = "DE";

            //harfler[8] = new AlfabeFotoListesi();
            //harfler[8].AlfabePhoto = Resources.PELTEK_ZE;
            //harfler[8].Tag = "PELTEK ZE";

            //harfler[9] = new AlfabeFotoListesi();
            //harfler[9].AlfabePhoto = Resources.RA;
            //harfler[9].Tag = "RA";

            //harfler[10] = new AlfabeFotoListesi();
            //harfler[10].AlfabePhoto = Resources.ZE;
            //harfler[10].Tag = "ZE";

            //harfler[11] = new AlfabeFotoListesi();
            //harfler[11].AlfabePhoto = Resources.SE;
            //harfler[11].Tag = "SE";

            //harfler[12] = new AlfabeFotoListesi();
            //harfler[12].AlfabePhoto = Resources.ŞE;
            //harfler[12].Tag = "ŞE";

            //harfler[13] = new AlfabeFotoListesi();
            //harfler[13].AlfabePhoto = Resources.SA;
            //harfler[13].Tag = "SA";

            //harfler[14] = new AlfabeFotoListesi();
            //harfler[14].AlfabePhoto = Resources.DA;
            //harfler[14].Tag = "DA";

            //harfler[15] = new AlfabeFotoListesi();
            //harfler[15].AlfabePhoto = Resources.TA;
            //harfler[15].Tag = "TA";

            //harfler[16] = new AlfabeFotoListesi();
            //harfler[16].AlfabePhoto = Resources.PELTEK_ZA;
            //harfler[16].Tag = "PELTEK ZA";

            //harfler[17] = new AlfabeFotoListesi();
            //harfler[17].AlfabePhoto = Resources.AYN;
            //harfler[17].Tag = "AYN";

            //harfler[18] = new AlfabeFotoListesi();
            //harfler[18].AlfabePhoto = Resources.GA;
            //harfler[18].Tag = "GA";

            //harfler[19] = new AlfabeFotoListesi();
            //harfler[19].AlfabePhoto = Resources.FE;
            //harfler[19].Tag = "FE";

            //harfler[20] = new AlfabeFotoListesi();
            //harfler[20].AlfabePhoto = Resources.KA;
            //harfler[20].Tag = "KA";

            //harfler[21] = new AlfabeFotoListesi();
            //harfler[21].AlfabePhoto = Resources.KE;
            //harfler[21].Tag = "KE";

            //harfler[22] = new AlfabeFotoListesi();
            //harfler[22].AlfabePhoto = Resources.LE;
            //harfler[22].Tag = "LE";

            //harfler[23] = new AlfabeFotoListesi();
            //harfler[23].AlfabePhoto = Resources.ME;
            //harfler[23].Tag = "ME";

            //harfler[24] = new AlfabeFotoListesi();
            //harfler[24].AlfabePhoto = Resources.NE;
            //harfler[24].Tag = "NE";

            //harfler[25] = new AlfabeFotoListesi();
            //harfler[25].AlfabePhoto = Resources.HE;
            //harfler[25].Tag = "HE";

            //harfler[26] = new AlfabeFotoListesi();
            //harfler[26].AlfabePhoto = Resources.VA;
            //harfler[26].Tag = "VA";

            //harfler[27] = new AlfabeFotoListesi();
            //harfler[27].AlfabePhoto = Resources.YE;
            //harfler[27].Tag = "YE";
            #endregion
            #region Alfabe
            for (int i = 0x0626; i <= 0x064A; i++)
            {
                if (i >= 0x063B && i <= 0x0640 || i == 0x0649 || i == 0x0629)
                {
                    continue;
                }
                alfebe[j] = ((char)i).ToString();
                j++;
            }
            #endregion
            #region Butonları oluştur
            butonlar = new Button[butonSayisi];
            labellar = new Label[butonSayisi];
            txtYazilis.Width = butonSayisi * 50;
            for (int i = 0; i < butonSayisi; i++)
            {
                butonlar[i] = new Button();
                butonlar[i].Location = new Point(i * 155, 0);
                butonlar[i].Size = new Size(150, 150);
                butonlar[i].Font = new Font(butonlar[i].Font.FontFamily, 50);
                Controls.Add(butonlar[i]);
                labellar[i] = new Label();
                labellar[i].Location = new Point(i * 155 + 60, 152);
                labellar[i].Size = new Size(50, 20);
                labellar[i].Font = new Font(labellar[i].Font.FontFamily, 10);
                labellar[i].Visible = false;
                Controls.Add(labellar[i]);

                butonlar[i].MouseClick += Form1_MouseClick1;


            }
            #endregion
            #region Harflerin Yazılışları
            yazilislar[0] = "ELİF";
            yazilislar[1] = "BE";
            yazilislar[2] = "TE";
            yazilislar[3] = "P.TE";
            yazilislar[4] = "CE";
            yazilislar[5] = "HA";
            yazilislar[6] = "KHA";
            yazilislar[7] = "DE";
            yazilislar[8] = "ZE";
            yazilislar[9] = "RA";
            yazilislar[10] = "ZE";
            yazilislar[11] = "SE";
            yazilislar[12] = "ŞE";
            yazilislar[13] = "SA";
            yazilislar[14] = "DA";
            yazilislar[15] = "TA";
            yazilislar[16] = "P.TA";
            yazilislar[17] = "AYN";
            yazilislar[18] = "GAYN";
            yazilislar[19] = "FE";
            yazilislar[20] = "KA";
            yazilislar[21] = "KE";
            yazilislar[22] = "LE";
            yazilislar[23] = "ME";
            yazilislar[24] = "NE";
            yazilislar[25] = "HE";
            yazilislar[26] = "VA";
            yazilislar[27] = "YE";
            #endregion



        }

        private void Form1_MouseClick1(object sender, MouseEventArgs e)
        {
            
            YazımDetay frm = new YazımDetay(((Button)sender).Text);
            frm.ShowDialog();
        }



        private void btnGetir_Click(object sender, EventArgs e)
        {
            int[] rastgeleler = new int[butonSayisi];
            txtYazilis.Text = "";
            Random rand = new Random();
            for (int i = 0; i < butonSayisi; i++)
            {
                rastgeleler[i] = rand.Next(1, 29);
                butonlar[i].Text = alfebe[rastgeleler[i]];
                txtYazilis.Text = string.Concat(butonlar[i].Text, txtYazilis.Text);
                labellar[i].Text = yazilislar[rastgeleler[i] - 1];
                toolTip1.SetToolTip(butonlar[i], yazilislar[rastgeleler[i] - 1]);



            }


            if (txtYazilis.Visible == true)
            {
                HarfleriGoster();

            }

        }




        private void btnAlfabe_Click(object sender, EventArgs e)
        {
            Alfabe frmAlfabe = new Alfabe();
            frmAlfabe.Show();
        }

        private void btnHarfleriGöster_Click(object sender, EventArgs e)
        {
            if (btnHarfleriGöster.Text == "Harfleri Göster")
            {
                for (int i = 0; i < butonSayisi; i++)
                {
                    labellar[i].Visible = true;
                }
                btnHarfleriGöster.Text = "Harfleri Gizle";
            }
            else
            {
                for (int i = 0; i < butonSayisi; i++)
                {
                    labellar[i].Visible = false;
                }
                btnHarfleriGöster.Text = "Harfleri Göster";
            }


        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSol_Click(object sender, EventArgs e)
        {
            SoluIleBirlesmeyenHarfler frmSol = new SoluIleBirlesmeyenHarfler();
            frmSol.Show();
        }

        private void btnYazilis_Click(object sender, EventArgs e)
        {
            HarfleriGoster();
        }

        private void HarfleriGoster()
        {
            txtYazilis.Visible = true;
            btnKapat.Visible = true;
            btnYazilis.Visible = false;



        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

            btnKapat.Visible = false;

            btnYazilis.Visible = true;

            txtYazilis.Visible = false;
        }
    }
}
