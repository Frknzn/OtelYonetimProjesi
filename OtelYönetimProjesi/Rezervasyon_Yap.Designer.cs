namespace OtelYönetimProjesi
{
    partial class Rezervasyon_Yap
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
            this.GirisTarihlbl = new System.Windows.Forms.Label();
            this.CikisTarihlbl = new System.Windows.Forms.Label();
            this.GirisTarihiDateTime = new System.Windows.Forms.DateTimePicker();
            this.CikisTarihiDateTime = new System.Windows.Forms.DateTimePicker();
            this.MusteriListeTablo = new System.Windows.Forms.DataGridView();
            this.OdaListeTablo = new System.Windows.Forms.DataGridView();
            this.BosOdaListelebtn = new System.Windows.Forms.Button();
            this.MüsteriListelbl = new System.Windows.Forms.Label();
            this.OdaListelbl = new System.Windows.Forms.Label();
            this.RezervasyonOnaybtn = new System.Windows.Forms.Button();
            this.Ucrettxtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeTablo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeTablo)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisTarihlbl
            // 
            this.GirisTarihlbl.AutoSize = true;
            this.GirisTarihlbl.Location = new System.Drawing.Point(90, 59);
            this.GirisTarihlbl.Name = "GirisTarihlbl";
            this.GirisTarihlbl.Size = new System.Drawing.Size(113, 28);
            this.GirisTarihlbl.TabIndex = 0;
            this.GirisTarihlbl.Text = "Giriş Tarihi";
            // 
            // CikisTarihlbl
            // 
            this.CikisTarihlbl.AutoSize = true;
            this.CikisTarihlbl.Location = new System.Drawing.Point(90, 148);
            this.CikisTarihlbl.Name = "CikisTarihlbl";
            this.CikisTarihlbl.Size = new System.Drawing.Size(115, 28);
            this.CikisTarihlbl.TabIndex = 1;
            this.CikisTarihlbl.Text = "Çıkış Tarihi";
            // 
            // GirisTarihiDateTime
            // 
            this.GirisTarihiDateTime.Location = new System.Drawing.Point(95, 90);
            this.GirisTarihiDateTime.Name = "GirisTarihiDateTime";
            this.GirisTarihiDateTime.Size = new System.Drawing.Size(294, 34);
            this.GirisTarihiDateTime.TabIndex = 2;
            this.GirisTarihiDateTime.ValueChanged += new System.EventHandler(this.GirisTarihiDateTime_ValueChanged);
            // 
            // CikisTarihiDateTime
            // 
            this.CikisTarihiDateTime.Location = new System.Drawing.Point(95, 179);
            this.CikisTarihiDateTime.Name = "CikisTarihiDateTime";
            this.CikisTarihiDateTime.Size = new System.Drawing.Size(294, 34);
            this.CikisTarihiDateTime.TabIndex = 3;
            // 
            // MusteriListeTablo
            // 
            this.MusteriListeTablo.AllowUserToAddRows = false;
            this.MusteriListeTablo.AllowUserToDeleteRows = false;
            this.MusteriListeTablo.AllowUserToResizeColumns = false;
            this.MusteriListeTablo.AllowUserToResizeRows = false;
            this.MusteriListeTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MusteriListeTablo.BackgroundColor = System.Drawing.Color.Lavender;
            this.MusteriListeTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListeTablo.Location = new System.Drawing.Point(416, 59);
            this.MusteriListeTablo.MultiSelect = false;
            this.MusteriListeTablo.Name = "MusteriListeTablo";
            this.MusteriListeTablo.ReadOnly = true;
            this.MusteriListeTablo.RowHeadersWidth = 51;
            this.MusteriListeTablo.RowTemplate.Height = 24;
            this.MusteriListeTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriListeTablo.Size = new System.Drawing.Size(695, 298);
            this.MusteriListeTablo.TabIndex = 4;
            this.MusteriListeTablo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriListeTablo_CellContentClick);
            // 
            // OdaListeTablo
            // 
            this.OdaListeTablo.AllowUserToAddRows = false;
            this.OdaListeTablo.AllowUserToDeleteRows = false;
            this.OdaListeTablo.AllowUserToResizeColumns = false;
            this.OdaListeTablo.AllowUserToResizeRows = false;
            this.OdaListeTablo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OdaListeTablo.BackgroundColor = System.Drawing.Color.Lavender;
            this.OdaListeTablo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaListeTablo.Location = new System.Drawing.Point(95, 387);
            this.OdaListeTablo.MultiSelect = false;
            this.OdaListeTablo.Name = "OdaListeTablo";
            this.OdaListeTablo.ReadOnly = true;
            this.OdaListeTablo.RowHeadersWidth = 51;
            this.OdaListeTablo.RowTemplate.Height = 24;
            this.OdaListeTablo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdaListeTablo.Size = new System.Drawing.Size(786, 298);
            this.OdaListeTablo.TabIndex = 5;
            this.OdaListeTablo.SelectionChanged += new System.EventHandler(this.OdaListeTablo_SelectionChanged);
            // 
            // BosOdaListelebtn
            // 
            this.BosOdaListelebtn.BackColor = System.Drawing.Color.Lavender;
            this.BosOdaListelebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BosOdaListelebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BosOdaListelebtn.Location = new System.Drawing.Point(248, 219);
            this.BosOdaListelebtn.Name = "BosOdaListelebtn";
            this.BosOdaListelebtn.Size = new System.Drawing.Size(141, 47);
            this.BosOdaListelebtn.TabIndex = 6;
            this.BosOdaListelebtn.Text = "Oda Listele";
            this.BosOdaListelebtn.UseVisualStyleBackColor = false;
            this.BosOdaListelebtn.Click += new System.EventHandler(this.BosOdaListelebtn_Click);
            // 
            // MüsteriListelbl
            // 
            this.MüsteriListelbl.AutoSize = true;
            this.MüsteriListelbl.Location = new System.Drawing.Point(411, 28);
            this.MüsteriListelbl.Name = "MüsteriListelbl";
            this.MüsteriListelbl.Size = new System.Drawing.Size(140, 28);
            this.MüsteriListelbl.TabIndex = 7;
            this.MüsteriListelbl.Text = "Müşteri Listesi";
            // 
            // OdaListelbl
            // 
            this.OdaListelbl.AutoSize = true;
            this.OdaListelbl.Location = new System.Drawing.Point(90, 356);
            this.OdaListelbl.Name = "OdaListelbl";
            this.OdaListelbl.Size = new System.Drawing.Size(109, 28);
            this.OdaListelbl.TabIndex = 8;
            this.OdaListelbl.Text = "Oda Listesi";
            // 
            // RezervasyonOnaybtn
            // 
            this.RezervasyonOnaybtn.BackColor = System.Drawing.Color.Lavender;
            this.RezervasyonOnaybtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RezervasyonOnaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervasyonOnaybtn.Location = new System.Drawing.Point(887, 543);
            this.RezervasyonOnaybtn.Name = "RezervasyonOnaybtn";
            this.RezervasyonOnaybtn.Size = new System.Drawing.Size(224, 47);
            this.RezervasyonOnaybtn.TabIndex = 9;
            this.RezervasyonOnaybtn.Text = "Onay";
            this.RezervasyonOnaybtn.UseVisualStyleBackColor = false;
            this.RezervasyonOnaybtn.Click += new System.EventHandler(this.RezervasyonOnaybtn_Click);
            // 
            // Ucrettxtbox
            // 
            this.Ucrettxtbox.BackColor = System.Drawing.Color.Lavender;
            this.Ucrettxtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Ucrettxtbox.Location = new System.Drawing.Point(887, 418);
            this.Ucrettxtbox.Name = "Ucrettxtbox";
            this.Ucrettxtbox.Size = new System.Drawing.Size(224, 34);
            this.Ucrettxtbox.TabIndex = 10;
            this.Ucrettxtbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Ucrettxtbox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(907, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "Fiyat Değiştir";
            // 
            // Rezervasyon_Yap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ucrettxtbox);
            this.Controls.Add(this.RezervasyonOnaybtn);
            this.Controls.Add(this.OdaListelbl);
            this.Controls.Add(this.MüsteriListelbl);
            this.Controls.Add(this.BosOdaListelebtn);
            this.Controls.Add(this.OdaListeTablo);
            this.Controls.Add(this.MusteriListeTablo);
            this.Controls.Add(this.CikisTarihiDateTime);
            this.Controls.Add(this.GirisTarihiDateTime);
            this.Controls.Add(this.CikisTarihlbl);
            this.Controls.Add(this.GirisTarihlbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rezervasyon_Yap";
            this.Size = new System.Drawing.Size(1182, 751);
            this.Load += new System.EventHandler(this.Rezervasyon_Yap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListeTablo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeTablo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GirisTarihlbl;
        private System.Windows.Forms.Label CikisTarihlbl;
        private System.Windows.Forms.DateTimePicker GirisTarihiDateTime;
        private System.Windows.Forms.DateTimePicker CikisTarihiDateTime;
        private System.Windows.Forms.DataGridView MusteriListeTablo;
        private System.Windows.Forms.DataGridView OdaListeTablo;
        private System.Windows.Forms.Button BosOdaListelebtn;
        private System.Windows.Forms.Label MüsteriListelbl;
        private System.Windows.Forms.Label OdaListelbl;
        private System.Windows.Forms.Button RezervasyonOnaybtn;
        private System.Windows.Forms.TextBox Ucrettxtbox;
        private System.Windows.Forms.Label label1;
    }
}
