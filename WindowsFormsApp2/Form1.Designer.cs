
namespace WindowsFormsApp2
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.Ilan_Tarih = new System.Windows.Forms.TextBox();
            this.Arac_Fiyat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AracID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Satilik_Arac_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Stok_ID = new System.Windows.Forms.TextBox();
            this.Ara = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1124, 530);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 44);
            this.button1.TabIndex = 0;
            this.button1.Text = "Sonraki Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Khaki;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(24, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(622, 52);
            this.button2.TabIndex = 6;
            this.button2.Text = "ARAÇLARI SATILIĞA KOY";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(24, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 426);
            this.dataGridView1.TabIndex = 7;
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Location = new System.Drawing.Point(1083, 96);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(176, 41);
            this.button3.TabIndex = 59;
            this.button3.Text = "Ekle";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnGuncelle.Location = new System.Drawing.Point(1083, 198);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(176, 41);
            this.BtnGuncelle.TabIndex = 57;
            this.BtnGuncelle.Text = "Güncelle";
            this.BtnGuncelle.UseVisualStyleBackColor = true;
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSil.Location = new System.Drawing.Point(1083, 147);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(176, 41);
            this.btnSil.TabIndex = 56;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListele.Location = new System.Drawing.Point(1083, 40);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(176, 41);
            this.BtnListele.TabIndex = 55;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // Ilan_Tarih
            // 
            this.Ilan_Tarih.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ilan_Tarih.Location = new System.Drawing.Point(832, 151);
            this.Ilan_Tarih.Name = "Ilan_Tarih";
            this.Ilan_Tarih.Size = new System.Drawing.Size(176, 28);
            this.Ilan_Tarih.TabIndex = 49;
            // 
            // Arac_Fiyat
            // 
            this.Arac_Fiyat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Arac_Fiyat.Location = new System.Drawing.Point(832, 113);
            this.Arac_Fiyat.Name = "Arac_Fiyat";
            this.Arac_Fiyat.Size = new System.Drawing.Size(176, 28);
            this.Arac_Fiyat.TabIndex = 47;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(698, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 24);
            this.label4.TabIndex = 46;
            this.label4.Text = "Fiyat:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(698, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 24);
            this.label3.TabIndex = 45;
            this.label3.Text = "Stok ID:";
            // 
            // AracID
            // 
            this.AracID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AracID.Location = new System.Drawing.Point(832, 40);
            this.AracID.Name = "AracID";
            this.AracID.Size = new System.Drawing.Size(176, 28);
            this.AracID.TabIndex = 44;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(698, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Araç ID:";
            // 
            // Satilik_Arac_ID
            // 
            this.Satilik_Arac_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Satilik_Arac_ID.Location = new System.Drawing.Point(832, 194);
            this.Satilik_Arac_ID.Name = "Satilik_Arac_ID";
            this.Satilik_Arac_ID.Size = new System.Drawing.Size(176, 28);
            this.Satilik_Arac_ID.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(698, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Satılık Araç ID:";
            // 
            // Stok_ID
            // 
            this.Stok_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Stok_ID.Location = new System.Drawing.Point(832, 76);
            this.Stok_ID.Name = "Stok_ID";
            this.Stok_ID.Size = new System.Drawing.Size(176, 28);
            this.Stok_ID.TabIndex = 60;
            // 
            // Ara
            // 
            this.Ara.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Ara.Location = new System.Drawing.Point(1083, 245);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(176, 41);
            this.Ara.TabIndex = 61;
            this.Ara.Text = "Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(698, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 24);
            this.label7.TabIndex = 64;
            this.label7.Text = "İlan Tarih:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1296, 600);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Stok_ID);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BtnGuncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.Ilan_Tarih);
            this.Controls.Add(this.Arac_Fiyat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AracID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Satilik_Arac_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox Ilan_Tarih;
        private System.Windows.Forms.TextBox Arac_Fiyat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AracID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Satilik_Arac_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Stok_ID;
        private System.Windows.Forms.Button Ara;
        private System.Windows.Forms.Label label7;
    }
}

