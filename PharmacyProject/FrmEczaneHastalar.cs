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
    public partial class FrmEczaneHastalar : Form
    {
        public FrmEczaneHastalar()
        {
            InitializeComponent();
        }

        private void frm10_Load(object sender, EventArgs e)
        {
            yenile();
            da = new SqlDataAdapter("Select * from HASTA", sql.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "HASTA");
            dgvHasta.DataSource = ds.Tables[0];

        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            FrmEczaneHastaEkle frmhastaekle = new FrmEczaneHastaEkle();
            frmhastaekle.Show();
            this.Hide();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        void yenile()
        {
            SqlDataAdapter DT = new SqlDataAdapter("select * from HASTA", sql.baglanti());
            DataTable tablo = new DataTable();
            DT.Fill(tablo);
            dgvHasta.DataSource = tablo;
            sql.baglanti().Close();
           
        }

        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;

        private void btnSalesEdit_Click(object sender, EventArgs e)
        {
            da.Update(ds, "HASTA");
            MessageBox.Show("Kayıt güncellendi");
        }


        private void btnSalesCancel_Click(object sender, EventArgs e)
        {
            
            
            SqlCommand komut = new SqlCommand("DELETE from HASTA where TC=@TC", sql.baglanti());
            komut.Parameters.AddWithValue("@TC", dgvHasta.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde silindi");
            yenile();

        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From HASTA Where AD_SOYAD Like '%" + txtHastaAra.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dgvHasta.DataSource = dataTable;
            sql.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtHastaAra.Text = "";
            yenile();
        }
    }
}
