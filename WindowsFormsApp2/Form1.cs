using System;
using Npgsql;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Veritabani_Proje; user ID=postgres; password=samet5560");

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 yeniform = new Form2();
            this.Hide();
            yeniform.Show();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            string sorgu = "select  * from satilik_arac";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into satilik_arac (satilik_arac_id,arac_id,stok_id,fiyat,ilan_tarih) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(Satilik_Arac_ID.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(AracID.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(Stok_ID.Text));
            komut1.Parameters.AddWithValue("@p4", int.Parse(Arac_Fiyat.Text));
            komut1.Parameters.AddWithValue("@p5", Ilan_Tarih.Text);

            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Arac basarili bir sekilde satilik araclar ilanina eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from satilik_arac where satilik_arac_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(Satilik_Arac_ID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Arac basarili bir sekilde satilik araclar ilaninindan silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {

            baglanti.Open();
            NpgsqlCommand komut3 = new NpgsqlCommand("update satilik_arac set fiyat=@p1 where satilik_arac_id=@p2 ", baglanti);
            komut3.Parameters.AddWithValue("@p1", int.Parse(Arac_Fiyat.Text));
            komut3.Parameters.AddWithValue("@p2", int.Parse(Satilik_Arac_ID.Text));
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Aracin fiyati basarili bir sekilde guncellendi");
        }

        private void Ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string t = AracID.Text;
            string sorgu = "select * from arac_bul(\'" + t + "\')";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
            baglanti.Close();
            MessageBox.Show("Sonuclariniz ekrana geldi");

        }
    }
}
