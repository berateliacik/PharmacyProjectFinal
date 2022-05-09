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
    public partial class FrmReceteUrunEkle : Form
    {
        public FrmReceteUrunEkle()
        {
            InitializeComponent();
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        private void btnReceteUrunEkleKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into dbo.RECETE_URUN (URUN_AD,MIKTAR,FIYAT,KUR_ODENEN,ILAC_FARKI,TUTAR,ECZANE_KARI,MALIYET,BITIM_TARIHI,DOZ) values (@p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8,@p9,@p10)", sql.baglanti());
            //komut.Parameters.AddWithValue("@p1", txtid.Text);
            komut.Parameters.AddWithValue("@p1", txturunad.Text);
            komut.Parameters.AddWithValue("@p2", txtmiktar.Text);
            komut.Parameters.AddWithValue("@p3", txtfiyat.Text);
            komut.Parameters.AddWithValue("@p4", txtkurodenen.Text);
            komut.Parameters.AddWithValue("@p5", txtilacfarki.Text);
            komut.Parameters.AddWithValue("@p6", txttutar.Text);
            komut.Parameters.AddWithValue("@p7", txteczanekari.Text);
            komut.Parameters.AddWithValue("@p8", txtmaliyet.Text);
            komut.Parameters.AddWithValue("@p9", txtbitimtarihi.Text);
            komut.Parameters.AddWithValue("@p10", txtkullanimdozu.Text);
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
