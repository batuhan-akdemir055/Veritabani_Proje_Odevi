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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Veritabani_Proje; user ID=postgres; password=samet5560");
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 eskiForm = new Form1();
            this.Hide();
            eskiForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 yeniform = new Form3();
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

        private void button4_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut1 = new NpgsqlCommand("insert into sepet_arac (sepet_arac_id,sepet_id, satilik_arac_id) values (@p1,@p2,@p3)", baglanti);
            komut1.Parameters.AddWithValue("@p1", int.Parse(Sepet_Arac_ID.Text));
            komut1.Parameters.AddWithValue("@p2", int.Parse(Satilik_Arac_ID.Text));
            komut1.Parameters.AddWithValue("@p3", int.Parse(Sepet_ID.Text));
            komut1.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepete Ekleme Islemi Basari Ile Gerceklesti");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            NpgsqlCommand komut2 = new NpgsqlCommand("insert into satilan_araclar (satilan_arac_id,sepet_arac_id) values (@p1,@p2)", baglanti);
           
            //komut2.Parameters.AddWithValue("@p1", int.Parse(textBox1.Text));
            komut2.Parameters.AddWithValue("@p2", int.Parse(Sepet_Arac_ID.Text));
        
              MessageBox.Show(Sepet_Arac_ID.Text+" ID li aracin; Satin alma islemi basari ile gerceklesti");

        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            NpgsqlCommand komut2 = new NpgsqlCommand("delete from sepet_arac where sepet_arac_id=@p1", baglanti);
            komut2.Parameters.AddWithValue("@p1", int.Parse(Sepet_Arac_ID.Text));
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Sepet Silme Islemi Basari Ile Gerceklesti");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            
        }
    }
}
