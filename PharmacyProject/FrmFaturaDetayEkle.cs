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
    public partial class FrmFaturaDetayEkle : Form
    {
        public FrmFaturaDetayEkle()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmEczaneFatura frm6 = new FrmEczaneFatura();
            frm6.Show();
            this.Hide();
        }
    }
}
