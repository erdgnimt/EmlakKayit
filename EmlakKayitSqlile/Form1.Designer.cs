
namespace EmlakKayitSqlile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtKullanici = new System.Windows.Forms.TextBox();
            this.txtKullaniciSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.bttnKullaniciGiris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.Location = new System.Drawing.Point(9, 17);
            this.lblKullanici.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(80, 20);
            this.lblKullanici.TabIndex = 0;
            this.lblKullanici.Text = "Kullanıcı:";
            this.lblKullanici.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txtKullanici
            // 
            this.txtKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullanici.Location = new System.Drawing.Point(96, 16);
            this.txtKullanici.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKullanici.Name = "txtKullanici";
            this.txtKullanici.Size = new System.Drawing.Size(106, 23);
            this.txtKullanici.TabIndex = 1;
            // 
            // txtKullaniciSifre
            // 
            this.txtKullaniciSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciSifre.Location = new System.Drawing.Point(96, 61);
            this.txtKullaniciSifre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKullaniciSifre.Name = "txtKullaniciSifre";
            this.txtKullaniciSifre.Size = new System.Drawing.Size(106, 23);
            this.txtKullaniciSifre.TabIndex = 2;
            this.txtKullaniciSifre.UseSystemPasswordChar = true;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSifre.Location = new System.Drawing.Point(37, 62);
            this.lblSifre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(52, 20);
            this.lblSifre.TabIndex = 2;
            this.lblSifre.Text = "Şifre:";
            this.lblSifre.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // bttnKullaniciGiris
            // 
            this.bttnKullaniciGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bttnKullaniciGiris.Location = new System.Drawing.Point(96, 87);
            this.bttnKullaniciGiris.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bttnKullaniciGiris.Name = "bttnKullaniciGiris";
            this.bttnKullaniciGiris.Size = new System.Drawing.Size(105, 28);
            this.bttnKullaniciGiris.TabIndex = 3;
            this.bttnKullaniciGiris.Text = "GİRİŞ";
            this.bttnKullaniciGiris.UseVisualStyleBackColor = true;
            this.bttnKullaniciGiris.Click += new System.EventHandler(this.bttnKullaniciGiris_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(286, 134);
            this.Controls.Add(this.bttnKullaniciGiris);
            this.Controls.Add(this.txtKullaniciSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullanici);
            this.Controls.Add(this.lblKullanici);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Yönetici Giriş";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtKullanici;
        private System.Windows.Forms.TextBox txtKullaniciSifre;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.Button bttnKullaniciGiris;
    }
}

