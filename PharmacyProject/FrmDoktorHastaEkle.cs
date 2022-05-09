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
    public partial class FrmDoktorHastaEkle : Form
    {
        public FrmDoktorHastaEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.HASTA (TC,AD_SOYAD,KURUM_AD,HASTA_TURU,CEP_NO) values (@p1,@p2,@p3,@p4,@p5)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", TxtTc.Text);
            komut.Parameters.AddWithValue("@p2", TxtAdSoyad.Text);
            komut.Parameters.AddWithValue("@p3", TxtKurumAd.Text);
            komut.Parameters.AddWithValue("@p4", TxtHastTuru.Text);
            komut.Parameters.AddWithValue("@p5", TxtTel.Text);

            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
            }
          

        }

        private void FrmDoktorHastaEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmDoktorMain frm = new FrmDoktorMain();
            this.Hide();
            frm.Show();
        }
    }
}
