using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petshop_otomasyon
{
    public partial class FormMalzemeler : Form
    {
        public FormMalzemeler()
        {
            InitializeComponent();
        }
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dataReader;
        baglan bgl = new baglan();
        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("select * from Malzemeler", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["MalzemeId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Turu"].ToString());
                ekle.SubItems.Add(dataReader["Fiyat"].ToString()+" TL");
                ekle.SubItems.Add(dataReader["Ozellik"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void malzemeEkle()
        {
            string adi = textBoxAdi.Text;
            string tur = textBoxTuru.Text;
            string fiyat = textBoxFiyat.Text;
            string ozellik=textBoxOzellik.Text;


            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("insert into Malzemeler(Adi,Turu,Fiyat,Ozellik) values ('" + adi + "','" + tur + "','" + fiyat + "','" + ozellik + "')", baglanti);
            komut.ExecuteNonQuery();
            verileriGoster();
            MessageBox.Show("Malzeme Eklendi");
        }

        public void guncelle()
        {
            string adi = textBox6.Text;
            string tur = textBox8.Text;
            int fiyat = Convert.ToInt32(textBox5.Text);
            string ozellik = textBox7.Text;
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("update Malzemeler set Adi='" + adi + "',Turu='" + tur + "',Fiyat='" + fiyat + "',Ozellik='" + ozellik + "' where MalzemeId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Güncelleme Başarılı");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            this.Hide();
            formAnaSayfa.Show();
        }

        private void simpleButtonGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void simpleButtonEkle_Click(object sender, EventArgs e)
        {
            malzemeEkle();
        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Malzemeler where MalzemeId=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Silindi");
        }

        private void simpleBtnTemizle_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            textBoxAdi.Clear();
            textBoxFiyat.Clear();
            textBoxOzellik.Clear();
            textBoxTuru.Clear();
        }

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        private void textBoxFiyat_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
      
        int id;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[4].Text;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("select * from Malzemeler where Adi like '%"+textBoxArama.Text+"%'", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["MalzemeId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Turu"].ToString());
                ekle.SubItems.Add(dataReader["Fiyat"].ToString() + " TL");
                ekle.SubItems.Add(dataReader["Ozellik"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}
