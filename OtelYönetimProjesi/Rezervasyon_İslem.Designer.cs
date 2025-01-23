namespace OtelYönetimProjesi
{
    partial class Rezervasyon_İslem
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
            this.GirisTarihilbl = new System.Windows.Forms.Label();
            this.CıkısTarihilbl = new System.Windows.Forms.Label();
            this.OdaListeGridView = new System.Windows.Forms.DataGridView();
            this.OdaListelbl = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.RezervasyonOnaybtn = new System.Windows.Forms.Button();
            this.MusteriListGridView = new System.Windows.Forms.DataGridView();
            this.MusteriListlbl = new System.Windows.Forms.Label();
            this.RezervasyonMusteriListelebtn = new System.Windows.Forms.Button();
            this.RezervasyonOdaListelebtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // GirisTarihilbl
            // 
            this.GirisTarihilbl.AutoSize = true;
            this.GirisTarihilbl.Location = new System.Drawing.Point(781, 89);
            this.GirisTarihilbl.Name = "GirisTarihilbl";
            this.GirisTarihilbl.Size = new System.Drawing.Size(113, 28);
            this.GirisTarihilbl.TabIndex = 0;
            this.GirisTarihilbl.Text = "Giriş Tarihi";
            // 
            // CıkısTarihilbl
            // 
            this.CıkısTarihilbl.AutoSize = true;
            this.CıkısTarihilbl.Location = new System.Drawing.Point(781, 191);
            this.CıkısTarihilbl.Name = "CıkısTarihilbl";
            this.CıkısTarihilbl.Size = new System.Drawing.Size(115, 28);
            this.CıkısTarihilbl.TabIndex = 1;
            this.CıkısTarihilbl.Text = "Çıkış Tarihi";
            // 
            // OdaListeGridView
            // 
            this.OdaListeGridView.AllowUserToAddRows = false;
            this.OdaListeGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OdaListeGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.OdaListeGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OdaListeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OdaListeGridView.GridColor = System.Drawing.Color.Lavender;
            this.OdaListeGridView.Location = new System.Drawing.Point(65, 402);
            this.OdaListeGridView.MultiSelect = false;
            this.OdaListeGridView.Name = "OdaListeGridView";
            this.OdaListeGridView.RowHeadersVisible = false;
            this.OdaListeGridView.RowHeadersWidth = 51;
            this.OdaListeGridView.RowTemplate.Height = 24;
            this.OdaListeGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OdaListeGridView.Size = new System.Drawing.Size(659, 238);
            this.OdaListeGridView.TabIndex = 14;
            // 
            // OdaListelbl
            // 
            this.OdaListelbl.AutoSize = true;
            this.OdaListelbl.Location = new System.Drawing.Point(60, 359);
            this.OdaListelbl.Name = "OdaListelbl";
            this.OdaListelbl.Size = new System.Drawing.Size(109, 28);
            this.OdaListelbl.TabIndex = 15;
            this.OdaListelbl.Text = "Oda Listesi";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(786, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(330, 34);
            this.dateTimePicker1.TabIndex = 16;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(786, 222);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(327, 34);
            this.dateTimePicker2.TabIndex = 17;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // RezervasyonOnaybtn
            // 
            this.RezervasyonOnaybtn.BackColor = System.Drawing.Color.Lavender;
            this.RezervasyonOnaybtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RezervasyonOnaybtn.FlatAppearance.BorderSize = 2;
            this.RezervasyonOnaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervasyonOnaybtn.Location = new System.Drawing.Point(945, 307);
            this.RezervasyonOnaybtn.Name = "RezervasyonOnaybtn";
            this.RezervasyonOnaybtn.Size = new System.Drawing.Size(171, 42);
            this.RezervasyonOnaybtn.TabIndex = 18;
            this.RezervasyonOnaybtn.Text = "Onay";
            this.RezervasyonOnaybtn.UseVisualStyleBackColor = false;
            this.RezervasyonOnaybtn.Click += new System.EventHandler(this.RezervasyonOnaybtn_Click);
            // 
            // MusteriListGridView
            // 
            this.MusteriListGridView.AllowUserToAddRows = false;
            this.MusteriListGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MusteriListGridView.BackgroundColor = System.Drawing.Color.Lavender;
            this.MusteriListGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MusteriListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MusteriListGridView.GridColor = System.Drawing.Color.Lavender;
            this.MusteriListGridView.Location = new System.Drawing.Point(65, 103);
            this.MusteriListGridView.MultiSelect = false;
            this.MusteriListGridView.Name = "MusteriListGridView";
            this.MusteriListGridView.RowHeadersVisible = false;
            this.MusteriListGridView.RowHeadersWidth = 51;
            this.MusteriListGridView.RowTemplate.Height = 24;
            this.MusteriListGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MusteriListGridView.Size = new System.Drawing.Size(659, 238);
            this.MusteriListGridView.TabIndex = 19;
            this.MusteriListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MusteriListGridView_CellContentClick);
            // 
            // MusteriListlbl
            // 
            this.MusteriListlbl.AutoSize = true;
            this.MusteriListlbl.Location = new System.Drawing.Point(60, 72);
            this.MusteriListlbl.Name = "MusteriListlbl";
            this.MusteriListlbl.Size = new System.Drawing.Size(140, 28);
            this.MusteriListlbl.TabIndex = 20;
            this.MusteriListlbl.Text = "Müşteri Listesi";
            // 
            // RezervasyonMusteriListelebtn
            // 
            this.RezervasyonMusteriListelebtn.BackColor = System.Drawing.Color.Lavender;
            this.RezervasyonMusteriListelebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RezervasyonMusteriListelebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervasyonMusteriListelebtn.Location = new System.Drawing.Point(599, 347);
            this.RezervasyonMusteriListelebtn.Name = "RezervasyonMusteriListelebtn";
            this.RezervasyonMusteriListelebtn.Size = new System.Drawing.Size(125, 36);
            this.RezervasyonMusteriListelebtn.TabIndex = 21;
            this.RezervasyonMusteriListelebtn.Text = "Listele\r\n";
            this.RezervasyonMusteriListelebtn.UseVisualStyleBackColor = false;
            this.RezervasyonMusteriListelebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // RezervasyonOdaListelebtn
            // 
            this.RezervasyonOdaListelebtn.BackColor = System.Drawing.Color.Lavender;
            this.RezervasyonOdaListelebtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.RezervasyonOdaListelebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RezervasyonOdaListelebtn.Location = new System.Drawing.Point(599, 646);
            this.RezervasyonOdaListelebtn.Name = "RezervasyonOdaListelebtn";
            this.RezervasyonOdaListelebtn.Size = new System.Drawing.Size(125, 36);
            this.RezervasyonOdaListelebtn.TabIndex = 22;
            this.RezervasyonOdaListelebtn.Text = "Listele\r\n";
            this.RezervasyonOdaListelebtn.UseVisualStyleBackColor = false;
            this.RezervasyonOdaListelebtn.Click += new System.EventHandler(this.RezervasyonOdaListelebtn_Click);
            // 
            // Rezervasyon_İslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.Controls.Add(this.RezervasyonOdaListelebtn);
            this.Controls.Add(this.RezervasyonMusteriListelebtn);
            this.Controls.Add(this.MusteriListlbl);
            this.Controls.Add(this.MusteriListGridView);
            this.Controls.Add(this.RezervasyonOnaybtn);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.OdaListelbl);
            this.Controls.Add(this.OdaListeGridView);
            this.Controls.Add(this.CıkısTarihilbl);
            this.Controls.Add(this.GirisTarihilbl);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Rezervasyon_İslem";
            this.Size = new System.Drawing.Size(1182, 751);
            this.Load += new System.EventHandler(this.Rezervasyon_İslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OdaListeGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MusteriListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GirisTarihilbl;
        private System.Windows.Forms.Label CıkısTarihilbl;
        private System.Windows.Forms.DataGridView OdaListeGridView;
        private System.Windows.Forms.Label OdaListelbl;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button RezervasyonOnaybtn;
        private System.Windows.Forms.DataGridView MusteriListGridView;
        private System.Windows.Forms.Label MusteriListlbl;
        private System.Windows.Forms.Button RezervasyonMusteriListelebtn;
        private System.Windows.Forms.Button RezervasyonOdaListelebtn;
    }
}
