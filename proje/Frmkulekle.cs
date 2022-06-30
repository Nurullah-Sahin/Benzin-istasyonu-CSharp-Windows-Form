using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    public partial class Frmkulekle : Form
    {
        public Frmkulekle()
        {
            InitializeComponent();
        }
        csKullanicilar kul = new csKullanicilar();
        private void btnEkle_Click(object sender, EventArgs e)
        {
            kul.Adi = txtKulEkleAd.Text;
            kul.Soyadi = txtKulEkleSoyad.Text;
            kul.KullaniciAdi = txtKulEkleAdmin.Text;
            kul.Sifre = txtKulEkleSifre.Text;
            kul.E_posta = txtKulEkleEposta.Text;
            kul.KullaniciKaydet();

            MessageBox.Show("KULLANICI KAYDEDİLDİ\n AD: " + kul.Adi + "\nSOYAD: " + kul.Soyadi + "\nKULLANICI ADI: " + kul.KullaniciAdi);
        }

        private void txtiptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
