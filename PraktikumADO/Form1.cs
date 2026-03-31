using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PraktikumADO
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;

        public Form1()
        {
            InitializeComponent();
        }

        private void Koneksi()
        {
            conn = new SqlConnection(
                @"Data Source=LAPTOP-MBD0B33T\SHENDY;Initial Catalog=DBAkademikADO;Integrated Security=True"
            );
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                Koneksi();
                conn.Open();
                MessageBox.Show("Koneksi ke database berhasil");
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error koneksi: " + ex.Message);
            }
        }

        private void btnHitungMhs_Click(object sender, EventArgs e)
        {
 