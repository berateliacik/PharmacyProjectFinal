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
    public partial class frm7 : Form
    {
        public frm7()
        {
            InitializeComponent();
        }

        private void frm7_Load(object sender, EventArgs e)
        {
            DepoAlisListele();
            DepoAlisUrunListele();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";

        public void DepoAlisListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From DEPO_ALIS";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDepoAlis.DataSource = dt;
            baglanti.Close();
        }

        public void DepoAlisUrunListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From DEPO_ALIS_URUN";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvDepoAlisUrun.DataSource = dt;
            baglanti.Close();
        }
    }
}
