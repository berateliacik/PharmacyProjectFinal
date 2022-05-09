using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyProject
{
    public partial class FrmEczaneAna : Form
    {
        public FrmEczaneAna()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmEczaneSatis frm4 = new FrmEczaneSatis();
            frm4.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmEczaneRecete frm5 = new FrmEczaneRecete();
            frm5.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmEczaneFatura frm6 = new FrmEczaneFatura();
            frm6.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm7 frm7 = new frm7();
            frm7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FrmEczaneTakas frm8 = new FrmEczaneTakas();
            frm8.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmEczaneUrunler frm9 = new FrmEczaneUrunler();
            frm9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmEczaneHastalar frm10 = new FrmEczaneHastalar();
            frm10.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmEczaneDoktor frm11 = new FrmEczaneDoktor();
            frm11.Show();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FrmEczaneKontrol frm12 = new FrmEczaneKontrol();
            frm12.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //frm13 frm13 = new frm13();
            //frm13.Show();
            System.Diagnostics.Process.Start("https://medeczane.sgk.gov.tr/eczane/login.jsp"); 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FrmUrunBilgi frm13 = new FrmUrunBilgi();
            frm13.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            FrmAnaGiris frmgiris = new FrmAnaGiris();
            this.Hide();
            frmgiris.Show();
        }
    }
}
