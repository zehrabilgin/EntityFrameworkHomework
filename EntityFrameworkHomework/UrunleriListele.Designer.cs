
namespace EntityFrameworkHomework
{
    partial class UrunleriListele
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
            this.kategorileriGor = new System.Windows.Forms.ComboBox();
            this.urunler = new System.Windows.Forms.Label();
            this.urunlerTablosu = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.urunSec = new System.Windows.Forms.Label();
            this.urunSecCombo = new System.Windows.Forms.ComboBox();
            this.urunSil = new System.Windows.Forms.Button();
            this.urunGuncelle = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunDescription = new System.Windows.Forms.TextBox();
            this.urunRating = new System.Windows.Forms.TextBox();
            this.urunPrice = new System.Windows.Forms.TextBox();
            this.urunName = new System.Windows.Forms.TextBox();
            this.kategoriSec = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosu)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // kategorileriGor
            // 
            this.kategorileriGor.FormattingEnabled = true;
            this.kategorileriGor.Location = new System.Drawing.Point(223, 110);
            this.kategorileriGor.Name = "kategorileriGor";
            this.kategorileriGor.Size = new System.Drawing.Size(121, 21);
            this.kategorileriGor.TabIndex = 6;
            this.kategorileriGor.SelectionChangeCommitted += new System.EventHandler(this.kategorileriGor_SelectionChangeCommitted);
            // 
            // urunler
            // 
            this.urunler.AutoSize = true;
            this.urunler.Location = new System.Drawing.Point(29, 186);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(65, 13);
            this.urunler.TabIndex = 8;
            this.urunler.Text = "Tüm Ürünler";
            // 
            // urunlerTablosu
            // 
            this.urunlerTablosu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.urunlerTablosu.Location = new System.Drawing.Point(32, 202);
            this.urunlerTablosu.Name = "urunlerTablosu";
            this.urunlerTablosu.Size = new System.Drawing.Size(561, 215);
            this.urunlerTablosu.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.urunSec);
            this.groupBox1.Controls.Add(this.urunSecCombo);
            this.groupBox1.Controls.Add(this.urunSil);
            this.groupBox1.Controls.Add(this.urunGuncelle);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.urunDescription);
            this.groupBox1.Controls.Add(this.urunRating);
            this.groupBox1.Controls.Add(this.urunPrice);
            this.groupBox1.Controls.Add(this.urunName);
            this.groupBox1.Location = new System.Drawing.Point(637, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 344);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Güncelle";
            // 
            // urunSec
            // 
            this.urunSec.AutoSize = true;
            this.urunSec.Location = new System.Drawing.Point(121, 40);
            this.urunSec.Name = "urunSec";
            this.urunSec.Size = new System.Drawing.Size(52, 13);
            this.urunSec.TabIndex = 18;
            this.urunSec.Text = "Ürün Seç";
            // 
            // urunSecCombo
            // 
            this.urunSecCombo.FormattingEnabled = true;
            this.urunSecCombo.Location = new System.Drawing.Point(95, 56);
            this.urunSecCombo.Name = "urunSecCombo";
            this.urunSecCombo.Size = new System.Drawing.Size(121, 21);
            this.urunSecCombo.TabIndex = 17;
            this.urunSecCombo.SelectionChangeCommitted += new System.EventHandler(this.urunSecCombo_SelectionChangeCommitted);
            // 
            // urunSil
            // 
            this.urunSil.Location = new System.Drawing.Point(180, 286);
            this.urunSil.Name = "urunSil";
            this.urunSil.Size = new System.Drawing.Size(55, 32);
            this.urunSil.TabIndex = 16;
            this.urunSil.Text = "Sil";
            this.urunSil.UseVisualStyleBackColor = true;
            this.urunSil.Click += new System.EventHandler(this.urunSil_Click);
            // 
            // urunGuncelle
            // 
            this.urunGuncelle.Location = new System.Drawing.Point(79, 286);
            this.urunGuncelle.Name = "urunGuncelle";
            this.urunGuncelle.Size = new System.Drawing.Size(58, 32);
            this.urunGuncelle.TabIndex = 12;
            this.urunGuncelle.Text = "Güncelle";
            this.urunGuncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.urunGuncelle.UseVisualStyleBackColor = true;
            this.urunGuncelle.Click += new System.EventHandler(this.urunGuncelle_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(62, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(62, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // urunDescription
            // 
            this.urunDescription.Location = new System.Drawing.Point(124, 228);
            this.urunDescription.Name = "urunDescription";
            this.urunDescription.Size = new System.Drawing.Size(130, 20);
            this.urunDescription.TabIndex = 5;
            // 
            // urunRating
            // 
            this.urunRating.Location = new System.Drawing.Point(124, 189);
            this.urunRating.Name = "urunRating";
            this.urunRating.Size = new System.Drawing.Size(130, 20);
            this.urunRating.TabIndex = 4;
            // 
            // urunPrice
            // 
            this.urunPrice.Location = new System.Drawing.Point(124, 152);
            this.urunPrice.Name = "urunPrice";
            this.urunPrice.Size = new System.Drawing.Size(130, 20);
            this.urunPrice.TabIndex = 3;
            // 
            // urunName
            // 
            this.urunName.Location = new System.Drawing.Point(124, 115);
            this.urunName.Name = "urunName";
            this.urunName.Size = new System.Drawing.Size(130, 20);
            this.urunName.TabIndex = 1;
            // 
            // kategoriSec
            // 
            this.kategoriSec.AutoSize = true;
            this.kategoriSec.Location = new System.Drawing.Point(252, 91);
            this.kategoriSec.Name = "kategoriSec";
            this.kategoriSec.Size = new System.Drawing.Size(68, 13);
            this.kategoriSec.TabIndex = 10;
            this.kategoriSec.Text = "Kategori Seç";
            // 
            // UrunleriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.kategoriSec);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.urunler);
            this.Controls.Add(this.urunlerTablosu);
            this.Controls.Add(this.kategorileriGor);
            this.Name = "UrunleriListele";
            this.Text = "UrunleriListele";
            this.Load += new System.EventHandler(this.UrunleriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.urunlerTablosu)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox kategorileriGor;
        private System.Windows.Forms.Label urunler;
        private System.Windows.Forms.DataGridView urunlerTablosu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button urunGuncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox urunDescription;
        private System.Windows.Forms.TextBox urunRating;
        private System.Windows.Forms.TextBox urunPrice;
        private System.Windows.Forms.Button urunSil;
        private System.Windows.Forms.Label kategoriSec;
        private System.Windows.Forms.Label urunSec;
        private System.Windows.Forms.ComboBox urunSecCombo;
        private System.Windows.Forms.TextBox urunName;
    }
}