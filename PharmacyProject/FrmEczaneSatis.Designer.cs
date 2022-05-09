
namespace PharmacyProject
{
    partial class FrmEczaneSatis
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
            this.dgvSatis = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.btnSalesEdit = new System.Windows.Forms.Button();
            this.txtSearchSales = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSatis
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(239)))), ((int)(((byte)(249)))));
            this.dgvSatis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSatis.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSatis.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(25)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSatis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvSatis.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSatis.EnableHeadersVisualStyles = false;
            this.dgvSatis.Location = new System.Drawing.Point(40, 174);
            this.dgvSatis.Name = "dgvSatis";
            this.dgvSatis.RowHeadersWidth = 51;
            this.dgvSatis.RowTemplate.Height = 24;
            this.dgvSatis.Size = new System.Drawing.Size(1042, 423);
            this.dgvSatis.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.label4.Font = new System.Drawing.Font("Montserrat Black", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(488, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 51);
            this.label4.TabIndex = 10;
            this.label4.Text = "SATIŞ";
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesSave.FlatAppearance.BorderSize = 0;
            this.btnSalesSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesSave.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesSave.ForeColor = System.Drawing.Color.White;
            this.btnSalesSave.Location = new System.Drawing.Point(40, 625);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(124, 50);
            this.btnSalesSave.TabIndex = 11;
            this.btnSalesSave.Text = "KAYDET";
            this.btnSalesSave.UseVisualStyleBackColor = false;
            // 
            // btnSalesEdit
            // 
            this.btnSalesEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(140)))), ((int)(((byte)(50)))));
            this.btnSalesEdit.FlatAppearance.BorderSize = 0;
            this.btnSalesEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesEdit.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesEdit.ForeColor = System.Drawing.Color.White;
            this.btnSalesEdit.Location = new System.Drawing.Point(200, 625);
            this.btnSalesEdit.Name = "btnSalesEdit";
            this.btnSalesEdit.Size = new System.Drawing.Size(124, 50);
            this.btnSalesEdit.TabIndex = 13;
            this.btnSalesEdit.Text = "DÜZENLE";
            this.btnSalesEdit.UseVisualStyleBackColor = false;
            // 
            // txtSearchSales
            // 
            this.txtSearchSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSearchSales.Location = new System.Drawing.Point(182, 120);
            this.txtSearchSales.Name = "txtSearchSales";
            this.txtSearchSales.Size = new System.Drawing.Size(199, 28);
            this.txtSearchSales.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(40, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 24);
            this.label1.TabIndex = 15;
            this.label1.Text = "Satışlarda Ara:";
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.btnSalesCancel.FlatAppearance.BorderSize = 0;
            this.btnSalesCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalesCancel.Font = new System.Drawing.Font("Montserrat ExtraBold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSalesCancel.ForeColor = System.Drawing.Color.White;
            this.btnSalesCancel.Location = new System.Drawing.Point(958, 625);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(124, 50);
            this.btnSalesCancel.TabIndex = 16;
            this.btnSalesCancel.Text = "SİL";
            this.btnSalesCancel.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(17)))), ((int)(((byte)(60)))));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1125, 91);
            this.panel1.TabIndex = 17;
            // 
            // FrmEczaneSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1125, 728);
            this.Controls.Add(this.btnSalesCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchSales);
            this.Controls.Add(this.btnSalesEdit);
            this.Controls.Add(this.btnSalesSave);
            this.Controls.Add(this.dgvSatis);
            this.Controls.Add(this.panel1);
            this.Name = "FrmEczaneSatis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ECZANE | SATIŞ";
            this.Load += new System.EventHandler(this.frm4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSatis)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSatis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.Button btnSalesEdit;
        private System.Windows.Forms.TextBox txtSearchSales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalesCancel;
        private System.Windows.Forms.Panel panel1;
    }
}