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
    public partial class FrmEczaneRecete : Form
    {
        public FrmEczaneRecete()
        {
            InitializeComponent();
            //GetList();
        }


        sqlbaglantisi sql = new sqlbaglantisi();
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder cmdb;


        sqlbaglantisi sql1 = new sqlbaglantisi();
        SqlDataAdapter da1;
        DataSet ds1;
        SqlCommandBuilder cmdb1;

        private void frm5_Load(object sender, EventArgs e)
        {
            HastaReceteListele();
            ReceteUrunListele();
            da = new SqlDataAdapter("Select * from HASTA_RECETE", sql.baglanti());
            cmdb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "HASTA_RECETE");
            dgvHastaRecete.DataSource = ds.Tables[0];
            sql.baglanti().Close();


            da1 = new SqlDataAdapter("Select * from RECETE_URUN", sql1.baglanti());
            cmdb1 = new SqlCommandBuilder(da1);
            ds1 = new DataSet();
            da1.Fill(ds1, "RECETE_URUN");
            dgvReceteUrun.DataSource = ds1.Tables[0];
            sql1.baglanti().Close();

        }

        private string baglantiCumlesi = @"Data Source=DESKTOP-CEI400U\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True";
        public void HastaReceteListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From HASTA_RECETE";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHastaRecete.DataSource = dt;
            baglanti.Close();
        }

        public void ReceteUrunListele()
        {
            SqlConnection baglanti = new SqlConnection(baglantiCumlesi);
            baglanti.Open();
            string komutCumlesi = "Select * From RECETE_URUN";
            SqlCommand komut = new SqlCommand(komutCumlesi, baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvReceteUrun.DataSource = dt;
            baglanti.Close();
        }

        private void btnSalesSave_Click(object sender, EventArgs e)
        {
            FrmHastaReceteEkle frmhastareceteekle = new FrmHastaReceteEkle();
            frmhastareceteekle.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtReceteHastaAra.Text = "";
            HastaReceteListele();
            ReceteUrunListele();
        }

        

        private void dgvReceteUrun_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReceteUrunEkle_Click(object sender, EventArgs e)
        {
            FrmReceteUrunEkle frmreceteurunekle = new FrmReceteUrunEkle();
            frmreceteurunekle.Show();
            this.Hide();
        }

        //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-CEI400U\\SQLEXPRESS;Initial Catalog=eczane;Integrated Security=True");
        //SqlCommandBuilder commanBuilder;
        //SqlDataAdapter adtr;
        //DataTable tbl = new DataTable();
        //DataTable GetList()
        //{
        //    adtr = new SqlDataAdapter("Select * from HASTA_RECETE", connection);
        //    adtr.Fill(tbl);
        //    dgvHastaRecete.DataSource = tbl;
        //    return tbl;
        //}

        private void btnSalesEdit_Click(object sender, EventArgs e)
        {
            //commanBuilder = new SqlCommandBuilder(adtr);
            //adtr.Update(tbl);
            ////GetList();
            //MessageBox.Show("Kayıt güncellendi");

            da.Update(ds, "HASTA_RECETE");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From HASTA_RECETE Where HASTA_AD_SOYAD Like '%" + txtReceteHastaAra.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dgvHastaRecete.DataSource = dataTable;
            sql.baglanti().Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //commanBuilder = new SqlCommandBuilder(adtr);
            //adtr.Update(tbl);
            ////GetList();
            //MessageBox.Show("Kayıt güncellendi");

            da1.Update(ds1, "RECETE_URUN");
            MessageBox.Show("Kayıt güncellendi");
        }

        private void btnSalesCancel_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE from HASTA_RECETE where ID=@ID", sql.baglanti());
            komut.Parameters.AddWithValue("@ID", dgvHastaRecete.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde silindi");
            HastaReceteListele();
        }

        private void btnReceteUrunSil_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("DELETE from RECETE_URUN where ID=@ID", sql.baglanti());
            komut.Parameters.AddWithValue("@ID", dgvReceteUrun.CurrentRow.Cells[0].Value.ToString());
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde silindi");
            ReceteUrunListele();
        }
    }
}
