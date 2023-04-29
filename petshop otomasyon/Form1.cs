using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using System.Data.Sql;

namespace petshop_otomasyon
{
    public partial class FrmGirisEkrani : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dataReader;
        baglan bgl = new baglan();

        public FrmGirisEkrani()
        {
            InitializeComponent();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButtonGiris_Click(object sender, EventArgs e)
       {
            string user = textBoxKullaniciAdi.Text;
            string password = textBoxSifre.Text;

            baglanti = new SqlConnection(baglan.adres);
            komut = new SqlCommand();
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = "Select * From TblYoneticiGiris where Kullanici_Adi ='" + user +
                                                                    "'And Sifre='" + password + "'";
            dataReader = komut.ExecuteReader();
            if (dataReader.Read())
            {
                FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
                this.Hide();
                formAnaSayfa.Show();
            }
            else
            {
                labelUyari.Text = "Yanlış Kullanıcı Adı Veya Şifre";
            }
            baglanti.Close();
        }

        private void hyperlinkLabelControlSifre_Click(object sender, EventArgs e)
        {
            Sifresifirlama sifre = new Sifresifirlama();
            sifre.ShowDialog();
        }
    }
}

