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
    public partial class Sozluk : Form
    {
        BindingList<SozlukKelime> Kelimeler;
        string dbName = "ArapcaSozluk";
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\mssqllocaldb; Integrated Security=True; MultipleActiveResultSets=True");
        int sayac = 0;
        public Sozluk()
        {
            con.Open();
            VeriTabaniYoksaOlustur();
            InitializeComponent();
            KelimeleriListele();
        }

        private void KelimeleriListele()
        {
            var cmd = new SqlCommand("select * from Sozluk order by Arapca", con);
            var dr = cmd.ExecuteReader();

            Kelimeler = new BindingList<SozlukKelime>();

            while (dr.Read())
            {
                Kelimeler.Add(new SozlukKelime { Arapca = (string)dr["Arapca"], Turkce = (string)dr["Turkce"] });
                sayac++;
            }
            dr.Close();
            dgvSozluk.DataSource = Kelimeler;
            lblKelimeSayisi.Text = sayac.ToString();
            sayac = 0;
        }

        private void VeriTabaniYoksaOlustur()
        {
            SqlCommand cmd = new SqlCommand($"Select DB_ID(N'{dbName}');",con);
            short? sonuc = cmd.ExecuteScalar() as short?;
            if (!sonuc.HasValue)
            {
                cmd = new SqlCommand($"CREATE database {dbName}", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand($"USE {dbName};"
                   + @"CREATE table Sozluk  
                   (
                       Id int primary key identity,
                        Arapca nvarchar(100) not null,
                        Turkce nvarchar(100) not null,
                       
                       )", con);
                cmd.ExecuteNonQuery();
            }
            else
            {
                cmd = new SqlCommand($"use {dbName};", con);
                cmd.ExecuteNonQuery();
            }

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string arapca = txtArapca.Text.Trim();
            string turkce = txtTurkce.Text.Trim();

            if (arapca !="" && turkce != "")
            {
                SqlCommand cmd = new SqlCommand($"insert into Sozluk(Arapca,Turkce) values('{arapca}','{turkce}')", con);
                cmd.ExecuteNonQuery();
            }
            txtArapca.Clear();
            txtTurkce.Clear();
            KelimeleriListele();
        }

        private void dgvSozluk_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvSozluk.SelectedRows.Count >0 && e.KeyCode==Keys.Delete)
            {
                SozlukKelime silinecek = (SozlukKelime)dgvSozluk.SelectedRows[0].DataBoundItem;
                string a =silinecek.Arapca;
                Kelimeler.Remove(silinecek);
                var cmd = new SqlCommand($"delete from Sozluk where Arapca ='{a}'", con);
                cmd.ExecuteNonQuery();
            }

                KelimeleriListele();
        }

        private void dgvSozluk_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SozlukKelime duzenlenecek = (SozlukKelime)dgvSozluk.SelectedRows[0].DataBoundItem;
            SozlukKelimeDuzeltme frm = new SozlukKelimeDuzeltme(duzenlenecek);
            frm.ShowDialog();
            KelimeleriListele();
        }
    }
}
