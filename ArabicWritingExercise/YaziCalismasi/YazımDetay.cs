using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabicWritingExercise
{
    public partial class YazımDetay : Form
    {
        string Yazım;
        int sonuc =0;
        public YazımDetay(string text)
        {
            InitializeComponent();
            Yazım = text;
            for (int i = 0x0626; i <= 0x064A; i++)
            {
                if (i >= 0x063B && i <= 0x0640 || i == 0x0649 || i == 0x0629)
                {
                    continue;
                }

                string a=((char)i).ToString();
                if (a == Yazım)
                {
                    break;
                }
                sonuc += 1;
            }

            switch (sonuc)
            {
                case 1:
                    pboYazımDetay.Image = Properties.Resources._1;
                    break;
                case 2:
                    pboYazımDetay.Image = Properties.Resources._2;
                    break;
                case 3:
                    pboYazımDetay.Image = Properties.Resources._3;
                    break;
                case 4:
                    pboYazımDetay.Image = Properties.Resources._4;
                    break;
                case 5:
                    pboYazımDetay.Image = Properties.Resources._5;
                    break;
                case 6:
                    pboYazımDetay.Image = Properties.Resources._6;
                    break;
                case 7:
                    pboYazımDetay.Image = Properties.Resources._7;
                    break;
                case 8:
                    pboYazımDetay.Image = Properties.Resources._8;
                    break;
                case 9:
                    pboYazımDetay.Image = Properties.Resources._9;
                    break;
                case 10:
                    pboYazımDetay.Image = Properties.Resources._10;
                    break;
                case 11:
                    pboYazımDetay.Image = Properties.Resources._11;
                    break;
                case 12:
                    pboYazımDetay.Image = Properties.Resources._12;
                    break;
                case 13:
                    pboYazımDetay.Image = Properties.Resources._13;
                    break;
                case 14:
                    pboYazımDetay.Image = Properties.Resources._14;
                    break;
                case 15:
                    pboYazımDetay.Image = Properties.Resources._15;
                    break;
                case 16:
                    pboYazımDetay.Image = Properties.Resources._16;
                    break;
                case 17:
                    pboYazımDetay.Image = Properties.Resources._17;
                    break;
                case 18:
                    pboYazımDetay.Image = Properties.Resources._18;
                    break;
                case 19:
                    pboYazımDetay.Image = Properties.Resources._19;
                    break;
                case 20:
                    pboYazımDetay.Image = Properties.Resources._20;
                    break;
                case 21:
                    pboYazımDetay.Image = Properties.Resources._21;
                    break;
                case 22:
                    pboYazımDetay.Image = Properties.Resources._22;
                    break;
                case 23:
                    pboYazımDetay.Image = Properties.Resources._23;
                    break;
                case 24:
                    pboYazımDetay.Image = Properties.Resources._24;
                    break;
                case 25:
                    pboYazımDetay.Image = Properties.Resources._25;
                    break;
                case 26:
                    pboYazımDetay.Image = Properties.Resources._26;
                    break;
                case 27:
                    pboYazımDetay.Image = Properties.Resources._27;
                    break;
                case 28:
                    pboYazımDetay.Image = Properties.Resources._28;
                    break;

                default:
                    break;
            }

        }
    }
}
