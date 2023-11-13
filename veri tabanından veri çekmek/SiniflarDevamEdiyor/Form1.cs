using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SiniflarDevamEdiyor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        string baglantiString= ("Data Source=.\\SQLEXPRESS;Initial Catalog = Pazarlama;Integrated Security = True");
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection(baglantiString);
            Baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection =Baglanti;
            komut.CommandText = "select * from tblPersonel";
            komut.CommandType=CommandType.Text;

            DataTable dtPersonel = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter();
            adptr.SelectCommand = komut;

            adptr.Fill(dtPersonel);
            dataGridView1.DataSource = dtPersonel;

            MessageBox.Show("Veriler Alındı,Bağlantı Kesilecek");
            Baglanti.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection Baglanti = new SqlConnection(baglantiString);
            Baglanti.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = Baglanti;
            komut.CommandText = "select * from tblPersonel";
            komut.CommandType = CommandType.Text;

            DataTable dtPersonel = new DataTable();
            SqlDataAdapter adptr = new SqlDataAdapter();
            adptr.SelectCommand = komut;

            adptr.Fill(dtPersonel);
            dataGridView1.DataSource = dtPersonel;

            DataRowCollection dtrw = dtPersonel.Rows;
            DataRow dr = dtrw[0];

            MessageBox.Show("Veriler Alındı,Bağlantı Kesilecek");
            Baglanti.Close();
        }
    }
}
