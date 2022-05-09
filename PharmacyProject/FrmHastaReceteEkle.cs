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
    public partial class FrmHastaReceteEkle : Form
    {
        public FrmHastaReceteEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void FrmHastaReceteEkle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.HASTA_RECETE (ID,SIRA_NO,ISLEM_NO,RECETE_TARIH,HASTA_AD_SOYAD,HASTA_TC,KURUM_AD,HASTA_CEP,UCRET,RECETE_URUN_ID) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p2", txtsirano.Text);
            komut.Parameters.AddWithValue("@p3", txtislemno.Text);
            komut.Parameters.AddWithValue("@p4", txtrecetetarih.Text);
            komut.Parameters.AddWithValue("@p5", txthastaadsoyad.Text);
            komut.Parameters.AddWithValue("@p6", txthastatc.Text);
            komut.Parameters.AddWithValue("@p7", txtkurumad.Text);
            komut.Parameters.AddWithValue("@p8", txthastatelefon.Text);
            komut.Parameters.AddWithValue("@p9", txtucret.Text);
            komut.Parameters.AddWithValue("@p10", txtreceteurunid.Text);
            komut.ExecuteScalar();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");

            FrmEczaneRecete frm5 = new FrmEczaneRecete();
            frm5.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEczaneRecete frm5 = new FrmEczaneRecete();
            frm5.Show();
            this.Hide();
        }
    }
}
