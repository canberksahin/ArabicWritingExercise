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
    public partial class SozlukKelimeDuzeltme : Form
    {
        SozlukKelime cel;
        SqlConnection con = new SqlConnection("Data Source = (LocalDB)\\mssqllocaldb; Integrated Security = True; MultipleActiveResultSets=True");
        
        public SozlukKelimeDuzeltme(SozlukKelime cell)
        {
            con.Open();
            InitializeComponent();
            cel = cell;
            txtArapca.Text = cel.Arapca;
            txtTurkce.Text = cel.Turkce;

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            string arapca = txtArapca.Text.Trim();
            string turkce = txtTurkce.Text.Trim();
            var cmd = new SqlCommand("Use ArapcaSozluk;" + $"update Sozluk set Arapca = '{arapca}',Turkce= '{turkce}' where Arapca = '{cel.Arapca}' and Turkce = '{cel.Turkce}'",con);
            cmd.ExecuteNonQuery();
            Close();
            
            
        }
    }
}
