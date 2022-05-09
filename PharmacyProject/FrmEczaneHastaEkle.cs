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
    public partial class FrmEczaneHastaEkle : Form
    {
        public FrmEczaneHastaEkle()
        {
            InitializeComponent();
        }
        
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.HASTA (AD_SOYAD,KURUM_AD,TC,HASTA_TURU,CEP_NO) values (@p1,@p2,@p3,@p4,@p5)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", txtKurumadi.Text);
            komut.Parameters.AddWithValue("@p3", txtTc.Text);
            komut.Parameters.AddWithValue("@p4", txtHastaturu.Text);
            komut.Parameters.AddWithValue("@p5", txttelefon.Text);

            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");
            FrmEczaneHastalar frmhasta = new FrmEczaneHastalar();
           
            frmhasta.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEczaneHastalar frm10 = new FrmEczaneHastalar();
            frm10.Show();
            this.Hide();
        }
    }
}
