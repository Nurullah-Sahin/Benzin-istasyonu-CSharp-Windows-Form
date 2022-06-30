using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace proje
{
    public partial class frmGiris : Form
    {
        csKullanicilar kul = new csKullanicilar();
        public static string KullaniciBilgiler;
        

        

        private void frmGiris_Load(object sender, EventArgs e)
        {
            
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            kul.KullaniciAdi = txtKulGirAdmin.Text;
            kul.Sifre = txtKulGirSifre.Text;
            DataTable dtb = new DataTable();
            dtb = null;
            dtb = kul.Kontrol();
            if (dtb.Rows.Count >= 1)
            {
                KullaniciBilgiler = dtb.Rows[0][0].ToString() + "@" + dtb.Rows[0][1].ToString() + " " + dtb.Rows[0][2].ToString() + "@" + DateTime.Now;

                frmKullanici fre = new frmKullanici();
                fre.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }
        }

        private void lnklblKulOlustur_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            Frmkulekle frk = new Frmkulekle();
            frk.Show();
            
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            txtKulGirAdmin.Text = "";
            txtKulGirSifre.Text = "";
        }
    }
}
