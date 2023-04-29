namespace petshop_otomasyon
{
    partial class FormMalzemeler
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxOzellik = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonEkle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxAdi = new System.Windows.Forms.TextBox();
            this.textBoxFiyat = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.textBoxTuru = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonGoster = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleBtnTemizle = new DevExpress.XtraEditors.SimpleButton();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl12 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButtonSil = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButtonGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.textBoxArama = new System.Windows.Forms.TextBox();
            this.labelArama = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-3, 169);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1276, 415);
            this.listView1.TabIndex = 16;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "No";
            this.columnHeader1.Width = 45;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Adı";
            this.columnHeader2.Width = 140;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Türü";
            this.columnHeader3.Width = 164;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Fiyat";
            this.columnHeader4.Width = 194;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Özellik";
            this.columnHeader5.Width = 595;
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.simpleButton2);
            this.panelControl1.Controls.Add(this.textBoxOzellik);
            this.panelControl1.Controls.Add(this.labelControl6);
            this.panelControl1.Controls.Add(this.simpleButtonEkle);
            this.panelControl1.Controls.Add(this.labelControl5);
            this.panelControl1.Controls.Add(this.textBoxAdi);
            this.panelControl1.Controls.Add(this.textBoxFiyat);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.textBoxTuru);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Location = new System.Drawing.Point(2, 12);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(443, 151);
            this.panelControl1.TabIndex = 18;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(305, 81);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(120, 34);
            this.simpleButton2.TabIndex = 40;
            this.simpleButton2.Text = "Temizle";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // textBoxOzellik
            // 
            this.textBoxOzellik.Location = new System.Drawing.Point(131, 119);
            this.textBoxOzellik.Name = "textBoxOzellik";
            this.textBoxOzellik.Size = new System.Drawing.Size(121, 23);
            this.textBoxOzellik.TabIndex = 32;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 122);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(64, 16);
            this.labelControl6.TabIndex = 31;
            this.labelControl6.Text = "Özellikleri :";
            // 
            // simpleButtonEkle
            // 
            this.simpleButtonEkle.Location = new System.Drawing.Point(305, 23);
            this.simpleButtonEkle.Name = "simpleButtonEkle";
            this.simpleButtonEkle.Size = new System.Drawing.Size(120, 34);
            this.simpleButtonEkle.TabIndex = 13;
            this.simpleButtonEkle.Text = "Ekle";
            this.simpleButtonEkle.Click += new System.EventHandler(this.simpleButtonEkle_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(5, 3);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(121, 16);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "Yeni Malzeme Ekle";
            // 
            // textBoxAdi
            // 
            this.textBoxAdi.Location = new System.Drawing.Point(131, 18);
            this.textBoxAdi.Name = "textBoxAdi";
            this.textBoxAdi.Size = new System.Drawing.Size(121, 23);
            this.textBoxAdi.TabIndex = 8;
            // 
            // textBoxFiyat
            // 
            this.textBoxFiyat.Location = new System.Drawing.Point(131, 87);
            this.textBoxFiyat.Name = "textBoxFiyat";
            this.textBoxFiyat.Size = new System.Drawing.Size(121, 23);
            this.textBoxFiyat.TabIndex = 11;
            this.textBoxFiyat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxFiyat_KeyPress);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(27, 16);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Adı :";
            // 
            // textBoxTuru
            // 
            this.textBoxTuru.Location = new System.Drawing.Point(131, 52);
            this.textBoxTuru.Name = "textBoxTuru";
            this.textBoxTuru.Size = new System.Drawing.Size(121, 23);
            this.textBoxTuru.TabIndex = 10;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 58);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 16);
            this.labelControl2.TabIndex = 5;
            this.labelControl2.Text = "Türü :";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 90);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 16);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Fiyat :";
            // 
            // simpleButtonGoster
            // 
            this.simpleButtonGoster.Location = new System.Drawing.Point(1116, 111);
            this.simpleButtonGoster.Name = "simpleButtonGoster";
            this.simpleButtonGoster.Size = new System.Drawing.Size(142, 52);
            this.simpleButtonGoster.TabIndex = 19;
            this.simpleButtonGoster.Text = "Malzemeleri Göster";
            this.simpleButtonGoster.Click += new System.EventHandler(this.simpleButtonGoster_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.simpleBtnTemizle);
            this.panelControl2.Controls.Add(this.textBox5);
            this.panelControl2.Controls.Add(this.textBox6);
            this.panelControl2.Controls.Add(this.textBox7);
            this.panelControl2.Controls.Add(this.labelControl9);
            this.panelControl2.Controls.Add(this.textBox8);
            this.panelControl2.Controls.Add(this.labelControl10);
            this.panelControl2.Controls.Add(this.labelControl11);
            this.panelControl2.Controls.Add(this.labelControl12);
            this.panelControl2.Controls.Add(this.simpleButtonSil);
            this.panelControl2.Controls.Add(this.simpleButtonGuncelle);
            this.panelControl2.Controls.Add(this.labelControl7);
            this.panelControl2.Location = new System.Drawing.Point(461, 12);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(488, 151);
            this.panelControl2.TabIndex = 20;
            // 
            // simpleBtnTemizle
            // 
            this.simpleBtnTemizle.Location = new System.Drawing.Point(326, 113);
            this.simpleBtnTemizle.Name = "simpleBtnTemizle";
            this.simpleBtnTemizle.Size = new System.Drawing.Size(129, 34);
            this.simpleBtnTemizle.TabIndex = 39;
            this.simpleBtnTemizle.Text = "Temizle";
            this.simpleBtnTemizle.Click += new System.EventHandler(this.simpleBtnTemizle_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(152, 90);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(121, 23);
            this.textBox5.TabIndex = 38;
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(152, 23);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(121, 23);
            this.textBox6.TabIndex = 35;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(152, 123);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(121, 23);
            this.textBox7.TabIndex = 37;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(26, 30);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(27, 16);
            this.labelControl9.TabIndex = 31;
            this.labelControl9.Text = "Adı :";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(152, 58);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(121, 23);
            this.textBox8.TabIndex = 36;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(26, 64);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(36, 16);
            this.labelControl10.TabIndex = 32;
            this.labelControl10.Text = "Türü :";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(26, 97);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(36, 16);
            this.labelControl11.TabIndex = 33;
            this.labelControl11.Text = "Fiyat :";
            // 
            // labelControl12
            // 
            this.labelControl12.Location = new System.Drawing.Point(26, 130);
            this.labelControl12.Name = "labelControl12";
            this.labelControl12.Size = new System.Drawing.Size(64, 16);
            this.labelControl12.TabIndex = 34;
            this.labelControl12.Text = "Özellikleri :";
            // 
            // simpleButtonSil
            // 
            this.simpleButtonSil.Location = new System.Drawing.Point(326, 64);
            this.simpleButtonSil.Name = "simpleButtonSil";
            this.simpleButtonSil.Size = new System.Drawing.Size(129, 34);
            this.simpleButtonSil.TabIndex = 29;
            this.simpleButtonSil.Text = "Sil";
            this.simpleButtonSil.Click += new System.EventHandler(this.simpleButtonSil_Click);
            // 
            // simpleButtonGuncelle
            // 
            this.simpleButtonGuncelle.Location = new System.Drawing.Point(326, 18);
            this.simpleButtonGuncelle.Name = "simpleButtonGuncelle";
            this.simpleButtonGuncelle.Size = new System.Drawing.Size(129, 34);
            this.simpleButtonGuncelle.TabIndex = 25;
            this.simpleButtonGuncelle.Text = "Güncelle";
            this.simpleButtonGuncelle.Click += new System.EventHandler(this.simpleButtonGuncelle_Click);
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(26, 5);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(114, 16);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Malzeme Düzenle";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = global::petshop_otomasyon.Properties.Resources.home_32x32;
            this.simpleButton1.Location = new System.Drawing.Point(1219, -1);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.simpleButton1.Size = new System.Drawing.Size(54, 42);
            this.simpleButton1.TabIndex = 17;
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // textBoxArama
            // 
            this.textBoxArama.Location = new System.Drawing.Point(1091, 64);
            this.textBoxArama.Name = "textBoxArama";
            this.textBoxArama.Size = new System.Drawing.Size(169, 22);
            this.textBoxArama.TabIndex = 24;
            this.textBoxArama.TextChanged += new System.EventHandler(this.textBoxArama_TextChanged);
            // 
            // labelArama
            // 
            this.labelArama.AutoSize = true;
            this.labelArama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelArama.Location = new System.Drawing.Point(955, 67);
            this.labelArama.Name = "labelArama";
            this.labelArama.Size = new System.Drawing.Size(118, 20);
            this.labelArama.TabIndex = 23;
            this.labelArama.Text = "Malzeme Ara :";
            // 
            // FormMalzemeler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 581);
            this.Controls.Add(this.textBoxArama);
            this.Controls.Add(this.labelArama);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.simpleButtonGoster);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMalzemeler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.TextBox textBoxOzellik;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton simpleButtonEkle;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.TextBox textBoxAdi;
        private System.Windows.Forms.TextBox textBoxFiyat;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.TextBox textBoxTuru;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGoster;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private System.Windows.Forms.TextBox textBox8;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl12;
        private DevExpress.XtraEditors.SimpleButton simpleButtonSil;
        private DevExpress.XtraEditors.SimpleButton simpleButtonGuncelle;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.SimpleButton simpleBtnTemizle;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox textBoxArama;
        private System.Windows.Forms.Label labelArama;
    }
}