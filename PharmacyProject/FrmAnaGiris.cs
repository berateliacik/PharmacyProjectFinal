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
    public partial class FrmAnaGiris : Form
    {
        public FrmAnaGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEczaneGiris Form1 = new FrmEczaneGiris();
            this.Hide();
            Form1.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmDoktorGiris FrmDoktorGiris = new FrmDoktorGiris();
            this.Hide();
            FrmDoktorGiris.Show();
        }
    }
}
