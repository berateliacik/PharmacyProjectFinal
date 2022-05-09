
namespace PharmacyProject
{
    partial class FrmHastaReceteEkle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHastaReceteEkle));
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txthastaadsoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtrecetetarih = new System.Windows.Forms.MaskedTextBox();
            this.txthastatc = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtkurumad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtislemno = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsirano = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txthastatelefon = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtucret = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtreceteurunid = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(197, 582);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 58);
            this.button3.TabIndex = 68;
            this.button3.Text = "KAYDET";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(26, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(437, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "HASTA REÇETE EKLE";
            // 
            // txthastaadsoyad
            // 
            this.txthastaadsoyad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastaadsoyad.Location = new System.Drawing.Point(197, 318);
            this.txthastaadsoyad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthastaadsoyad.Name = "txthastaadsoyad";
            this.txthastaadsoyad.Size = new System.Drawing.Size(193, 28);
            this.txthastaadsoyad.TabIndex = 94;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(31, 320);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 24);
            this.label6.TabIndex = 93;
            this.label6.Text = "Hasta Ad Soyad:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 91);
            this.panel1.TabIndex = 82;
            // 
            // txtrecetetarih
            // 
            this.txtrecetetarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtrecetetarih.Location = new System.Drawing.Point(197, 267);
            this.txtrecetetarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtrecetetarih.Mask = "00-00-0000";
            this.txtrecetetarih.Name = "txtrecetetarih";
            this.txtrecetetarih.Size = new System.Drawing.Size(193, 29);
            this.txtrecetetarih.TabIndex = 92;
            // 
            // txthastatc
            // 
            this.txthastatc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastatc.Location = new System.Drawing.Point(197, 365);
            this.txthastatc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthastatc.Name = "txthastatc";
            this.txthastatc.Size = new System.Drawing.Size(193, 28);
            this.txthastatc.TabIndex = 91;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(88, 367);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 90;
            this.label7.Text = "Hasta TC:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(76, 411);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 24);
            this.label5.TabIndex = 89;
            this.label5.Text = "Kurum Adı:";
            // 
            // txtkurumad
            // 
            this.txtkurumad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtkurumad.Location = new System.Drawing.Point(197, 409);
            this.txtkurumad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtkurumad.Name = "txtkurumad";
            this.txtkurumad.Size = new System.Drawing.Size(193, 28);
            this.txtkurumad.TabIndex = 88;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 24);
            this.label3.TabIndex = 87;
            this.label3.Text = "Reçete Tarihi:";
            // 
            // txtislemno
            // 
            this.txtislemno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtislemno.Location = new System.Drawing.Point(197, 218);
            this.txtislemno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtislemno.Name = "txtislemno";
            this.txtislemno.Size = new System.Drawing.Size(193, 28);
            this.txtislemno.TabIndex = 86;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(91, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 85;
            this.label2.Text = "İşlem No:";
            // 
            // txtsirano
            // 
            this.txtsirano.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtsirano.Location = new System.Drawing.Point(197, 167);
            this.txtsirano.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsirano.Name = "txtsirano";
            this.txtsirano.Size = new System.Drawing.Size(193, 28);
            this.txtsirano.TabIndex = 84;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(103, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 24);
            this.label1.TabIndex = 83;
            this.label1.Text = "Sıra No:";
            // 
            // txthastatelefon
            // 
            this.txthastatelefon.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txthastatelefon.Location = new System.Drawing.Point(197, 447);
            this.txthastatelefon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txthastatelefon.Name = "txthastatelefon";
            this.txthastatelefon.Size = new System.Drawing.Size(193, 28);
            this.txthastatelefon.TabIndex = 96;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(49, 449);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 24);
            this.label8.TabIndex = 95;
            this.label8.Text = "Hasta Telefon:";
            // 
            // txtucret
            // 
            this.txtucret.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtucret.Location = new System.Drawing.Point(197, 491);
            this.txtucret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtucret.Name = "txtucret";
            this.txtucret.Size = new System.Drawing.Size(193, 28);
            this.txtucret.TabIndex = 98;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(121, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 24);
            this.label9.TabIndex = 97;
            this.label9.Text = "Ücret:";
            // 
            // txtreceteurunid
            // 
            this.txtreceteurunid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtreceteurunid.Location = new System.Drawing.Point(197, 535);
            this.txtreceteurunid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtreceteurunid.Name = "txtreceteurunid";
            this.txtreceteurunid.Size = new System.Drawing.Size(193, 28);
            this.txtreceteurunid.TabIndex = 100;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(37, 537);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 24);
            this.label10.TabIndex = 99;
            this.label10.Text = "Reçete Ürün ID:";
            // 
            // txtid
            // 
            this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtid.Location = new System.Drawing.Point(197, 126);
            this.txtid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(193, 28);
            this.txtid.TabIndex = 102;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(148, 126);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 24);
            this.label11.TabIndex = 101;
            this.label11.Text = "ID:";
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(449, 97);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(45, 45);
            this.button2.TabIndex = 129;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmHastaReceteEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 663);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtreceteurunid);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtucret);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txthastatelefon);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txthastaadsoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtrecetetarih);
            this.Controls.Add(this.txthastatc);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtkurumad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtislemno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtsirano);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Name = "FrmHastaReceteEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE | HASTA REÇETE EKLE";
            this.Load += new System.EventHandler(this.FrmHastaReceteEkle_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthastaadsoyad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox txtrecetetarih;
        private System.Windows.Forms.TextBox txthastatc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtkurumad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtislemno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsirano;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txthastatelefon;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtucret;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtreceteurunid;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
    }
}