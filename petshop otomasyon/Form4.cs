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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace petshop_otomasyon
{
    public partial class FormHayvanlar : Form
    {
        public FormHayvanlar()
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
            komut = new SqlCommand("select * from Hayvanlar", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["HayvanId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Turu"].ToString());
                ekle.SubItems.Add(dataReader["Cinsi"].ToString());
                ekle.SubItems.Add(dataReader["Bilgileri"].ToString());
                ekle.SubItems.Add(dataReader["KayitTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }
        private void hayvanEkle()
        {
            string adi = textBoxAdi.Text;
            string tur = comboBoxTuru.Text;
            string cins = comboBoxCinsi.Text.Trim();
            string bilgi = textBoxSaat.Text;

            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("insert into Hayvanlar(Adi,Turu,Cinsi,Bilgileri,KayitTarihi ) values ('" + adi + "','" + tur + "','" + cins + "','" + bilgi + "','"+dateTimePicker1.Value.ToString("yyyy/MM/dd")+"')", baglanti);
            komut.ExecuteNonQuery();
            verileriGoster();
            MessageBox.Show("Kayıt Eklendi");
        }
        public void guncelle()
        {
            string adi = textBox6.Text;
            string tur = textBox8.Text;
            string cinsi = textBox5.Text;
            string bilgi = textBox7.Text;
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("update Hayvanlar set Adi='" + adi + "',Turu='" + tur + "',Cinsi='" + cinsi + "',Bilgileri='" + bilgi + "' where HayvanId=" + id + "", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Güncellendi");
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            FormAnaSayfa formAnaSayfa = new FormAnaSayfa();
            this.Hide();
            formAnaSayfa.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            verileriGoster();
        }

        private void simpleButtonEkle_Click(object sender, EventArgs e)
        {
            hayvanEkle();
        }

        private void simpleButtonGoster_DoubleClick(object sender, EventArgs e)
        {
         
        }

        private void simpleButtonSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            komut = new SqlCommand("delete from Hayvanlar where HayvanId=(" + id + ")", baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
            verileriGoster();
            MessageBox.Show("Kayıt Silindi");
        }

        private void simpleBtnTemizle_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            dateTimePicker2.Text = "";
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            textBoxAdi.Clear();
            comboBoxTuru.Text = "";
            comboBoxCinsi.Text = "";
            textBoxSaat.Clear();
            dateTimePicker1.Text = "";
        }

        private void simpleButtonGuncelle_Click(object sender, EventArgs e)
        {
            guncelle();
        }

        int id;
        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            textBox6.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBox8.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBox5.Text = listView1.SelectedItems[0].SubItems[3].Text;
            textBox7.Text = listView1.SelectedItems[0].SubItems[4].Text;
            dateTimePicker2.Text = listView1.SelectedItems[0].SubItems[5].Text;
        }

        private void textBoxArama_TextChanged(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            baglanti = new SqlConnection(baglan.adres);
            baglanti.Open();
            komut = new SqlCommand("select * from Hayvanlar where Turu like '%"+textBoxArama.Text+"%'", baglanti);
            dataReader = komut.ExecuteReader();
            while (dataReader.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = dataReader["HayvanId"].ToString();
                ekle.SubItems.Add(dataReader["Adi"].ToString());
                ekle.SubItems.Add(dataReader["Turu"].ToString());
                ekle.SubItems.Add(dataReader["Cinsi"].ToString());
                ekle.SubItems.Add(dataReader["Bilgileri"].ToString());
                ekle.SubItems.Add(dataReader["KayitTarihi"].ToString());
                listView1.Items.Add(ekle);
            }
            baglanti.Close();
        }

        private void cinsi()
        {
            switch (comboBoxTuru.SelectedIndex)
            {
                case 0:
                    comboBoxCinsi.Items.Clear();
                    comboBoxCinsi.Items.Add("Pitbul");
                    comboBoxCinsi.Items.Add("Kangal");
                    comboBoxCinsi.Items.Add("Şivava");           
                    break;
                case 1:
                    comboBoxCinsi.Items.Clear();
                    comboBoxCinsi.Items.Add("Van Kedisi");
                    comboBoxCinsi.Items.Add("Ankara Kedisi");
                    comboBoxCinsi.Items.Add("Mavi Rus Kedisi");
                    break;
                case 2:
                    comboBoxCinsi.Items.Clear();
                    comboBoxCinsi.Items.Add("Afrika Gri Papağanı");
                    comboBoxCinsi.Items.Add("Pakistan Papağanı");
                    comboBoxCinsi.Items.Add("Cennet Papağanı");
                    break;
                default: break;
            }
        }

        private void comboBoxTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxCinsi.Items.Clear();
            cinsi();
        }
    }
}
