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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using DevExpress.XtraEditors.Filtering.Templates;

namespace petshop_otomasyon
{
    public partial class FormMusteri : Form
    {
        SqlConnection baglanti;
        SqlCommand komut;
        SqlDataReader dataReader;
        baglan bgl = new baglan();
        public FormMusteri()
        {
            InitializeComponent();
        }

        private void verileriGoster()
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("select * from MusteriBilgileri", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["MusteriId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Soyadi"].ToString());
                ekle.SubItems.Add(dataReader["TelefonNumarasi"].ToString());
                ekle.SubItems.Add(dataReader["YaptigiIslemler"].ToString());
                ekle.SubItems.Add(dataReader["KayitTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void musteriEkle() {
            string adi = textBox1.Text;
            string soyad=textBox3.Text;
            string telefon=maskedTextBox1.Text;
            string islem=textBox4.Text;
    
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("insert into MusteriBilgileri(Adi,Soyadi,TelefonNumarasi,YaptigiIslemler,KayitTarihi) values('"+adi+ "','"+soyad+ "','"+telefon+ "','"+islem+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd")+"')",baglanti);
            komut.ExecuteNonQuery();
            verileriGoster();
            MessageBox.Show("Kayıt Eklendi");
        }

        public void guncelle()
        {
            string adi = textBox2.Text;
            string soyad = textBox6.Text;
            string telefon = maskedTextBox2.Text;
            string islem = textBox5.Text;
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("update MusteriBilgileri set Adi='" + adi + "',Soyadi='" + soyad + "',TelefonNumarasi='" + telefon + "',YaptigiIslemler='" + islem + "' where MusteriId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Güncellendi");
        } 
        private void simpleButtonGoster_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void simpleButtonEkle_Click(object sender, EventArgs e)
        {
            musteriEkle();
        }

        private void simpleButtonAnaSayfa_Click_1(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            this.Hide();
            formAnaSayfa.Show();
        }
        
        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from MusteriBilgileri where MusteriId=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void simpleButtonTemizle_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox3.Clear();
            textBox4.Clear();
            maskedTextBox1.Clear();
            dateTimePicker1.Text = "";
        }

        private void simpleButtonGucelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        int id;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox6.Text = listView1.SelectedItems[0].SubItems[2].Text;
            maskedTextBox2.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void simpleButtonTemizle1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox6.Clear();
            textBox5.Clear();
            maskedTextBox2.Clear();
            dateTimePicker2.Text = "";
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("select * from MusteriBilgileri where Adi like '%" + textBoxArama.Text + "%'", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["MusteriId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Soyadi"].ToString());
                ekle.SubItems.Add(dataReader["TelefonNumarasi"].ToString());
                ekle.SubItems.Add(dataReader["YaptigiIslemler"].ToString());
                ekle.SubItems.Add(dataReader["KayitTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
    }
}

