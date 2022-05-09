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
    public partial class FrmEczaneUrunler : Form
    {
        public FrmEczaneUrunler()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;
        private void frm9_Load(object sender, EventArgs e)
        {
            UrunListele();
            da = new SqlDataAdapter("Select * from URUN", sql.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "URUN");
            dgvUrunler.DataSource = ds.Tables[0];
            sql.baglanti().Close();
        }
 
         void UrunListele()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT AD,MIKTAR,FIYAT,MIADI,KULLANIM_YASI,KAMU_FIYATI FROM dbo.URUN", sql.baglanti());
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvUrunler.DataSource = dt;
        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            FrmEczaneUrunEkle frmurunekle = new FrmEczaneUrunEkle();
            frmurunekle.Show();
            this.Hide();
        }

        private void btnSalesEdit_Click(object sender, EventArgs e)
        {
            da.Update(ds, "URUN");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtIlacAra.Text = "";
            UrunListele();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From URUN Where AD Like '%" + txtIlacAra.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dgvUrunler.DataSource = dataTable;
            sql.baglanti().Close();
        }

        private void btnSalesCancel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE from URUN where AD=@AD", sql.baglanti());
            komut.Parameters.AddWithValue("@AD", dgvUrunler.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde silindi");
            UrunListele();
        }
    }
}
