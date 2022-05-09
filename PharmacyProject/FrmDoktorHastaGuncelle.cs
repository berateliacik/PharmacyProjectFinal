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
    public partial class FrmDoktorHastaGuncelle : Form
    {
        public FrmDoktorHastaGuncelle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        public string AdSoyad, Tc, KurumAd, HastaTuru, Tel;

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorMain frm = new FrmDoktorMain();
            this.Hide();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand komut = new SqlCommand("Update HASTA set AD_SOYAD=@p1, KURUM_AD=@p2, HASTA_TURU=@p3, CEP_NO=@p4 ", sql.baglanti());
            SqlCommand komut = new SqlCommand("Update HASTA set AD_SOYAD=@p1, KURUM_AD=@p2, HASTA_TURU=@p3, CEP_NO=@p4 Where TC=@p5", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p2", TxtKurumAd.Text);
            komut.Parameters.AddWithValue("@p3", TxtHastTuru.Text);
            komut.Parameters.AddWithValue("@p4", TxtTel.Text);
            komut.Parameters.AddWithValue("@p5", TxtTc.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Hasta Başarıyla Güncellendi");
            
            
            FrmDoktorMain frmDoktorMain = new FrmDoktorMain();
            
            frmDoktorMain.Show();
            this.Hide();
            
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }

        }

        private void FrmDoktorHastaGuncelle_Load(object sender, EventArgs e)
        {
            TxtAdSoyad.Text = AdSoyad;
            TxtTc.Text = Tc;
            TxtTc.Enabled = true;
            TxtKurumAd.Text = KurumAd;
            TxtHastTuru.Text = HastaTuru;
            TxtTel.Text = Tel;
        }
       
    }
}
