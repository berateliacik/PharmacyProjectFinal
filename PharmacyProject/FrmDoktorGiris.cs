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
    public partial class FrmDoktorGiris : Form
    {
        public FrmDoktorGiris()
        {
            InitializeComponent();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            FrmDoktorKaydol FrmDoktorKaydol = new FrmDoktorKaydol();
            FrmDoktorKaydol.Show();

        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * From dbo.DOKTOR where AD_SOYAD=@p1 and SIFRE=@p2", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtUserName.Text);
            komut.Parameters.AddWithValue("@p2", txtPassword.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {


                FrmDoktorMain frmgecis= new FrmDoktorMain();
                frmgecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı. Tekrar Deneyiniz");
            }
            
        }

        private void FrmDoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
