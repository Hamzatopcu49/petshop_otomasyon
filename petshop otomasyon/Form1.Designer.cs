namespace petshop_otomasyon
{
    partial class FrmGirisEkrani
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisEkrani));
            this.textBoxKullaniciAdi = new System.Windows.Forms.TextBox();
            this.textBoxSifre = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGiris = new DevExpress.XtraEditors.SimpleButton();
            this.labelUyari = new DevExpress.XtraEditors.LabelControl();
            this.hyperlinkLabelControlSifre = new DevExpress.XtraEditors.HyperlinkLabelControl();
            this.SuspendLayout();
            // 
            // textBoxKullaniciAdi
            // 
            this.textBoxKullaniciAdi.Location = new System.Drawing.Point(433, 134);
            this.textBoxKullaniciAdi.Name = "textBoxKullaniciAdi";
            this.textBoxKullaniciAdi.Size = new System.Drawing.Size(152, 22);
            this.textBoxKullaniciAdi.TabIndex = 0;
            // 
            // textBoxSifre
            // 
            this.textBoxSifre.Location = new System.Drawing.Point(433, 222);
            this.textBoxSifre.Name = "textBoxSifre";
            this.textBoxSifre.PasswordChar = '*';
            this.textBoxSifre.Size = new System.Drawing.Size(152, 22);
            this.textBoxSifre.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(294, 133);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(101, 21);
            this.labelControl1.TabIndex = 6;
            this.labelControl1.Text = "Kullanıcı Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(319, 223);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(44, 21);
            this.labelControl2.TabIndex = 7;
            this.labelControl2.Text = "Şifre :";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.ImageOptions.Image = global::petshop_otomasyon.Properties.Resources.close_32x329;
            this.simpleButton1.Location = new System.Drawing.Point(947, 1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(52, 41);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.UseWaitCursor = true;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // simpleButtonGiris
            // 
            this.simpleButtonGiris.Appearance.BorderColor = System.Drawing.Color.Silver;
            this.simpleButtonGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButtonGiris.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButtonGiris.Appearance.Options.UseBorderColor = true;
            this.simpleButtonGiris.Appearance.Options.UseFont = true;
            this.simpleButtonGiris.Appearance.Options.UseForeColor = true;
            this.simpleButtonGiris.ImageOptions.Image = global::petshop_otomasyon.Properties.Resources.bocustomer_32x32;
            this.simpleButtonGiris.Location = new System.Drawing.Point(444, 293);
            this.simpleButtonGiris.Name = "simpleButtonGiris";
            this.simpleButtonGiris.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.simpleButtonGiris.Size = new System.Drawing.Size(141, 49);
            this.simpleButtonGiris.TabIndex = 10;
            this.simpleButtonGiris.Text = "Giriş Yap";
            this.simpleButtonGiris.Click += new System.EventHandler(this.simpleButtonGiris_Click);
            // 
            // labelUyari
            // 
            this.labelUyari.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.labelUyari.Appearance.Options.UseForeColor = true;
            this.labelUyari.Location = new System.Drawing.Point(408, 78);
            this.labelUyari.Name = "labelUyari";
            this.labelUyari.Size = new System.Drawing.Size(0, 16);
            this.labelUyari.TabIndex = 11;
            // 
            // hyperlinkLabelControlSifre
            // 
            this.hyperlinkLabelControlSifre.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hyperlinkLabelControlSifre.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.hyperlinkLabelControlSifre.Appearance.Options.UseFont = true;
            this.hyperlinkLabelControlSifre.Appearance.Options.UseForeColor = true;
            this.hyperlinkLabelControlSifre.Location = new System.Drawing.Point(460, 368);
            this.hyperlinkLabelControlSifre.Name = "hyperlinkLabelControlSifre";
            this.hyperlinkLabelControlSifre.Size = new System.Drawing.Size(105, 18);
            this.hyperlinkLabelControlSifre.TabIndex = 12;
            this.hyperlinkLabelControlSifre.Text = "Şifremi Unuttum";
            this.hyperlinkLabelControlSifre.Click += new System.EventHandler(this.hyperlinkLabelControlSifre_Click);
            // 
            // FrmGirisEkrani
            // 
            this.AcceptButton = this.simpleButtonGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 550);
            this.Controls.Add(this.hyperlinkLabelControlSifre);
            this.Controls.Add(this.labelUyari);
            this.Controls.Add(this.simpleButtonGiris);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.textBoxSifre);
            this.Controls.Add(this.textBoxKullaniciAdi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "FrmGirisEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxKullaniciAdi;
        private System.Windows.Forms.TextBox textBoxSifre;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGiris;
        private DevExpress.XtraEditors.LabelControl labelUyari;
        private DevExpress.XtraEditors.HyperlinkLabelControl hyperlinkLabelControlSifre;
    }
}

