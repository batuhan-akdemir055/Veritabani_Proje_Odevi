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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localHost; port=5432; Database=Cascade_C_Sharp; user ID=postgres; password=samet5560");
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 eskiForm = new Form2();
            this.Hide();
            eskiForm.Show();
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string sorgu = "select * from satilan_araclar where satilan_arac_id=@p1 ";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sorgu, baglanti);

            DataSet ds = new DataSet();
            da.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}
