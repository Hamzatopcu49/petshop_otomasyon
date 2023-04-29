using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace petshop_otomasyon
{
    public partial class FormAnaSayfa : Form
    {
        public FormAnaSayfa()
        {
            InitializeComponent();
        }
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            FormMusteri formMusteri = new FormMusteri();
            this.Hide();
            formMusteri.Show();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            FormHayvanlar formHayvanlar = new FormHayvanlar();
            this.Hide();
            formHayvanlar.Show();
            
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            FormMalzemeler formMalzemeler = new FormMalzemeler();
            this.Hide();
            formMalzemeler.Show();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            FrmMali frmMali = new FrmMali();
            this.Hide();
            frmMali.Show();
        }

    }
}
