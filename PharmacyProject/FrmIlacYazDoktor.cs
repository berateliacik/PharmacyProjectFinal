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
    public partial class FrmIlacYazDoktor : Form
    {
        public FrmIlacYazDoktor()
        {
            InitializeComponent();
        }

        private void FrmIlacYazDoktor_Load(object sender, EventArgs e)
        {
            //Tablo başlıkları düzenlenicek

            //dataGridView1.Columns[0].HeaderText = "İlaç Adı";
            //dataGridView1.Columns[1].HeaderText = "Miktar";
            //// dataGridView1.Columns[2].HeaderText = "Fiyat";
            //dataGridView1.Columns[2].HeaderText = "Son Kullanım Tarihi";
            //dataGridView1.Columns[3].HeaderText = "Kullanım Yaşı";
            Urun_Listele();
            LblAdSoyad.Text = hastaAdSoyad;
            LblTc.Text = tc;
            txtMIKTAR.Text = "1";

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("HASTA ADI SOYADI", 200);
            listView1.Columns.Add("HASTA TC", 200);
            listView1.Columns.Add("ÜRÜN", 200);
            listView1.Columns.Add("ÜRÜN ADEDİ", 200);
        }

        sqlbaglantisi sql = new sqlbaglantisi();
        DataSet dataSet = new DataSet();

        public string hastaAdSoyad, tc;


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUNVAN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            // txtMIKTAR.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            // txtFIYAT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMIADI.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            // txtKULLANIMYASI.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //{
            //    SqlCommand sqlCommand = new SqlCommand("Insert into URUN(UNVAN, MIKTAR, FIYAT, MIADI, KAMU_FIYATI, KULLANIM_YASI) values (@p1,@p2,@p3,@p4,@p5,@p6)", sql.baglanti());
            //    sqlCommand.Parameters.AddWithValue("@p1", dataGridView1.Rows[i].Cells["UNVAN"].Value.ToString());
            //    sqlCommand.Parameters.AddWithValue("@p2", dataGridView1.Rows[i].Cells["MIKTAR"].Value.ToString());
            //    sqlCommand.Parameters.AddWithValue("@p3", dataGridView1.Rows[i].Cells["FIYAT"].Value.ToString());
            //    sqlCommand.Parameters.AddWithValue("@p4", dataGridView1.Rows[i].Cells["MIADI"].Value.ToString());
            //    sqlCommand.Parameters.AddWithValue("@p5", dataGridView1.Rows[i].Cells["KAMU_FIYATI"].Value.ToString());
            //    sqlCommand.Parameters.AddWithValue("@p6", dataGridView1.Rows[i].Cells["KULLANIM_YASI"].Value.ToString());
            //    sqlCommand.ExecuteNonQuery();
            //    sql.baglanti().Close();
            //}

            //DataTable dataTable = new DataTable();
            //SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From RECETE Where HASTA_ID Like '%"+ tc + "%'", sql.baglanti());
            //sqlDataAdapter.Fill(dataTable);
            //dataGridView1.DataSource = dataTable;
            //sql.baglanti().Close();

            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{
            //    object[] rowData = new object[row.Cells.Count];
            //    for (int i = 0; i < rowData.Length; ++i)
            //    {
            //        rowData[i] = row.Cells[i].Value;
            //    }
            //    this.dataGridView2.Rows.Add(rowData);
            //}


            string unvan = txtUNVAN.Text;
            string miktar = txtMIKTAR.Text;
            string fiyat = txtFIYAT.Text;
            string miadi = txtMIADI.Text;
            string kullanimyasi = txtKULLANIMYASI.Text;

            string[] row = { hastaAdSoyad, tc, txtUNVAN.Text, txtMIKTAR.Text };
            var satir = new ListViewItem(row);
            listView1.Items.Add(satir);

            UrunSayısı();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //Search
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select *From URUN Where AD Like '%" + textBox1.Text + "%'", sql.baglanti());
            sqlDataAdapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
            sql.baglanti().Close();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUNVAN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            // txtMIKTAR.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            // txtFIYAT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMIADI.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            // txtKULLANIMYASI.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //   LblKullanimYasi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{

            //    object[] rowData = new object[row.Cells.Count];
            //    for (int i = 0; i < rowData.Length; ++i)
            //    {
            //        rowData[i] = row.Cells[i].Value;
            //}
            //    this.dataGridView2.Rows.Add(rowData);
            //}

        }

        private void Urun_Listele()
        {
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * From URUN", sql.baglanti());
            sqlDataAdapter.Fill(dataSet, "URUN");
            dataGridView1.DataSource = dataSet.Tables["URUN"];
            sql.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // İf kontrol eklenebilir seçiliyse sil değilse mboxla seçtir
            listView1.Items.Remove(listView1.SelectedItems[0]);
            UrunSayısı();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmDoktorRecete frmDoktorRecete = new FrmDoktorRecete();
            foreach (ListViewItem item in listView1.Items)
            {
                frmDoktorRecete.listView1.Items.Add((ListViewItem)item.Clone());
            }
            frmDoktorRecete.tc = tc;
            frmDoktorRecete.hastaAdSoyad = hastaAdSoyad;
            frmDoktorRecete.Show();


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtUNVAN.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            // txtMIKTAR.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            // txtFIYAT.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtMIADI.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            // txtKULLANIMYASI.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //   LblKullanimYasi.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

            //foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            //{

            //    object[] rowData = new object[row.Cells.Count];
            //    for (int i = 0; i < rowData.Length; ++i)
            //    {
            //        rowData[i] = row.Cells[i].Value;
            //}
            //    this.dataGridView2.Rows.Add(rowData);
            //}
        }

        private void UrunSayısı()
        {
            int urunSayısı = listView1.Items.Count;
            LblUrunSayısı.Text = urunSayısı.ToString();
        }
    }

}
