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
    public partial class FrmDoktorRecete : Form
    {
        public FrmDoktorRecete()
        {
            InitializeComponent();
        }
        public string hastaAdSoyad, tc;
        public string[] recete;

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Reçete Oluşturuldu.");
            RandomBarkod();
        }

        private void FrmDoktorRecete_Load(object sender, EventArgs e)
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("HASTA ADI SOYADI", 220);
            listView1.Columns.Add("HASTA TC", 160);
            listView1.Columns.Add("ÜRÜN", 160);
            listView1.Columns.Add("ÜRÜN ADEDİ", 150);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // İf kontrol eklenebilir seçiliyse sil değilse mboxla seçtir
            listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void RandomBarkod()
        {
            String karakterler = "0123456789ABCDEFGHIJKLMNOPRSTUVYZ";
            Random rnd = new Random();
            String barkod = "";
            for (int i = 0; i < 8; i++)
            {
                barkod += karakterler[rnd.Next(karakterler.Length)];
            }
            MessageBox.Show("BARKOD: " + barkod);
        }

    }
}
