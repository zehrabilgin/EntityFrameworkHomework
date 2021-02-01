
namespace EntityFrameworkHomework
{
    partial class GirisEkrani
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
            this.label1 = new System.Windows.Forms.Label();
            this.urunler = new System.Windows.Forms.Button();
            this.uEkle = new System.Windows.Forms.Button();
            this.kEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(106, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mini Shop\'a Hoşgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // urunler
            // 
            this.urunler.Location = new System.Drawing.Point(62, 169);
            this.urunler.Name = "urunler";
            this.urunler.Size = new System.Drawing.Size(75, 41);
            this.urunler.TabIndex = 1;
            this.urunler.Text = "Ürünleri Listele";
            this.urunler.UseVisualStyleBackColor = true;
            this.urunler.Click += new System.EventHandler(this.urunler_Click);
            // 
            // uEkle
            // 
            this.uEkle.Location = new System.Drawing.Point(181, 169);
            this.uEkle.Name = "uEkle";
            this.uEkle.Size = new System.Drawing.Size(69, 41);
            this.uEkle.TabIndex = 2;
            this.uEkle.Text = "Ürün Ekle";
            this.uEkle.UseVisualStyleBackColor = true;
            this.uEkle.Click += new System.EventHandler(this.uEkle_Click);
            // 
            // kEkle
            // 
            this.kEkle.Location = new System.Drawing.Point(294, 169);
            this.kEkle.Name = "kEkle";
            this.kEkle.Size = new System.Drawing.Size(75, 41);
            this.kEkle.TabIndex = 3;
            this.kEkle.Text = "Kategori Ekle";
            this.kEkle.UseVisualStyleBackColor = true;
            this.kEkle.Click += new System.EventHandler(this.kEkle_Click);
            // 
            // GirisEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 334);
            this.Controls.Add(this.kEkle);
            this.Controls.Add(this.uEkle);
            this.Controls.Add(this.urunler);
            this.Controls.Add(this.label1);
            this.Name = "GirisEkrani";
            this.Text = "GirisEkrani";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button urunler;
        private System.Windows.Forms.Button uEkle;
        private System.Windows.Forms.Button kEkle;
    }
}