
namespace PharmacyProject
{
    partial class FrmEczaneUrunEkle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEczaneUrunEkle));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.mskSonkullanma = new System.Windows.Forms.MaskedTextBox();
            this.txtkullanimyasi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfiyat = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmiktar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtilacadi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKamuFiyati = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 91);
            this.panel1.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(107, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(250, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "ÜRÜN EKLE";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(164, 451);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 62);
            this.button3.TabIndex = 67;
            this.button3.Text = "KAYDET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // mskSonkullanma
            // 
            this.mskSonkullanma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mskSonkullanma.Location = new System.Drawing.Point(164, 400);
            this.mskSonkullanma.Margin = new System.Windows.Forms.Padding(4);
            this.mskSonkullanma.Mask = "00-00-0000";
            this.mskSonkullanma.Name = "mskSonkullanma";
            this.mskSonkullanma.Size = new System.Drawing.Size(193, 29);
            this.mskSonkullanma.TabIndex = 78;
            // 
            // txtkullanimyasi
            // 
            this.txtkullanimyasi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkullanimyasi.Location = new System.Drawing.Point(164, 353);
            this.txtkullanimyasi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkullanimyasi.Name = "txtkullanimyasi";
            this.txtkullanimyasi.Size = new System.Drawing.Size(193, 28);
            this.txtkullanimyasi.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(17, 357);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 24);
            this.label7.TabIndex = 76;
            this.label7.Text = "Kullanım Yaşı :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(93, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 24);
            this.label5.TabIndex = 75;
            this.label5.Text = "SKT :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtfiyat
            // 
            this.txtfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtfiyat.Location = new System.Drawing.Point(164, 255);
            this.txtfiyat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtfiyat.Name = "txtfiyat";
            this.txtfiyat.Size = new System.Drawing.Size(193, 28);
            this.txtfiyat.TabIndex = 74;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(93, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 24);
            this.label3.TabIndex = 73;
            this.label3.Text = "Fiyat :";
            // 
            // txtmiktar
            // 
            this.txtmiktar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtmiktar.Location = new System.Drawing.Point(164, 206);
            this.txtmiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtmiktar.Name = "txtmiktar";
            this.txtmiktar.Size = new System.Drawing.Size(193, 28);
            this.txtmiktar.TabIndex = 72;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(80, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 24);
            this.label2.TabIndex = 71;
            this.label2.Text = "Miktar :";
            // 
            // txtilacadi
            // 
            this.txtilacadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtilacadi.Location = new System.Drawing.Point(164, 155);
            this.txtilacadi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtilacadi.Name = "txtilacadi";
            this.txtilacadi.Size = new System.Drawing.Size(193, 28);
            this.txtilacadi.TabIndex = 70;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(73, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 69;
            this.label1.Text = "İlaç Adı :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(32, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "Kamu Fiyatı :";
            // 
            // txtKamuFiyati
            // 
            this.txtKamuFiyati.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKamuFiyati.Location = new System.Drawing.Point(164, 306);
            this.txtKamuFiyati.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKamuFiyati.Name = "txtKamuFiyati";
            this.txtKamuFiyati.Size = new System.Drawing.Size(193, 28);
            this.txtKamuFiyati.TabIndex = 81;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(391, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 82;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmEczaneUrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 582);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtKamuFiyati);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.mskSonkullanma);
            this.Controls.Add(this.txtkullanimyasi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtfiyat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmiktar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtilacadi);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmEczaneUrunEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE | ÜRÜN EKLE";
            this.Load += new System.EventHandler(this.FrmEczaneUrunEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.MaskedTextBox mskSonkullanma;
        private System.Windows.Forms.TextBox txtkullanimyasi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfiyat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmiktar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtilacadi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKamuFiyati;
        private System.Windows.Forms.Button button2;
    }
}