using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;
using static DevExpress.XtraEditors.Mask.MaskSettings;

namespace petshop_otomasyon
{
    public partial class Sifresifirlama : Form
    {
        SqlConnection baglanti = new SqlConnection(baglan.adres);
        SqlCommand cmd = new SqlCommand();
        SqlDataReader dr;
        baglan bgl = new baglan();

        SmtpClient smtp = new SmtpClient();
        MailMessage eposta = new MailMessage();
        
        


        public Sifresifirlama()
        {
            InitializeComponent();
        }

        private void simpleButtonSifre_Click(object sender, EventArgs e)
        {
            string kullanici=textBoxKullaniciAdi.Text;
            string posta=textBoxPosta.Text;

            eposta.From = new MailAddress("denementp@outlook.com");
            baglanti.Open();
            cmd.Connection= baglanti;
            cmd.CommandText = "Select * From TblYoneticiGiris where Kullanici_Adi = '" + kullanici + "' and Kurtarma_Epostasi = '" + posta + "'";
            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                eposta.To.Add(textBoxPosta.Text.ToString());
                eposta.Subject = "Şifre hatırlatma maili ";
                eposta.Body = ("Sayın " + kullanici + " şifreniz " + dr["Sifre"] + " dir").ToString();

                smtp.Credentials = new System.Net.NetworkCredential("denementp@outlook.com", "hamza@49");
                smtp.Port = 587;
                smtp.Host = "smtp.outlook.com";
                smtp.EnableSsl = true;
                smtp.Send(eposta);
                MessageBox.Show("Şifreniz mail hesabınıza gönderildi");
                baglanti.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı sistemde bulunan E-Posta adresiniz ile uyuşmuyor");
                baglanti.Close();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FrmGirisEkrani frm= new FrmGirisEkrani();
            this.Hide();
            frm.Show();
        }
    }
}
