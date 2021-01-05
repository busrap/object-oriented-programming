namespace OOP_Giris_Proje_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.txtSicilNo = new System.Windows.Forms.TextBox();
            this.nmrMaas = new System.Windows.Forms.NumericUpDown();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtTckn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtIseGirisTarihi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adi:";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(123, 29);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.Size = new System.Drawing.Size(146, 22);
            this.txtAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Soyadi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "SicilNo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(71, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Maaş:";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(123, 64);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.Size = new System.Drawing.Size(146, 22);
            this.txtSoyadi.TabIndex = 1;
            // 
            // txtSicilNo
            // 
            this.txtSicilNo.Location = new System.Drawing.Point(123, 169);
            this.txtSicilNo.Name = "txtSicilNo";
            this.txtSicilNo.Size = new System.Drawing.Size(146, 22);
            this.txtSicilNo.TabIndex = 3;
            // 
            // nmrMaas
            // 
            this.nmrMaas.Location = new System.Drawing.Point(123, 204);
            this.nmrMaas.Name = "nmrMaas";
            this.nmrMaas.Size = new System.Drawing.Size(146, 22);
            this.nmrMaas.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(123, 233);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(146, 37);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtTckn
            // 
            this.txtTckn.Location = new System.Drawing.Point(123, 99);
            this.txtTckn.Name = "txtTckn";
            this.txtTckn.Size = new System.Drawing.Size(146, 22);
            this.txtTckn.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "TCKN: ";
            // 
            // txtIseGirisTarihi
            // 
            this.txtIseGirisTarihi.Location = new System.Drawing.Point(123, 134);
            this.txtIseGirisTarihi.Name = "txtIseGirisTarihi";
            this.txtIseGirisTarihi.Size = new System.Drawing.Size(146, 22);
            this.txtIseGirisTarihi.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 136);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "İşe Giriş Tarihi: ";
            // 
            // Form1
            // 
            this.AcceptButton = this.btnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 312);
            this.Controls.Add(this.txtIseGirisTarihi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTckn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.nmrMaas);
            this.Controls.Add(this.txtSicilNo);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrMaas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.TextBox txtSicilNo;
        private System.Windows.Forms.NumericUpDown nmrMaas;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtTckn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtIseGirisTarihi;
        private System.Windows.Forms.Label label6;
    }
}

