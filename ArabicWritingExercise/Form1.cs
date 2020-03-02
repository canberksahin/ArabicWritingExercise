using System;
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
        //public static string[] straImageLocations = Directory.GetFiles("aa", "*.png", SearchOption.TopDirectoryOnly);
        AlfabeFotoListesi[] harfler = new AlfabeFotoListesi[28];

        public Form1()
        {
            InitializeComponent();
            #region Harfleri Array'e atamak
            harfler[0] = new AlfabeFotoListesi();
            harfler[0].AlfabePhoto = Resources.ELİF;
            harfler[0].Tag = "ELİF";

            harfler[1] = new AlfabeFotoListesi();
            harfler[1].AlfabePhoto = Resources.BE;
            harfler[1].Tag = "BE";

            harfler[2] = new AlfabeFotoListesi();
            harfler[2].AlfabePhoto = Resources.TE;
            harfler[2].Tag = "TE";

            harfler[3] = new AlfabeFotoListesi();
            harfler[3].AlfabePhoto = Resources.PELTEK_TE;
            harfler[3].Tag = "PELTEK_TE";

            harfler[4] = new AlfabeFotoListesi();
            harfler[4].AlfabePhoto = Resources.CE;
            harfler[4].Tag = "CE";

            harfler[5] = new AlfabeFotoListesi();
            harfler[5].AlfabePhoto = Resources.Ha;
            harfler[5].Tag = "HA";

            harfler[6] = new AlfabeFotoListesi();
            harfler[6].AlfabePhoto = Resources.KHA;
            harfler[6].Tag = "KHA";

            harfler[7] = new AlfabeFotoListesi();
            harfler[7].AlfabePhoto = Resources.DE;
            harfler[7].Tag = "DE";

            harfler[8] = new AlfabeFotoListesi();
            harfler[8].AlfabePhoto = Resources.PELTEK_ZE;
            harfler[8].Tag = "PELTEK ZE";

            harfler[9] = new AlfabeFotoListesi();
            harfler[9].AlfabePhoto = Resources.RA;
            harfler[9].Tag = "RA";

            harfler[10] = new AlfabeFotoListesi();
            harfler[10].AlfabePhoto = Resources.ZE;
            harfler[10].Tag = "ZE";

            harfler[11] = new AlfabeFotoListesi();
            harfler[11].AlfabePhoto = Resources.SE;
            harfler[11].Tag = "SE";

            harfler[12] = new AlfabeFotoListesi();
            harfler[12].AlfabePhoto = Resources.ŞE;
            harfler[12].Tag = "ŞE";

            harfler[13] = new AlfabeFotoListesi();
            harfler[13].AlfabePhoto = Resources.SA;
            harfler[13].Tag = "SA";

            harfler[14] = new AlfabeFotoListesi();
            harfler[14].AlfabePhoto = Resources.DA;
            harfler[14].Tag = "DA";

            harfler[15] = new AlfabeFotoListesi();
            harfler[15].AlfabePhoto = Resources.TA;
            harfler[15].Tag = "TA";

            harfler[16] = new AlfabeFotoListesi();
            harfler[16].AlfabePhoto = Resources.PELTEK_ZA;
            harfler[16].Tag = "PELTEK ZA";

            harfler[17] = new AlfabeFotoListesi();
            harfler[17].AlfabePhoto = Resources.AYN;
            harfler[17].Tag = "AYN";

            harfler[18] = new AlfabeFotoListesi();
            harfler[18].AlfabePhoto = Resources.GA;
            harfler[18].Tag = "GA";

            harfler[19] = new AlfabeFotoListesi();
            harfler[19].AlfabePhoto = Resources.FE;
            harfler[19].Tag = "FE";

            harfler[20] = new AlfabeFotoListesi();
            harfler[20].AlfabePhoto = Resources.KA;
            harfler[20].Tag = "KA";

            harfler[21] = new AlfabeFotoListesi();
            harfler[21].AlfabePhoto = Resources.KE;
            harfler[21].Tag = "KE";

            harfler[22] = new AlfabeFotoListesi();
            harfler[22].AlfabePhoto = Resources.LE;
            harfler[22].Tag = "LE";

            harfler[23] = new AlfabeFotoListesi();
            harfler[23].AlfabePhoto = Resources.ME;
            harfler[23].Tag = "ME";

            harfler[24] = new AlfabeFotoListesi();
            harfler[24].AlfabePhoto = Resources.NE;
            harfler[24].Tag = "NE";

            harfler[25] = new AlfabeFotoListesi();
            harfler[25].AlfabePhoto = Resources.HE;
            harfler[25].Tag = "HE";

            harfler[26] = new AlfabeFotoListesi();
            harfler[26].AlfabePhoto = Resources.VA;
            harfler[26].Tag = "VA";

            harfler[27] = new AlfabeFotoListesi();
            harfler[27].AlfabePhoto = Resources.YE;
            harfler[27].Tag = "YE";
            #endregion

        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int sayi = rand.Next(1, 28);
            Random rand1 = new Random();
            int sayi1 = rand.Next(1, 28);
            Random rand2 = new Random();
            int sayi2 = rand.Next(1, 28);
            button1.BackgroundImage = harfler[sayi].AlfabePhoto;
            lblHarf1.Text = harfler[sayi].Tag;
            button2.BackgroundImage = harfler[sayi1].AlfabePhoto;
            lblHarf2.Text = harfler[sayi1].Tag;
            button3.BackgroundImage = harfler[sayi2].AlfabePhoto;
            lblHarf3.Text = harfler[sayi2].Tag;
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
            lblHarf1.Visible = lblHarf2.Visible = lblHarf3.Visible = true;
            btnHarfleriGöster.Text = "Harfleri Gizle";
            }
            else
            {
                lblHarf1.Visible = lblHarf2.Visible = lblHarf3.Visible = false;
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
    }
}
