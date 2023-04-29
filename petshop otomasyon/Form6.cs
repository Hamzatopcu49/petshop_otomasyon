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
using System.Drawing.Text;

namespace petshop_otomasyon
{
    public partial class FrmMali : Form
    {
        public FrmMali()
        {
            InitializeComponent();
        }
        SqlConnection baglanti=new SqlConnection(baglan.adres);
        SqlCommand komut;
        SqlDataReader dr;

        private void simpleButtonAnaSayfa_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            this.Hide();
            formAnaSayfa.Show();
        }

        int gelir, gider;
        private void GiderTablosu()
        {
            gider = 0;
            baglanti.Open();
            komut = new SqlCommand("Select GiderAdi , Miktar From Giderler", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartGider.Series["TL"].Points.AddXY(Convert.ToString(dr[0]) , int.Parse(dr[1].ToString()));
                gider = gider + int.Parse(dr[1].ToString());
            }
            baglanti.Close();
        }
        
        private void GelirTablosu()
        {
            gelir = 0;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select GelirAdi , Miktar From Gelir", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                chartGelir.Series["TL"].Points.AddXY(Convert.ToString(dr[0]) , int.Parse(dr[1].ToString()));
                gelir = gelir + int.Parse(dr[1].ToString());
            }
            baglanti.Close();
        }

        private void FrmMali_Load(object sender, EventArgs e)
        {
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void simpleButtonGelirEkle_Click(object sender, EventArgs e)
        {
            string str;
            int miktar, girilenMiktar;
            girilenMiktar = Convert.ToInt32(textBoxGelirMiktari.Text);

            baglanti.Open();

            switch (comboBoxGelir.SelectedIndex)
            {
                case 0 :
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Hayvan Sahiplendirme'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut=new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Hayvan Sahiplendirme'",baglanti);
                    dr= komut.ExecuteReader();
                    break;

                case 1:
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Malzeme Satısı'", baglanti);
                    str=komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Malzeme Satısı'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                case 2:
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Diger'", baglanti);
                    str=komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Diger'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                default:MessageBox.Show("Lütfen seçim yapınız !!!"); break;
            }
            baglanti.Close();
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void simpleButtonGiderEkle_Click(object sender, EventArgs e)
        {
            string str;
            int miktar, girilenMiktar;
            girilenMiktar = Convert.ToInt32(textBoxGiderMiktari.Text);

            baglanti.Open();

            switch (comboBoxGider.SelectedIndex)
            {
                case 0:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Yem Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Yem Alımı'", baglanti);
                    dr = komut.ExecuteReader();
                    break;

                case 1:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Personel Maas'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Personel Maas'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                case 2:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Malzeme Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Malzeme Alımı'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                case 3:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Hayvan Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Hayvan Alımı'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                case 4:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Faturalar'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Faturalar'", baglanti);
                    dr = komut.ExecuteReader();
                    break;

                case 5:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Diger'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    miktar = Convert.ToInt32(str) + girilenMiktar;
                    komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Diger'", baglanti);
                    dr = komut.ExecuteReader();
                    break;
                default: MessageBox.Show("Lütfen seçim yapınız !!!"); break;
            }
            baglanti.Close();
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void simpleButtonGelirCıkar_Click(object sender, EventArgs e)
        {
            string str;
            int miktar, girilenMiktar;
            girilenMiktar = Convert.ToInt32(textBoxGelirMiktari.Text);

            baglanti.Open();

            switch (comboBoxGelir.SelectedIndex)
            {
                case 0:
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Hayvan Sahiplendirme'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Hayvan Sahiplendirme'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gelir eksiye düşemez!!!"); }break;

                case 1:
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Malzeme Satısı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Malzeme Satısı'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gelir eksiye düşemez!!!"); }break;
                case 2:
                    komut = new SqlCommand("select Miktar from Gelir where GelirAdi ='Diger'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Gelir set Miktar='" + miktar + "' where GelirAdi='Diger'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gelir eksiye düşemez!!!"); }  break;

                default: MessageBox.Show("Lütfen seçim yapınız !!!"); break;
            }
            baglanti.Close();
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void simpleButtonGiderCıkar_Click(object sender, EventArgs e)
        {
            string str;
            int miktar, girilenMiktar;
            girilenMiktar = Convert.ToInt32(textBoxGiderMiktari.Text);

            baglanti.Open();

            switch (comboBoxGider.SelectedIndex)
            {
                case 0:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Yem Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Yem Alımı'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;

                case 1:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Personel Maas'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Personel Maas'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;
                case 2:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Malzeme Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Malzeme Alımı'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;
                case 3:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Hayvan Alımı'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Hayvan Alımı'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;
                case 4:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Faturalar'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Faturalar'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;

                case 5:
                    komut = new SqlCommand("select Miktar from Giderler where GiderAdi ='Diger'", baglanti);
                    str = komut.ExecuteScalar().ToString();
                    if (Convert.ToInt32(str) >= girilenMiktar)
                    {
                        miktar = Convert.ToInt32(str) - girilenMiktar;
                        komut = new SqlCommand("update Giderler set Miktar='" + miktar + "' where GiderAdi='Diger'", baglanti);
                        dr = komut.ExecuteReader();
                    }
                    else { MessageBox.Show("Gider eksiye düşemez!!!"); }
                    break;
                default: MessageBox.Show("Lütfen seçim yapınız !!!"); break;
            }
            baglanti.Close();
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void textBoxGelirMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void textBoxGiderMiktari_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void simpleButtonSıfırla_Click(object sender, EventArgs e)
        {
            gelir = 0; gider = 0;
            baglanti = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=PetshopDB;Integrated Security=True");
            baglanti.Open();
            komut = new SqlCommand("update Gelir set Miktar='" + 0 + "'", baglanti);
            komut.ExecuteNonQuery();
            SqlCommand komut2;
            komut2 = new SqlCommand("update Giderler set Miktar='" + 0 + "'", baglanti);
            komut2.ExecuteNonQuery();
            baglanti.Close();
            GelirTablosu();
            GiderTablosu();
            Ciro();
        }

        private void chartGelir_Click(object sender, EventArgs e)
        {

        }

        private void chartGider_Click(object sender, EventArgs e)
        {

        }

        private void Ciro()
        {
            GelirTablosu();
            GiderTablosu();
            int ciro = gelir - gider;
            labelControlCiro.Text = ciro.ToString();
        }

    }
}
