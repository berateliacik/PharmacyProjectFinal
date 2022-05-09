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
    public partial class FrmEczaneDoktor : Form
    {
        public FrmEczaneDoktor()
        {
            InitializeComponent();
        }

        private void frm11_Load(object sender, EventArgs e)
        {
            yenile();  
        }
        sqlbaglantisi sql = new sqlbaglantisi();
        void yenile()
        {
            SqlDataAdapter DT = new SqlDataAdapter("select AD_SOYAD,TESCİL_NO,DIPLOMA_NO,BRANS,TESIS,TEL from DOKTOR", sql.baglanti());
            DataTable tablo = new DataTable();
            DT.Fill(tablo);
            dgvDoktor.DataSource = tablo;
            sql.baglanti().Close();
        }

        private void btnSalesEdit_Click(object sender, EventArgs e)
        {
            txtDoktorAra.Text = "";
            yenile();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From DOKTOR Where AD_SOYAD Like '%" + txtDoktorAra.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dgvDoktor.DataSource = dataTable;
            sql.baglanti().Close();
        }
    }
}
