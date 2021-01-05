namespace OOP_Giris_Proje_1
{
    partial class Prsnl_Form
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
            this.btnPrimGunu = new System.Windows.Forms.Button();
            this.btnKidem = new System.Windows.Forms.Button();
            this.btnKov = new System.Windows.Forms.Button();
            this.lstListe = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnPrimGunu
            // 
            this.btnPrimGunu.Location = new System.Drawing.Point(239, 114);
            this.btnPrimGunu.Name = "btnPrimGunu";
            this.btnPrimGunu.Size = new System.Drawing.Size(98, 23);
            this.btnPrimGunu.TabIndex = 7;
            this.btnPrimGunu.Text = "Prim Günü";
            this.btnPrimGunu.UseVisualStyleBackColor = true;
            // 
            // btnKidem
            // 
            this.btnKidem.Location = new System.Drawing.Point(239, 64);
            this.btnKidem.Name = "btnKidem";
            this.btnKidem.Size = new System.Drawing.Size(98, 23);
            this.btnKidem.TabIndex = 6;
            this.btnKidem.Text = "Kıdem";
            this.btnKidem.UseVisualStyleBackColor = true;
            // 
            // btnKov
            // 
            this.btnKov.Location = new System.Drawing.Point(239, 12);
            this.btnKov.Name = "btnKov";
            this.btnKov.Size = new System.Drawing.Size(98, 23);
            this.btnKov.TabIndex = 5;
            this.btnKov.Text = "Kov";
            this.btnKov.UseVisualStyleBackColor = true;
            this.btnKov.Click += new System.EventHandler(this.btnKov_Click);
            // 
            // lstListe
            // 
            this.lstListe.FormattingEnabled = true;
            this.lstListe.ItemHeight = 16;
            this.lstListe.Location = new System.Drawing.Point(12, 12);
            this.lstListe.Name = "lstListe";
            this.lstListe.Size = new System.Drawing.Size(221, 452);
            this.lstListe.TabIndex = 4;
            // 
            // Prsnl_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 501);
            this.Controls.Add(this.btnPrimGunu);
            this.Controls.Add(this.btnKidem);
            this.Controls.Add(this.btnKov);
            this.Controls.Add(this.lstListe);
            this.Name = "Prsnl_Form";
            this.Text = "Prsnl_Form";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Prsnl_Form_FormClosed);
            this.Load += new System.EventHandler(this.Prsnl_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrimGunu;
        private System.Windows.Forms.Button btnKidem;
        private System.Windows.Forms.Button btnKov;
        private System.Windows.Forms.ListBox lstListe;
    }
}