using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PharmacyProject
{
    public partial class FrmEczaneFatura : Form
    {
        public FrmEczaneFatura()
        {
            InitializeComponent();
        }

        private void frm6_Load(object sender, EventArgs e)
        {
            FaturaDetayListele();
            FaturaHastaListele();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        public void FaturaDetayListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From FATURA_DETAY";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFaturaDetay.DataSource = dt;
            baglanti.Close();
        }

        public void FaturaHastaListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From FATURA_HASTA";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvFaturaHasta.DataSource = dt;
            baglanti.Close();
        }

        private void btnFaturaDetayEkle_Click(object sender, EventArgs e)
        {
            FrmFaturaDetayEkle frmfaturadetayekle = new FrmFaturaDetayEkle();
            frmfaturadetayekle.Show();
            this.Hide();
        }
    }
}
