
namespace WindowsFormsApp2
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.Sepet_ID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Satilik_Arac_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.BtnListele = new System.Windows.Forms.Button();
            this.Sepet_Arac_ID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 45);
            this.button1.TabIndex = 1;
            this.button1.Text = "Önceki Sayfa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(24, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(622, 426);
            this.dataGridView1.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Khaki;
            this.button3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button3.Location = new System.Drawing.Point(24, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(622, 52);
            this.button3.TabIndex = 9;
            this.button3.Text = "SATILIK ARAÇLAR";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Sepet_ID
            // 
            this.Sepet_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sepet_ID.Location = new System.Drawing.Point(880, 126);
            this.Sepet_ID.Name = "Sepet_ID";
            this.Sepet_ID.Size = new System.Drawing.Size(176, 28);
            this.Sepet_ID.TabIndex = 48;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(731, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Sepet ID:";
            // 
            // Satilik_Arac_ID
            // 
            this.Satilik_Arac_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Satilik_Arac_ID.Location = new System.Drawing.Point(880, 89);
            this.Satilik_Arac_ID.Name = "Satilik_Arac_ID";
            this.Satilik_Arac_ID.Size = new System.Drawing.Size(176, 28);
            this.Satilik_Arac_ID.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(731, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 45;
            this.label1.Text = "Satılık Araç ID:";
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(735, 234);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(321, 41);
            this.button4.TabIndex = 60;
            this.button4.Text = "Sepete Ekle";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnListele
            // 
            this.BtnListele.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnListele.Location = new System.Drawing.Point(735, 187);
            this.BtnListele.Name = "BtnListele";
            this.BtnListele.Size = new System.Drawing.Size(321, 41);
            this.BtnListele.TabIndex = 61;
            this.BtnListele.Text = "Listele";
            this.BtnListele.UseVisualStyleBackColor = true;
            this.BtnListele.Click += new System.EventHandler(this.BtnListele_Click);
            // 
            // Sepet_Arac_ID
            // 
            this.Sepet_Arac_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Sepet_Arac_ID.Location = new System.Drawing.Point(880, 55);
            this.Sepet_Arac_ID.Name = "Sepet_Arac_ID";
            this.Sepet_Arac_ID.Size = new System.Drawing.Size(176, 28);
            this.Sepet_Arac_ID.TabIndex = 63;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(731, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 24);
            this.label3.TabIndex = 62;
            this.label3.Text = "Sepet Arac ID:";
            // 
            // button5
            // 
            this.button5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Location = new System.Drawing.Point(735, 281);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(321, 41);
            this.button5.TabIndex = 64;
            this.button5.Text = "Sepetten Sil";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button8
            // 
            this.button8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(735, 345);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(321, 41);
            this.button8.TabIndex = 67;
            this.button8.Text = "Satın Al";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 614);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Sepet_Arac_ID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnListele);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.Sepet_ID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Satilik_Arac_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.Text = "Sepette Ara";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Sepet_ID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Satilik_Arac_ID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button BtnListele;
        private System.Windows.Forms.TextBox Sepet_Arac_ID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
    }
}