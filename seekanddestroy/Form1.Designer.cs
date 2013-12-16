namespace seekanddestroy
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnBulveDegistir = new System.Windows.Forms.Button();
            this.lblDurum = new System.Windows.Forms.Label();
            this.txtAnaKlasor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbDegisecekDosyalar = new System.Windows.Forms.ListBox();
            this.lbDegisecekKelimeler = new System.Windows.Forms.ListBox();
            this.txtDegisecekDosyaAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDegisecekKelime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDegisenKelime = new System.Windows.Forms.TextBox();
            this.btnGirisleriTemizle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ana Klasör :";
            // 
            // btnBulveDegistir
            // 
            this.btnBulveDegistir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBulveDegistir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBulveDegistir.ForeColor = System.Drawing.Color.White;
            this.btnBulveDegistir.Location = new System.Drawing.Point(231, 334);
            this.btnBulveDegistir.Name = "btnBulveDegistir";
            this.btnBulveDegistir.Size = new System.Drawing.Size(198, 31);
            this.btnBulveDegistir.TabIndex = 3;
            this.btnBulveDegistir.Text = "Tümünü Bul, Değiştir";
            this.btnBulveDegistir.UseVisualStyleBackColor = false;
            this.btnBulveDegistir.Click += new System.EventHandler(this.btnBulveDegistir_Click);
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDurum.Location = new System.Drawing.Point(91, 9);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(38, 13);
            this.lblDurum.TabIndex = 5;
            this.lblDurum.Text = "Durum";
            // 
            // txtAnaKlasor
            // 
            this.txtAnaKlasor.Location = new System.Drawing.Point(94, 35);
            this.txtAnaKlasor.Name = "txtAnaKlasor";
            this.txtAnaKlasor.Size = new System.Drawing.Size(551, 20);
            this.txtAnaKlasor.TabIndex = 6;
            this.txtAnaKlasor.Text = "C:\\Degisecek_klasor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Durum :";
            // 
            // lbDegisecekDosyalar
            // 
            this.lbDegisecekDosyalar.FormattingEnabled = true;
            this.lbDegisecekDosyalar.Location = new System.Drawing.Point(15, 98);
            this.lbDegisecekDosyalar.Name = "lbDegisecekDosyalar";
            this.lbDegisecekDosyalar.Size = new System.Drawing.Size(305, 225);
            this.lbDegisecekDosyalar.TabIndex = 8;
            this.lbDegisecekDosyalar.DoubleClick += new System.EventHandler(this.lbDegisecekDosyalar_DoubleClick);
            // 
            // lbDegisecekKelimeler
            // 
            this.lbDegisecekKelimeler.FormattingEnabled = true;
            this.lbDegisecekKelimeler.Location = new System.Drawing.Point(340, 98);
            this.lbDegisecekKelimeler.Name = "lbDegisecekKelimeler";
            this.lbDegisecekKelimeler.Size = new System.Drawing.Size(305, 225);
            this.lbDegisecekKelimeler.TabIndex = 9;
            this.lbDegisecekKelimeler.DoubleClick += new System.EventHandler(this.lbDegisecekKelimeler_DoubleClick);
            // 
            // txtDegisecekDosyaAdi
            // 
            this.txtDegisecekDosyaAdi.Location = new System.Drawing.Point(94, 71);
            this.txtDegisecekDosyaAdi.Name = "txtDegisecekDosyaAdi";
            this.txtDegisecekDosyaAdi.Size = new System.Drawing.Size(226, 20);
            this.txtDegisecekDosyaAdi.TabIndex = 12;
            this.txtDegisecekDosyaAdi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDegisecekDosyaAdi_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Dosya Adı:";
            // 
            // txtDegisecekKelime
            // 
            this.txtDegisecekKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDegisecekKelime.ForeColor = System.Drawing.Color.White;
            this.txtDegisecekKelime.Location = new System.Drawing.Point(339, 71);
            this.txtDegisecekKelime.Name = "txtDegisecekKelime";
            this.txtDegisecekKelime.Size = new System.Drawing.Size(140, 20);
            this.txtDegisecekKelime.TabIndex = 14;
            this.txtDegisecekKelime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDegisecekKelime_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(485, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = ">";
            // 
            // txtDegisenKelime
            // 
            this.txtDegisenKelime.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.txtDegisenKelime.ForeColor = System.Drawing.Color.White;
            this.txtDegisenKelime.Location = new System.Drawing.Point(505, 71);
            this.txtDegisenKelime.Name = "txtDegisenKelime";
            this.txtDegisenKelime.Size = new System.Drawing.Size(140, 20);
            this.txtDegisenKelime.TabIndex = 16;
            this.txtDegisenKelime.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDegisenKelime_KeyDown);
            // 
            // btnGirisleriTemizle
            // 
            this.btnGirisleriTemizle.Location = new System.Drawing.Point(12, 334);
            this.btnGirisleriTemizle.Name = "btnGirisleriTemizle";
            this.btnGirisleriTemizle.Size = new System.Drawing.Size(100, 23);
            this.btnGirisleriTemizle.TabIndex = 17;
            this.btnGirisleriTemizle.Text = "Girişleri Temizle";
            this.btnGirisleriTemizle.UseVisualStyleBackColor = true;
            this.btnGirisleriTemizle.Click += new System.EventHandler(this.btnGirisleriTemizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(664, 377);
            this.Controls.Add(this.btnGirisleriTemizle);
            this.Controls.Add(this.txtDegisenKelime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDegisecekKelime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDegisecekDosyaAdi);
            this.Controls.Add(this.lbDegisecekKelimeler);
            this.Controls.Add(this.lbDegisecekDosyalar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnaKlasor);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.btnBulveDegistir);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "C# Bul ve Değiştir - www.yusufdoru.com";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBulveDegistir;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.TextBox txtAnaKlasor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbDegisecekDosyalar;
        private System.Windows.Forms.ListBox lbDegisecekKelimeler;
        private System.Windows.Forms.TextBox txtDegisecekDosyaAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDegisecekKelime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDegisenKelime;
        private System.Windows.Forms.Button btnGirisleriTemizle;
    }
}

