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
    public partial class FrmEczaneGiris : Form
    {
        public FrmEczaneGiris()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Frm2 frm2 = new Frm2();
            frm2.Show();
            //this.Hide();

        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From dbo.KULLANICI where AD_SOYAD=@p1 and SIFRE=@p2", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUserName.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmEczaneAna frm3 = new FrmEczaneAna();
                frm3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı. Tekrar Deneyiniz");
            }
        }

        private void FrmEczaneGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
