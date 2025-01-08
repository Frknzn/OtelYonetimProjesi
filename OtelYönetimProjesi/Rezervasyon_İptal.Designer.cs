namespace OtelYönetimProjesi
{
    partial class Rezervasyon_İptal
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
            this.RezervasyonListelbl = new System.Windows.Forms.Label();
            this.RezervasyonListeGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Rezervasyonİptalbtn = new System.Windows.Forms.Button();
            this.RezevasyonListelebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonListeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // RezervasyonListelbl
            // 
            this.RezervasyonListelbl.AutoSize = true;
            this.RezervasyonListelbl.Location = new System.Drawing.Point(295, 97);
            this.RezervasyonListelbl.Name = "RezervasyonListelbl";
            this.RezervasyonListelbl.Size = new System.Drawing.Size(183, 28);
            this.RezervasyonListelbl.TabIndex = 0;
            this.RezervasyonListelbl.Text = "Rezervasyon Listesi";
            this.RezervasyonListelbl.Click += new System.EventHandler(this.RezervasyonListelbl_Click);
            // 
            // RezervasyonListeGridView
            // 
            this.RezervasyonListeGridView.AllowUserToAddRows = false;
            this.RezervasyonListeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RezervasyonListeGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.RezervasyonListeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RezervasyonListeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RezervasyonListeGridView.Location = new System.Drawing.Point(300, 128);
            this.RezervasyonListeGridView.Name = "RezervasyonListeGridView";
            this.RezervasyonListeGridView.RowHeadersVisible = false;
            this.RezervasyonListeGridView.RowHeadersWidth = 51;
            this.RezervasyonListeGridView.RowTemplate.Height = 24;
            this.RezervasyonListeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RezervasyonListeGridView.Size = new System.Drawing.Size(742, 390);
            this.RezervasyonListeGridView.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(484, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "(İptal etmek istediğiniz rezervasyonu seçin)";
            // 
            // Rezervasyonİptalbtn
            // 
            this.Rezervasyonİptalbtn.BackColor = System.Drawing.Color.Lavender;
            this.Rezervasyonİptalbtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Rezervasyonİptalbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Rezervasyonİptalbtn.Location = new System.Drawing.Point(86, 197);
            this.Rezervasyonİptalbtn.Name = "Rezervasyonİptalbtn";
            this.Rezervasyonİptalbtn.Size = new System.Drawing.Size(208, 63);
            this.Rezervasyonİptalbtn.TabIndex = 3;
            this.Rezervasyonİptalbtn.Text = "İptal Et";
            this.Rezervasyonİptalbtn.UseVisualStyleBackColor = false;
            this.Rezervasyonİptalbtn.Click += new System.EventHandler(this.Rezervasyonİptalbtn_Click);
            // 
            // RezevasyonListelebtn
            // 
            this.RezevasyonListelebtn.BackColor = System.Drawing.Color.Lavender;
            this.RezevasyonListelebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RezevasyonListelebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezevasyonListelebtn.Location = new System.Drawing.Point(86, 128);
            this.RezevasyonListelebtn.Name = "RezevasyonListelebtn";
            this.RezevasyonListelebtn.Size = new System.Drawing.Size(208, 63);
            this.RezevasyonListelebtn.TabIndex = 4;
            this.RezevasyonListelebtn.Text = "Listele";
            this.RezevasyonListelebtn.UseVisualStyleBackColor = false;
            this.RezevasyonListelebtn.Click += new System.EventHandler(this.RezevasyonListelebtn_Click);
            // 
            // Rezervasyon_İptal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.RezevasyonListelebtn);
            this.Controls.Add(this.Rezervasyonİptalbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RezervasyonListeGridView);
            this.Controls.Add(this.RezervasyonListelbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rezervasyon_İptal";
            this.Size = new System.Drawing.Size(1182, 751);
            ((System.ComponentModel.ISupportInitialize)(this.RezervasyonListeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RezervasyonListelbl;
        private System.Windows.Forms.DataGridView RezervasyonListeGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Rezervasyonİptalbtn;
        private System.Windows.Forms.Button RezevasyonListelebtn;
    }
}
