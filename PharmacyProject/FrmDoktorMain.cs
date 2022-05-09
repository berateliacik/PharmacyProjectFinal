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
    public partial class FrmDoktorMain : Form
    {
        public FrmDoktorMain()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        DataSet dataSet = new DataSet();
        


        private void button2_Click(object sender, EventArgs e)
        {

            FrmIlacYazDoktor frmIlacYaz = new FrmIlacYazDoktor();
            frmIlacYaz.tc = LblTc.Text;
            frmIlacYaz.hastaAdSoyad = LblAdSoyad.Text;
            frmIlacYaz.ShowDialog();

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmIlacYazDoktor frmIlacYaz = new FrmIlacYazDoktor();
            frmIlacYaz.tc = LblTc.Text;
            frmIlacYaz.hastaAdSoyad = LblAdSoyad.Text;
            frmIlacYaz.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From HASTA Where TC Like '%" + textBox1.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sql.baglanti().Close();
        }
       
        public void Hasta_Listele()
        {
            SqlDataAdapter DT = new SqlDataAdapter("select * from HASTA", sql.baglanti());
            DataTable tablo = new DataTable();
            DT.Fill(tablo);
            dataGridView1.DataSource = tablo;
            sql.baglanti().Close();
        }
        private void Btn_Ekle_Click(object sender, EventArgs e)
        {
            FrmDoktorHastaEkle frmHastaEkle = new FrmDoktorHastaEkle();
            this.Hide();
            frmHastaEkle.ShowDialog();
           
            
        }

        private void Btn_Güncelle_Click(object sender, EventArgs e)
        {
            FrmDoktorHastaGuncelle frmHastaGuncelle = new FrmDoktorHastaGuncelle();
            frmHastaGuncelle.AdSoyad = LblAdSoyad.Text;
            frmHastaGuncelle.Tc = LblTc.Text;
            frmHastaGuncelle.KurumAd = LblKurumAd.Text;
            frmHastaGuncelle.HastaTuru = LblHastaTuru.Text;
            frmHastaGuncelle.Tel = LblHastaTel.Text;
            this.Hide();
            frmHastaGuncelle.ShowDialog();
            
          
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewRow drow in dataGridView1.SelectedRows)  //Seçili Satırları Silme
            //{
            //    int numara = Convert.ToInt32(drow.Cells[0].Value);

            //    SqlCommand komut = new SqlCommand("Delete From HASTA Where TC=@p1", sql.baglanti());
            //    komut.Parameters.AddWithValue("@p1", dataGridView1.CurrentRow.Cells["TC"].Value.ToString());
            //    komut.ExecuteNonQuery();
            //    sql.baglanti().Close();

            //}
            SqlCommand komut = new SqlCommand("DELETE from HASTA where TC=@TC", sql.baglanti());
            komut.Parameters.AddWithValue("@TC", dataGridView1.CurrentRow.Cells[0].Value);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();          
            MessageBox.Show("Kayıt Silindi");
            Hasta_Listele();

        }

        private void Btn_Listele_Click(object sender, EventArgs e)
        {
            //dataSet.Tables["HASTA"].Clear();
            Hasta_Listele();
        }

        private void FrmDoktorMain_Load_1(object sender, EventArgs e)
        {
            Hasta_Listele();
            dataGridView1.Columns[0].HeaderText = "TC Numarası";
            dataGridView1.Columns[1].HeaderText = "Adı Soyadı";
            dataGridView1.Columns[2].HeaderText = "Kurum Adı";
            dataGridView1.Columns[3].HeaderText = "Hasta Türü";
            dataGridView1.Columns[4].HeaderText = "Telefon";
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            LblTc.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            LblAdSoyad.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            LblKurumAd.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            LblHastaTuru.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            LblHastaTel.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmAnaGiris frm = new FrmAnaGiris();
            this.Hide();
            frm.Show();
        }
    }
}


