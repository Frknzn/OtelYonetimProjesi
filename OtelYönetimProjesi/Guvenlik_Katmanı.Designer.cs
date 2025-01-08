namespace OtelYönetimProjesi
{
    partial class Guvenlik_Katmanı
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GuvenlikCıkısbtn = new System.Windows.Forms.Button();
            this.GuvenlikMetin = new System.Windows.Forms.Label();
            this.GuvenlikKodutxt = new System.Windows.Forms.TextBox();
            this.GuvenlikKoduGirtxt = new System.Windows.Forms.TextBox();
            this.Onaybtn = new System.Windows.Forms.Button();
            this.GuvenlikKoduVerbtn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(12, 533);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.panel2.Controls.Add(this.GuvenlikCıkısbtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(12, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(688, 51);
            this.panel2.TabIndex = 1;
            // 
            // GuvenlikCıkısbtn
            // 
            this.GuvenlikCıkısbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.GuvenlikCıkısbtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.GuvenlikCıkısbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuvenlikCıkısbtn.ForeColor = System.Drawing.Color.Lavender;
            this.GuvenlikCıkısbtn.Location = new System.Drawing.Point(643, 4);
            this.GuvenlikCıkısbtn.Name = "GuvenlikCıkısbtn";
            this.GuvenlikCıkısbtn.Size = new System.Drawing.Size(42, 44);
            this.GuvenlikCıkısbtn.TabIndex = 9;
            this.GuvenlikCıkısbtn.Text = "X";
            this.GuvenlikCıkısbtn.UseVisualStyleBackColor = false;
            this.GuvenlikCıkısbtn.Click += new System.EventHandler(this.GuvenlikCıkısbtn_Click);
            // 
            // GuvenlikMetin
            // 
            this.GuvenlikMetin.AutoSize = true;
            this.GuvenlikMetin.Location = new System.Drawing.Point(137, 149);
            this.GuvenlikMetin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GuvenlikMetin.Name = "GuvenlikMetin";
            this.GuvenlikMetin.Size = new System.Drawing.Size(250, 28);
            this.GuvenlikMetin.TabIndex = 2;
            this.GuvenlikMetin.Text = "Ekrana Gelen Kodu Giriniz";
            // 
            // GuvenlikKodutxt
            // 
            this.GuvenlikKodutxt.BackColor = System.Drawing.Color.Lavender;
            this.GuvenlikKodutxt.Enabled = false;
            this.GuvenlikKodutxt.Location = new System.Drawing.Point(142, 180);
            this.GuvenlikKodutxt.Name = "GuvenlikKodutxt";
            this.GuvenlikKodutxt.Size = new System.Drawing.Size(398, 34);
            this.GuvenlikKodutxt.TabIndex = 3;
            // 
            // GuvenlikKoduGirtxt
            // 
            this.GuvenlikKoduGirtxt.BackColor = System.Drawing.Color.Lavender;
            this.GuvenlikKoduGirtxt.Location = new System.Drawing.Point(142, 265);
            this.GuvenlikKoduGirtxt.Name = "GuvenlikKoduGirtxt";
            this.GuvenlikKoduGirtxt.Size = new System.Drawing.Size(398, 34);
            this.GuvenlikKoduGirtxt.TabIndex = 4;
            // 
            // Onaybtn
            // 
            this.Onaybtn.BackColor = System.Drawing.Color.Lavender;
            this.Onaybtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Onaybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Onaybtn.Location = new System.Drawing.Point(399, 305);
            this.Onaybtn.Name = "Onaybtn";
            this.Onaybtn.Size = new System.Drawing.Size(141, 39);
            this.Onaybtn.TabIndex = 5;
            this.Onaybtn.Text = "Onay";
            this.Onaybtn.UseVisualStyleBackColor = false;
            this.Onaybtn.Click += new System.EventHandler(this.Onaybtn_Click);
            // 
            // GuvenlikKoduVerbtn
            // 
            this.GuvenlikKoduVerbtn.BackColor = System.Drawing.Color.Lavender;
            this.GuvenlikKoduVerbtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.GuvenlikKoduVerbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GuvenlikKoduVerbtn.Location = new System.Drawing.Point(399, 220);
            this.GuvenlikKoduVerbtn.Name = "GuvenlikKoduVerbtn";
            this.GuvenlikKoduVerbtn.Size = new System.Drawing.Size(141, 39);
            this.GuvenlikKoduVerbtn.TabIndex = 6;
            this.GuvenlikKoduVerbtn.Text = "Kodu Ver";
            this.GuvenlikKoduVerbtn.UseVisualStyleBackColor = false;
            this.GuvenlikKoduVerbtn.Click += new System.EventHandler(this.GuvenlikKoduVerbtn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(688, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(12, 482);
            this.panel3.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(0)))), ((int)(((byte)(52)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(12, 523);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(676, 10);
            this.panel4.TabIndex = 8;
            // 
            // Guvenlik_Katmanı
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(700, 533);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.GuvenlikKoduVerbtn);
            this.Controls.Add(this.Onaybtn);
            this.Controls.Add(this.GuvenlikKoduGirtxt);
            this.Controls.Add(this.GuvenlikKodutxt);
            this.Controls.Add(this.GuvenlikMetin);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Guvenlik_Katmanı";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guvenlik_Katmanı";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label GuvenlikMetin;
        private System.Windows.Forms.TextBox GuvenlikKodutxt;
        private System.Windows.Forms.TextBox GuvenlikKoduGirtxt;
        private System.Windows.Forms.Button Onaybtn;
        private System.Windows.Forms.Button GuvenlikKoduVerbtn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button GuvenlikCıkısbtn;
    }
}