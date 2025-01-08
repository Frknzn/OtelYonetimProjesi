namespace OtelYönetimProjesi
{
    partial class Form1
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
            this.Girisyanpanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.YoneticiGirisLbl = new System.Windows.Forms.Label();
            this.GirisKimlikNoLbl = new System.Windows.Forms.Label();
            this.GirisSifreLbl = new System.Windows.Forms.Label();
            this.GirisKimliktxt = new System.Windows.Forms.TextBox();
            this.GirisUstPanel = new System.Windows.Forms.Panel();
            this.ÇıkısBt = new System.Windows.Forms.Button();
            this.GirisSifre = new System.Windows.Forms.TextBox();
            this.KurtarmaLbl = new System.Windows.Forms.LinkLabel();
            this.GirisBtn = new System.Windows.Forms.Button();
            this.Girisyanpanel.SuspendLayout();
            this.GirisUstPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Girisyanpanel
            // 
            this.Girisyanpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(2)))), ((int)(((byte)(52)))));
            this.Girisyanpanel.Controls.Add(this.label1);
            this.Girisyanpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Girisyanpanel.ForeColor = System.Drawing.Color.White;
            this.Girisyanpanel.Location = new System.Drawing.Point(0, 0);
            this.Girisyanpanel.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Girisyanpanel.Name = "Girisyanpanel";
            this.Girisyanpanel.Size = new System.Drawing.Size(334, 793);
            this.Girisyanpanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Lavender;
            this.label1.Location = new System.Drawing.Point(1, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 114);
            this.label1.TabIndex = 9;
            this.label1.Text = "Amasya Grand \r\nHotel";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // YoneticiGirisLbl
            // 
            this.YoneticiGirisLbl.AutoSize = true;
            this.YoneticiGirisLbl.Location = new System.Drawing.Point(342, 94);
            this.YoneticiGirisLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YoneticiGirisLbl.Name = "YoneticiGirisLbl";
            this.YoneticiGirisLbl.Size = new System.Drawing.Size(136, 28);
            this.YoneticiGirisLbl.TabIndex = 1;
            this.YoneticiGirisLbl.Text = "Yönetici Giriş";
            // 
            // GirisKimlikNoLbl
            // 
            this.GirisKimlikNoLbl.AutoSize = true;
            this.GirisKimlikNoLbl.Location = new System.Drawing.Point(342, 159);
            this.GirisKimlikNoLbl.Name = "GirisKimlikNoLbl";
            this.GirisKimlikNoLbl.Size = new System.Drawing.Size(184, 28);
            this.GirisKimlikNoLbl.TabIndex = 2;
            this.GirisKimlikNoLbl.Text = "Kimlik Numaranız";
            // 
            // GirisSifreLbl
            // 
            this.GirisSifreLbl.AutoSize = true;
            this.GirisSifreLbl.Location = new System.Drawing.Point(342, 245);
            this.GirisSifreLbl.Name = "GirisSifreLbl";
            this.GirisSifreLbl.Size = new System.Drawing.Size(55, 28);
            this.GirisSifreLbl.TabIndex = 3;
            this.GirisSifreLbl.Text = "Şifre";
            // 
            // GirisKimliktxt
            // 
            this.GirisKimliktxt.BackColor = System.Drawing.Color.Lavender;
            this.GirisKimliktxt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GirisKimliktxt.ForeColor = System.Drawing.Color.Black;
            this.GirisKimliktxt.Location = new System.Drawing.Point(347, 190);
            this.GirisKimliktxt.Name = "GirisKimliktxt";
            this.GirisKimliktxt.Size = new System.Drawing.Size(515, 34);
            this.GirisKimliktxt.TabIndex = 4;
            // 
            // GirisUstPanel
            // 
            this.GirisUstPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.GirisUstPanel.Controls.Add(this.ÇıkısBt);
            this.GirisUstPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.GirisUstPanel.Location = new System.Drawing.Point(334, 0);
            this.GirisUstPanel.Name = "GirisUstPanel";
            this.GirisUstPanel.Size = new System.Drawing.Size(1183, 40);
            this.GirisUstPanel.TabIndex = 5;
            // 
            // ÇıkısBt
            // 
            this.ÇıkısBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ÇıkısBt.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.ÇıkısBt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ÇıkısBt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ÇıkısBt.ForeColor = System.Drawing.Color.Lavender;
            this.ÇıkısBt.Location = new System.Drawing.Point(1141, 3);
            this.ÇıkısBt.Name = "ÇıkısBt";
            this.ÇıkısBt.Size = new System.Drawing.Size(39, 37);
            this.ÇıkısBt.TabIndex = 6;
            this.ÇıkısBt.Text = "X";
            this.ÇıkısBt.UseVisualStyleBackColor = false;
            this.ÇıkısBt.Click += new System.EventHandler(this.ÇıkısBt_Click);
            // 
            // GirisSifre
            // 
            this.GirisSifre.BackColor = System.Drawing.Color.Lavender;
            this.GirisSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GirisSifre.Location = new System.Drawing.Point(347, 276);
            this.GirisSifre.Name = "GirisSifre";
            this.GirisSifre.PasswordChar = '*';
            this.GirisSifre.Size = new System.Drawing.Size(515, 34);
            this.GirisSifre.TabIndex = 6;
            // 
            // KurtarmaLbl
            // 
            this.KurtarmaLbl.AutoSize = true;
            this.KurtarmaLbl.Location = new System.Drawing.Point(341, 313);
            this.KurtarmaLbl.Name = "KurtarmaLbl";
            this.KurtarmaLbl.Size = new System.Drawing.Size(200, 28);
            this.KurtarmaLbl.TabIndex = 7;
            this.KurtarmaLbl.TabStop = true;
            this.KurtarmaLbl.Text = "Şifreni mi unuttun ?";
            this.KurtarmaLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.KurtarmaLbl_LinkClicked);
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.Lavender;
            this.GirisBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisBtn.Location = new System.Drawing.Point(698, 316);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(164, 34);
            this.GirisBtn.TabIndex = 8;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1517, 793);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.KurtarmaLbl);
            this.Controls.Add(this.GirisSifre);
            this.Controls.Add(this.GirisUstPanel);
            this.Controls.Add(this.GirisKimliktxt);
            this.Controls.Add(this.GirisSifreLbl);
            this.Controls.Add(this.GirisKimlikNoLbl);
            this.Controls.Add(this.YoneticiGirisLbl);
            this.Controls.Add(this.Girisyanpanel);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Girisyanpanel.ResumeLayout(false);
            this.Girisyanpanel.PerformLayout();
            this.GirisUstPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Girisyanpanel;
        private System.Windows.Forms.Label YoneticiGirisLbl;
        private System.Windows.Forms.Label GirisKimlikNoLbl;
        private System.Windows.Forms.Label GirisSifreLbl;
        private System.Windows.Forms.TextBox GirisKimliktxt;
        private System.Windows.Forms.Panel GirisUstPanel;
        private System.Windows.Forms.Button ÇıkısBt;
        private System.Windows.Forms.TextBox GirisSifre;
        private System.Windows.Forms.LinkLabel KurtarmaLbl;
        private System.Windows.Forms.Button GirisBtn;
        private System.Windows.Forms.Label label1;
    }
}

