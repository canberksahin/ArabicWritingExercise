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
        AlfabeFotoListesi[] harfler = new AlfabeFotoListesi[28];
        //public static string[] straImageLocations = Directory.GetFiles("aa", "*.png", SearchOption.TopDirectoryOnly);
        //Image[] harfler = new Image[straImageLocations.Length];
        public Form1()
        {
            InitializeComponent();

            for (int i = 0; i < harfler.Length; i++)
            {
                harfler[i] = new AlfabeFotoListesi();
                harfler[i].AlfabePhoto = Resources.AYN;
                harfler[i].Tag = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;

                //public static Bitmap GetImageByName(string imageName)
                //{
                //    System.Reflection.Assembly asm = System.Reflection.Assembly.GetExecutingAssembly();
                //    string resourceName = asm.GetName().Name + ".Properties.Resources";
                //    var rm = new System.Resources.ResourceManager(resourceName, asm);
                //    return (Bitmap)rm.GetObject(imageName);

                //}
            }
        }

        private void btnGetir_Click(object sender, EventArgs e)
        {
            //Random rand = new Random();
            //int sayi = rand.Next(1, 28);
            //Random rand1 = new Random();
            //int sayi1 = rand.Next(1, 28);
            //Random rand2 = new Random();
            //int sayi2 = rand.Next(1, 28);
            //button1.BackgroundImage = harfler[sayi];
            //button2.BackgroundImage = harfler[sayi1];
            //button3.BackgroundImage = harfler[sayi2];
        }

        private void btnAlfabe_Click(object sender, EventArgs e)
        {
            Alfabe frmAlfabe = new Alfabe();
            frmAlfabe.Show();
        }

        private void btnHarfleriGöster_Click(object sender, EventArgs e)
        {
            lblHarf1.Text = button1.BackgroundImage.Tag.ToString();
            lblHarf1.Visible = lblHarf2.Visible = lblHarf3.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
