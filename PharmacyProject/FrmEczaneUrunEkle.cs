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
    public partial class FrmEczaneUrunEkle : Form
    {
        public FrmEczaneUrunEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void button3_Click(object sender, EventArgs e)
        {


            SqlCommand komut = new SqlCommand("insert into dbo.URUN (AD,MIKTAR,FIYAT,KULLANIM_YASI,MIADI,KAMU_FIYATI) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.baglanti());
            komut.Parameters.AddWithValue("@p1", txtilacadi.Text);
            komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p4", txtkullanimyasi.Text);
            komut.Parameters.AddWithValue("@p5", mskSonkullanma.Text);
            komut.Parameters.AddWithValue("@p6", txtKamuFiyati.Text);
            komut.ExecuteNonQuery();
            sql.baglanti().Close();
            MessageBox.Show("Kayıt başarılı bir şekilde gerçekleştirilmiştir.");
            
            FrmEczaneUrunler frm = new FrmEczaneUrunler();
            frm.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FrmEczaneUrunEkle_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEczaneUrunler frm9 = new FrmEczaneUrunler();
            frm9.Show();
            this.Hide();
        }
    }
}
