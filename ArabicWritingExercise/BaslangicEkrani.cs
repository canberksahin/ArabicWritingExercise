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
    public partial class BaslangicEkrani : Form
    {
        public BaslangicEkrani()
        {
            InitializeComponent();
            nudHarfSayisi.Minimum = 2;
            nudHarfSayisi.Maximum = 6;
            nudHarfSayisi.Increment = 1;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            int ButonSayisi =(int)nudHarfSayisi.Value;
            BaslangicEkrani frmBaslangic = new BaslangicEkrani() ;
            frmBaslangic.Close();
            Form1 frmBir = new Form1(ButonSayisi);
            frmBir.ShowDialog();
        }
    }
}
