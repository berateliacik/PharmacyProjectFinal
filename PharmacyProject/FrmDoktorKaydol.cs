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
    public partial class FrmDoktorKaydol : Form
    {
        public FrmDoktorKaydol()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnDoktorLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.DOKTOR (AD_SOYAD,TESCİL_NO,DIPLOMA_NO,BRANS,TESIS,TEL,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtDoktorName.Text);
            komut.Parameters.AddWithValue("@p2", txtDoktorTescilNo.Text);
            komut.Parameters.AddWithValue("@p3", txtDiplomaNo.Text);
            komut.Parameters.AddWithValue("@p4", txtBrans.Text);
            komut.Parameters.AddWithValue("@p5", txtTesis.Text);
            komut.Parameters.AddWithValue("@p6", txtDoktorTel.Text);
            komut.Parameters.AddWithValue("@p7", txtDoktorPassword.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");

            FrmDoktorGiris Form1 = new FrmDoktorGiris();
            Form1.Show();
            this.Hide();
        }

        private void FrmDoktorKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}
