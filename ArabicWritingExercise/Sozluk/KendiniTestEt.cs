using ArabicWritingExercise.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArabicWritingExercise
{
    public partial class KendiniTestEt : Form
    {
        BindingList<SozlukKelime> Kelimeler;
        Random rand = new Random();
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\mssqllocaldb;database=ArapcaSozluk; Integrated Security=True; MultipleActiveResultSets=True");
        public KendiniTestEt()
        {
            con.Open();
            InitializeComponent();
            KelimeleriCek();
        }

        private void KelimeleriCek()
        {
            var cmd = new SqlCommand("select * from Sozluk order by Arapca", con);
            var dr = cmd.ExecuteReader();

            Kelimeler = new BindingList<SozlukKelime>();

            while (dr.Read())
            {
                Kelimeler.Add(new SozlukKelime { Arapca = (string)dr["Arapca"], Turkce = (string)dr["Turkce"] });
            }
            dr.Close();

            int rast = rand.Next(Kelimeler.Count);
            SozlukKelime secili1 = Kelimeler[rast];
            lblArapca.Text = secili1.Arapca;
            lblTurkce.Text = secili1.Turkce;
        }

        private void btnSiradaki_Click(object sender, EventArgs e)
        {
            int rast = rand.Next(Kelimeler.Count);
            SozlukKelime secili1 = Kelimeler[rast];
            lblArapca.Text = secili1.Arapca;
            lblTurkce.Text = secili1.Turkce;
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (btnGoster.Text=="GÖSTER")
            {
            lblTurkce.Visible = true;
            btnGoster.Text = "GİZLE";

            }
            else
            {
                lblTurkce.Visible = false;
                btnGoster.Text = "GÖSTER";
            }
        }
    }
}
