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
    public partial class Baslangic : Form
    {
        public Baslangic()
        {
            InitializeComponent();
            for (int i = 1; i < 6; i++)
            {
                nudHarfSayisi.Maximum = 5;
                nudHarfSayisi.Minimum = 3;
                nudHarfSayisi.Increment = 1;
            }
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            int buttonSayisi = (int)nudHarfSayisi.Value;
            Form1 frm = new Form1(buttonSayisi);
            frm.ShowDialog();
            
        }

        private void btnSozluk_Click(object sender, EventArgs e)
        {
            Sozluk frm = new Sozluk();
            frm.ShowDialog();
        }
    }
}
