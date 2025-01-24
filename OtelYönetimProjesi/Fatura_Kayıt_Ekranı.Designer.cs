namespace OtelYönetimProjesi
{
    partial class Fatura_Kayıt_Ekranı
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.FaturaKayıtGridViev = new System.Windows.Forms.DataGridView();
            this.FaturKayıtlbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FaturaKayıtGridViev)).BeginInit();
            this.SuspendLayout();
            // 
            // FaturaKayıtGridViev
            // 
            this.FaturaKayıtGridViev.AllowUserToAddRows = false;
            this.FaturaKayıtGridViev.AllowUserToDeleteRows = false;
            this.FaturaKayıtGridViev.AllowUserToResizeColumns = false;
            this.FaturaKayıtGridViev.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.FaturaKayıtGridViev.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FaturaKayıtGridViev.BackgroundColor = System.Drawing.Color.Lavender;
            this.FaturaKayıtGridViev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FaturaKayıtGridViev.DefaultCellStyle = dataGridViewCellStyle2;
            this.FaturaKayıtGridViev.Location = new System.Drawing.Point(20, 78);
            this.FaturaKayıtGridViev.MultiSelect = false;
            this.FaturaKayıtGridViev.Name = "FaturaKayıtGridViev";
            this.FaturaKayıtGridViev.ReadOnly = true;
            this.FaturaKayıtGridViev.RowHeadersWidth = 51;
            this.FaturaKayıtGridViev.RowTemplate.Height = 24;
            this.FaturaKayıtGridViev.Size = new System.Drawing.Size(1141, 488);
            this.FaturaKayıtGridViev.TabIndex = 0;
            // 
            // FaturKayıtlbl
            // 
            this.FaturKayıtlbl.AutoSize = true;
            this.FaturKayıtlbl.Location = new System.Drawing.Point(102, 36);
            this.FaturKayıtlbl.Name = "FaturKayıtlbl";
            this.FaturKayıtlbl.Size = new System.Drawing.Size(154, 28);
            this.FaturKayıtlbl.TabIndex = 1;
            this.FaturKayıtlbl.Text = "Fatura Kayıtları";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Lavender;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(20, 572);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Yenile";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Fatura_Kayıt_Ekranı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FaturKayıtlbl);
            this.Controls.Add(this.FaturaKayıtGridViev);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Fatura_Kayıt_Ekranı";
            this.Size = new System.Drawing.Size(1182, 751);
            this.Load += new System.EventHandler(this.Fatura_Kayıt_Ekranı_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FaturaKayıtGridViev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FaturaKayıtGridViev;
        private System.Windows.Forms.Label FaturKayıtlbl;
        private System.Windows.Forms.Button button1;
    }
}
