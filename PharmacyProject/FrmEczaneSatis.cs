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
    public partial class FrmEczaneSatis : Form
    {
        public FrmEczaneSatis()
        {
            InitializeComponent();
        }

        private void frm4_Load(object sender, EventArgs e)
        {
            SatisListele();
        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        public void SatisListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From SATIS";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvSatis.DataSource = dt;
            baglanti.Close();
        }
    }
}
