
namespace PharmacyProject
{
    partial class FrmEczaneRecete
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvHastaRecete = new System.Windows.Forms.DataGridView();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.btnSalesEdit = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.dgvReceteUrun = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAra = new System.Windows.Forms.Button();
            this.txtReceteHastaAra = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceteUrunEkle = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnReceteUrunSil = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaRecete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(631, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "REÇETE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1405, 91);
            this.panel1.TabIndex = 18;
            // 
            // dgvHastaRecete
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvHastaRecete.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHastaRecete.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHastaRecete.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHastaRecete.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHastaRecete.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHastaRecete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHastaRecete.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHastaRecete.EnableHeadersVisualStyles = false;
            this.dgvHastaRecete.Location = new System.Drawing.Point(24, 177);
            this.dgvHastaRecete.Name = "dgvHastaRecete";
            this.dgvHastaRecete.RowHeadersWidth = 51;
            this.dgvHastaRecete.RowTemplate.Height = 24;
            this.dgvHastaRecete.Size = new System.Drawing.Size(1369, 266);
            this.dgvHastaRecete.TabIndex = 19;
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.btnSalesCancel.FlatAppearance.BorderSize = 0;
            this.btnSalesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesCancel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesCancel.ForeColor = System.Drawing.Color.White;
            this.btnSalesCancel.Location = new System.Drawing.Point(449, 747);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(124, 50);
            this.btnSalesCancel.TabIndex = 22;
            this.btnSalesCancel.Text = "SİL";
            this.btnSalesCancel.UseVisualStyleBackColor = false;
            this.btnSalesCancel.Click += new System.EventHandler(this.btnSalesCancel_Click);
            // 
            // btnSalesEdit
            // 
            this.btnSalesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesEdit.FlatAppearance.BorderSize = 0;
            this.btnSalesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesEdit.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalesEdit.Location = new System.Drawing.Point(24, 747);
            this.btnSalesEdit.Name = "btnSalesEdit";
            this.btnSalesEdit.Size = new System.Drawing.Size(124, 50);
            this.btnSalesEdit.TabIndex = 21;
            this.btnSalesEdit.Text = "DÜZENLE";
            this.btnSalesEdit.UseVisualStyleBackColor = false;
            this.btnSalesEdit.Click += new System.EventHandler(this.btnSalesEdit_Click);
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesSave.FlatAppearance.BorderSize = 0;
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesSave.ForeColor = System.Drawing.Color.White;
            this.btnSalesSave.Location = new System.Drawing.Point(171, 747);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(250, 50);
            this.btnSalesSave.TabIndex = 20;
            this.btnSalesSave.Text = "HASTA REÇETE EKLE";
            this.btnSalesSave.UseVisualStyleBackColor = false;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click);
            // 
            // dgvReceteUrun
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvReceteUrun.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReceteUrun.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReceteUrun.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvReceteUrun.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReceteUrun.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvReceteUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReceteUrun.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvReceteUrun.EnableHeadersVisualStyles = false;
            this.dgvReceteUrun.Location = new System.Drawing.Point(24, 461);
            this.dgvReceteUrun.Name = "dgvReceteUrun";
            this.dgvReceteUrun.RowHeadersWidth = 51;
            this.dgvReceteUrun.RowTemplate.Height = 24;
            this.dgvReceteUrun.Size = new System.Drawing.Size(1369, 266);
            this.dgvReceteUrun.TabIndex = 23;
            this.dgvReceteUrun.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvReceteUrun_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1269, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 24;
            this.button1.Text = "YENİLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(389, 129);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 30);
            this.btnAra.TabIndex = 56;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // txtReceteHastaAra
            // 
            this.txtReceteHastaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtReceteHastaAra.Location = new System.Drawing.Point(181, 130);
            this.txtReceteHastaAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtReceteHastaAra.Name = "txtReceteHastaAra";
            this.txtReceteHastaAra.Size = new System.Drawing.Size(193, 28);
            this.txtReceteHastaAra.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Hasta Ad Soyad:";
            // 
            // btnReceteUrunEkle
            // 
            this.btnReceteUrunEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnReceteUrunEkle.FlatAppearance.BorderSize = 0;
            this.btnReceteUrunEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteUrunEkle.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteUrunEkle.ForeColor = System.Drawing.Color.White;
            this.btnReceteUrunEkle.Location = new System.Drawing.Point(844, 747);
            this.btnReceteUrunEkle.Name = "btnReceteUrunEkle";
            this.btnReceteUrunEkle.Size = new System.Drawing.Size(250, 50);
            this.btnReceteUrunEkle.TabIndex = 57;
            this.btnReceteUrunEkle.Text = "REÇETE ÜRÜN EKLE";
            this.btnReceteUrunEkle.UseVisualStyleBackColor = false;
            this.btnReceteUrunEkle.Click += new System.EventHandler(this.btnReceteUrunEkle_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(1112, 747);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 50);
            this.button3.TabIndex = 58;
            this.button3.Text = "DÜZENLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnReceteUrunSil
            // 
            this.btnReceteUrunSil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.btnReceteUrunSil.FlatAppearance.BorderSize = 0;
            this.btnReceteUrunSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReceteUrunSil.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnReceteUrunSil.ForeColor = System.Drawing.Color.White;
            this.btnReceteUrunSil.Location = new System.Drawing.Point(1269, 747);
            this.btnReceteUrunSil.Name = "btnReceteUrunSil";
            this.btnReceteUrunSil.Size = new System.Drawing.Size(124, 50);
            this.btnReceteUrunSil.TabIndex = 59;
            this.btnReceteUrunSil.Text = "SİL";
            this.btnReceteUrunSil.UseVisualStyleBackColor = false;
            this.btnReceteUrunSil.Click += new System.EventHandler(this.btnReceteUrunSil_Click);
            // 
            // FrmEczaneRecete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 811);
            this.Controls.Add(this.btnReceteUrunSil);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnReceteUrunEkle);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtReceteHastaAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvReceteUrun);
            this.Controls.Add(this.btnSalesCancel);
            this.Controls.Add(this.btnSalesEdit);
            this.Controls.Add(this.btnSalesSave);
            this.Controls.Add(this.dgvHastaRecete);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEczaneRecete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "REÇETE";
            this.Load += new System.EventHandler(this.frm5_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHastaRecete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceteUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvHastaRecete;
        private System.Windows.Forms.Button btnSalesCancel;
        private System.Windows.Forms.Button btnSalesEdit;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.DataGridView dgvReceteUrun;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.TextBox txtReceteHastaAra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceteUrunEkle;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnReceteUrunSil;
    }
}