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
    public partial class Frm2 : Form
    {
        public Frm2()
        {
            InitializeComponent();
        }

        private void FrmSignUp_Load(object sender, EventArgs e)
        {

        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.KULLANICI (AD_SOYAD,MAIL,ECZANE_AD,SEHIR,ILCE,ADRES,TEL,SIFRE) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUserName.Text);
            komut.Parameters.AddWithValue("@p2", txtmail.Text);
            komut.Parameters.AddWithValue("@p3", txtEczaneadi.Text);
            komut.Parameters.AddWithValue("@p4", txtsehir.Text);
            komut.Parameters.AddWithValue("@p5", txtilceadi.Text);
            komut.Parameters.AddWithValue("@p6", txtEczaneAdresi.Text);
            komut.Parameters.AddWithValue("@p7", txtTelefon.Text);
            komut.Parameters.AddWithValue("@p8", txtSifre.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");

            FrmEczaneGiris Form1 = new FrmEczaneGiris();
            Form1.Show();
            this.Hide();
        }
    }
}
