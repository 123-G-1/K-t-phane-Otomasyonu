namespace Kütüphane_Otomasyonu
{
    partial class AnaSayfaFrm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUyeListele = new System.Windows.Forms.Button();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnKitapListele = new System.Windows.Forms.Button();
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnGrafik = new System.Windows.Forms.Button();
            this.btnSıralama = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnEmanetİade = new System.Windows.Forms.Button();
            this.btnEmanetListele = new System.Windows.Forms.Button();
            this.btnEmanetVer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUyeListele);
            this.groupBox1.Controls.Add(this.btnUyeEkle);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(74, 35);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(494, 231);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Üye İşlemleri";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnUyeListele
            // 
            this.btnUyeListele.Location = new System.Drawing.Point(33, 132);
            this.btnUyeListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeListele.Name = "btnUyeListele";
            this.btnUyeListele.Size = new System.Drawing.Size(423, 59);
            this.btnUyeListele.TabIndex = 1;
            this.btnUyeListele.Text = "Üye Listeleme İşlemleri";
            this.btnUyeListele.UseVisualStyleBackColor = true;
            // 
            // btnUyeEkle
            // 
            this.btnUyeEkle.Location = new System.Drawing.Point(33, 42);
            this.btnUyeEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnUyeEkle.Name = "btnUyeEkle";
            this.btnUyeEkle.Size = new System.Drawing.Size(423, 66);
            this.btnUyeEkle.TabIndex = 0;
            this.btnUyeEkle.Text = "Üye Ekleme İşlemleri";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnKitapListele);
            this.groupBox2.Controls.Add(this.btnKitapEkle);
            this.groupBox2.Location = new System.Drawing.Point(650, 35);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(494, 231);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kitap İşlemleri";
            // 
            // btnKitapListele
            // 
            this.btnKitapListele.Location = new System.Drawing.Point(41, 132);
            this.btnKitapListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapListele.Name = "btnKitapListele";
            this.btnKitapListele.Size = new System.Drawing.Size(423, 59);
            this.btnKitapListele.TabIndex = 1;
            this.btnKitapListele.Text = "Kitap Listeleme İşlemleri";
            this.btnKitapListele.UseVisualStyleBackColor = true;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Location = new System.Drawing.Point(41, 42);
            this.btnKitapEkle.Margin = new System.Windows.Forms.Padding(4);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(423, 66);
            this.btnKitapEkle.TabIndex = 0;
            this.btnKitapEkle.Text = "Kitap Ekleme İşlemleri";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnGrafik);
            this.groupBox4.Controls.Add(this.btnSıralama);
            this.groupBox4.Location = new System.Drawing.Point(650, 365);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(494, 346);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Sıralama Ve Grafikler";
            // 
            // btnGrafik
            // 
            this.btnGrafik.Location = new System.Drawing.Point(27, 167);
            this.btnGrafik.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrafik.Name = "btnGrafik";
            this.btnGrafik.Size = new System.Drawing.Size(423, 60);
            this.btnGrafik.TabIndex = 1;
            this.btnGrafik.Text = "Grafikler";
            this.btnGrafik.UseVisualStyleBackColor = true;
            // 
            // btnSıralama
            // 
            this.btnSıralama.Location = new System.Drawing.Point(27, 80);
            this.btnSıralama.Margin = new System.Windows.Forms.Padding(4);
            this.btnSıralama.Name = "btnSıralama";
            this.btnSıralama.Size = new System.Drawing.Size(423, 60);
            this.btnSıralama.TabIndex = 0;
            this.btnSıralama.Text = "Sıralama";
            this.btnSıralama.UseVisualStyleBackColor = true;
            this.btnSıralama.Click += new System.EventHandler(this.button8_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnEmanetİade);
            this.groupBox3.Controls.Add(this.btnEmanetListele);
            this.groupBox3.Controls.Add(this.btnEmanetVer);
            this.groupBox3.Location = new System.Drawing.Point(74, 365);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(494, 346);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Emanet Kitap İşlemleri";
            // 
            // btnEmanetİade
            // 
            this.btnEmanetİade.Location = new System.Drawing.Point(33, 244);
            this.btnEmanetİade.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetİade.Name = "btnEmanetİade";
            this.btnEmanetİade.Size = new System.Drawing.Size(423, 58);
            this.btnEmanetİade.TabIndex = 2;
            this.btnEmanetİade.Text = "Emanet Kitap İade işlemleri";
            this.btnEmanetİade.UseVisualStyleBackColor = true;
            // 
            // btnEmanetListele
            // 
            this.btnEmanetListele.Location = new System.Drawing.Point(33, 155);
            this.btnEmanetListele.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetListele.Name = "btnEmanetListele";
            this.btnEmanetListele.Size = new System.Drawing.Size(423, 60);
            this.btnEmanetListele.TabIndex = 1;
            this.btnEmanetListele.Text = "Emanet Kitap Listeleme İşlemleri";
            this.btnEmanetListele.UseVisualStyleBackColor = true;
            // 
            // btnEmanetVer
            // 
            this.btnEmanetVer.Location = new System.Drawing.Point(33, 69);
            this.btnEmanetVer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmanetVer.Name = "btnEmanetVer";
            this.btnEmanetVer.Size = new System.Drawing.Size(423, 60);
            this.btnEmanetVer.TabIndex = 0;
            this.btnEmanetVer.Text = "Emanet Kitap Verme İşlemleri";
            this.btnEmanetVer.UseVisualStyleBackColor = true;
            // 
            // AnaSayfaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1209, 758);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AnaSayfaFrm";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.AnaSayfaFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnUyeListele;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnKitapListele;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.Button btnGrafik;
        private System.Windows.Forms.Button btnSıralama;
        private System.Windows.Forms.Button btnEmanetİade;
        private System.Windows.Forms.Button btnEmanetListele;
        private System.Windows.Forms.Button btnEmanetVer;
    }
}

