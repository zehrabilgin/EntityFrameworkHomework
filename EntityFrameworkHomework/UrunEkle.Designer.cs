
namespace EntityFrameworkHomework
{
    partial class UrunEkle
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
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.urunDescription = new System.Windows.Forms.TextBox();
            this.urunRating = new System.Windows.Forms.TextBox();
            this.urunPrice = new System.Windows.Forms.TextBox();
            this.urunName = new System.Windows.Forms.TextBox();
            this.urunleriListele = new System.Windows.Forms.Button();
            this.urunEkle1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.vendorcomboBox = new System.Windows.Forms.ComboBox();
            this.vendor = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vendorcomboBox);
            this.groupBox1.Controls.Add(this.vendor);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.urunEkle1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.urunDescription);
            this.groupBox1.Controls.Add(this.urunRating);
            this.groupBox1.Controls.Add(this.urunPrice);
            this.groupBox1.Controls.Add(this.urunName);
            this.groupBox1.Location = new System.Drawing.Point(48, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 322);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürün Ekle";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(61, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Description";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Rating";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name";
            // 
            // urunDescription
            // 
            this.urunDescription.Location = new System.Drawing.Point(123, 174);
            this.urunDescription.Name = "urunDescription";
            this.urunDescription.Size = new System.Drawing.Size(130, 20);
            this.urunDescription.TabIndex = 5;
            // 
            // urunRating
            // 
            this.urunRating.Location = new System.Drawing.Point(123, 135);
            this.urunRating.Name = "urunRating";
            this.urunRating.Size = new System.Drawing.Size(130, 20);
            this.urunRating.TabIndex = 4;
            // 
            // urunPrice
            // 
            this.urunPrice.Location = new System.Drawing.Point(123, 98);
            this.urunPrice.Name = "urunPrice";
            this.urunPrice.Size = new System.Drawing.Size(130, 20);
            this.urunPrice.TabIndex = 3;
            // 
            // urunName
            // 
            this.urunName.Location = new System.Drawing.Point(123, 61);
            this.urunName.Name = "urunName";
            this.urunName.Size = new System.Drawing.Size(130, 20);
            this.urunName.TabIndex = 1;
            // 
            // urunleriListele
            // 
            this.urunleriListele.Location = new System.Drawing.Point(150, 361);
            this.urunleriListele.Name = "urunleriListele";
            this.urunleriListele.Size = new System.Drawing.Size(103, 26);
            this.urunleriListele.TabIndex = 3;
            this.urunleriListele.Text = "Ürünleri Listele";
            this.urunleriListele.UseVisualStyleBackColor = true;
            this.urunleriListele.Click += new System.EventHandler(this.urunleriListele_Click);
            // 
            // urunEkle1
            // 
            this.urunEkle1.Location = new System.Drawing.Point(111, 284);
            this.urunEkle1.Name = "urunEkle1";
            this.urunEkle1.Size = new System.Drawing.Size(75, 23);
            this.urunEkle1.TabIndex = 12;
            this.urunEkle1.Text = "Ürün Ekle";
            this.urunEkle1.UseVisualStyleBackColor = true;
            this.urunEkle1.Click += new System.EventHandler(this.urunEkle1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(123, 213);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 13;
            // 
            // vendorcomboBox
            // 
            this.vendorcomboBox.FormattingEnabled = true;
            this.vendorcomboBox.Location = new System.Drawing.Point(123, 248);
            this.vendorcomboBox.Name = "vendorcomboBox";
            this.vendorcomboBox.Size = new System.Drawing.Size(130, 21);
            this.vendorcomboBox.TabIndex = 15;
            // 
            // vendor
            // 
            this.vendor.AutoSize = true;
            this.vendor.Location = new System.Drawing.Point(61, 251);
            this.vendor.Name = "vendor";
            this.vendor.Size = new System.Drawing.Size(41, 13);
            this.vendor.TabIndex = 14;
            this.vendor.Text = "Vendor";
            // 
            // UrunEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 450);
            this.Controls.Add(this.urunleriListele);
            this.Controls.Add(this.groupBox1);
            this.Name = "UrunEkle";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.UrunEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox urunDescription;
        private System.Windows.Forms.TextBox urunRating;
        private System.Windows.Forms.TextBox urunPrice;
        private System.Windows.Forms.TextBox urunName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button urunleriListele;
        private System.Windows.Forms.Button urunEkle1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox vendorcomboBox;
        private System.Windows.Forms.Label vendor;
    }
}