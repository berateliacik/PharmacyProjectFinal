
namespace PharmacyProject
{
    partial class FrmEczaneHastalar
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvHasta = new System.Windows.Forms.DataGridView();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.btnSalesEdit = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtHastaAra = new System.Windows.Forms.TextBox();
            this.btnAra = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasta)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1125, 91);
            this.panel1.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat ExtraBold", 22.2F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(448, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 52);
            this.label4.TabIndex = 10;
            this.label4.Text = "HASTALAR";
            // 
            // dgvHasta
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvHasta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHasta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHasta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHasta.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHasta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHasta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHasta.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHasta.EnableHeadersVisualStyles = false;
            this.dgvHasta.Location = new System.Drawing.Point(33, 178);
            this.dgvHasta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHasta.Name = "dgvHasta";
            this.dgvHasta.RowHeadersWidth = 51;
            this.dgvHasta.RowTemplate.Height = 24;
            this.dgvHasta.Size = new System.Drawing.Size(1067, 462);
            this.dgvHasta.TabIndex = 47;
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.btnSalesCancel.FlatAppearance.BorderSize = 0;
            this.btnSalesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesCancel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSalesCancel.ForeColor = System.Drawing.Color.White;
            this.btnSalesCancel.Location = new System.Drawing.Point(976, 661);
            this.btnSalesCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(124, 50);
            this.btnSalesCancel.TabIndex = 46;
            this.btnSalesCancel.Text = "SİL";
            this.btnSalesCancel.UseVisualStyleBackColor = false;
            this.btnSalesCancel.Click += new System.EventHandler(this.btnSalesCancel_Click);
            // 
            // btnSalesEdit
            // 
            this.btnSalesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesEdit.FlatAppearance.BorderSize = 0;
            this.btnSalesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesEdit.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSalesEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalesEdit.Location = new System.Drawing.Point(183, 661);
            this.btnSalesEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesEdit.Name = "btnSalesEdit";
            this.btnSalesEdit.Size = new System.Drawing.Size(124, 50);
            this.btnSalesEdit.TabIndex = 45;
            this.btnSalesEdit.Text = "DÜZELT";
            this.btnSalesEdit.UseVisualStyleBackColor = false;
            this.btnSalesEdit.Click += new System.EventHandler(this.btnSalesEdit_Click);
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesSave.FlatAppearance.BorderSize = 0;
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.btnSalesSave.ForeColor = System.Drawing.Color.White;
            this.btnSalesSave.Location = new System.Drawing.Point(37, 661);
            this.btnSalesSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(124, 50);
            this.btnSalesSave.TabIndex = 44;
            this.btnSalesSave.Text = "EKLE";
            this.btnSalesSave.UseVisualStyleBackColor = false;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(29, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Hasta Ad Soyad :";
            // 
            // txtHastaAra
            // 
            this.txtHastaAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHastaAra.Location = new System.Drawing.Point(196, 134);
            this.txtHastaAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtHastaAra.Name = "txtHastaAra";
            this.txtHastaAra.Size = new System.Drawing.Size(193, 28);
            this.txtHastaAra.TabIndex = 50;
            // 
            // btnAra
            // 
            this.btnAra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnAra.FlatAppearance.BorderSize = 0;
            this.btnAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAra.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAra.ForeColor = System.Drawing.Color.White;
            this.btnAra.Location = new System.Drawing.Point(396, 133);
            this.btnAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAra.Name = "btnAra";
            this.btnAra.Size = new System.Drawing.Size(92, 30);
            this.btnAra.TabIndex = 51;
            this.btnAra.Text = "ARA";
            this.btnAra.UseVisualStyleBackColor = false;
            this.btnAra.Click += new System.EventHandler(this.btnAra_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(331, 661);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 50);
            this.button1.TabIndex = 52;
            this.button1.Text = "YENİLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmEczaneHastalar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 729);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAra);
            this.Controls.Add(this.txtHastaAra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvHasta);
            this.Controls.Add(this.btnSalesCancel);
            this.Controls.Add(this.btnSalesEdit);
            this.Controls.Add(this.btnSalesSave);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmEczaneHastalar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE | HASTALAR";
            this.Load += new System.EventHandler(this.frm10_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHasta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvHasta;
        private System.Windows.Forms.Button btnSalesCancel;
        private System.Windows.Forms.Button btnSalesEdit;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtHastaAra;
        private System.Windows.Forms.Button btnAra;
        private System.Windows.Forms.Button button1;
    }
}