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
    public partial class frmKullanici : Form
    {
        csKullanicilar kul = new csKullanicilar();
        csAraclar arac = new csAraclar();
        csMarkaModel mm = new csMarkaModel();
        csMusteriler mus = new csMusteriler();
        csYakitlar yak = new csYakitlar();
        csSatis sa = new csSatis();
        public frmKullanici()
        {
            InitializeComponent();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        

        
        


        private void tabControl1_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {

        }

        private void frmKullanici_Load(object sender, EventArgs e)
        {
            Doldur();
            grdDoldur();
            
            
        }
        void Doldur()
        {
            cmbAd.DataSource = mus.MusteriListesi();
            cmbAd.DisplayMember = "AdveSoyad";
            cmbMarka.ValueMember = "MusteriID";

            cmbYakitAdi.DataSource = yak.YakitListesi();
            cmbYakitAdi.DisplayMember = "YakitAdi";


            cmbMarka.DataSource = mm.MarkaListesi();
            cmbModel.DataSource = mm.ModelListesi();
            cmbMarka.DisplayMember = "Marka";
            cmbModel.DisplayMember = "Model";
            cmbMarka.ValueMember = "MarkaID";
            cmbModel.ValueMember = "ModelID";

            cmbYakitDepo.DataSource = yak.YakitListesi();
            cmbYakitDepo.DisplayMember = "YakitAdi";
            cmbYakitDepo.ValueMember = "YakitID";

            cmbYakit.DataSource = yak.YakitListesi();
            cmbYakit.DisplayMember = "YakitAdi";
            cmbYakit.ValueMember = "YakitID";

            cmbMarkaGumc.DataSource = mm.MarkaListesi();
            cmbMarkaGumc.DisplayMember = "Marka";
            cmbMarkaGumc.ValueMember = "MarkaID";

        }

        void grdDoldur()
        {
            dtgKullaniciList.DataSource = kul.KullaniciListesi();
            dtgMusteri.DataSource = mus.Musteriler();
            dtgYakit.DataSource = yak.YakitListesi();
            dtgAracListesi.DataSource = mm.MarkaListesi();
            dtgSatisListesi.DataSource = sa.SatisListesi();
            dtgModel.DataSource = mm.ModelListesi();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void dtgKullaniciList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void rdyNakit_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void rdyKredi_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOturumKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sa.Tarih = Convert.ToString(dtTarih.Value);
            sa.Litre = Convert.ToInt32(nmrLitre.Value);
        }
        
        private void btnIslem_Click(object sender, EventArgs e)
        {
            if (rdyNakit.Checked==true)
            {
                pnlSatis.Enabled = true;
                panel5.Enabled = false;
                panel5.BackColor = Color.Gray;
            }

            if (rdyKredi.Checked==true)
            {
                pnlSatis.Enabled = true;
                panel5.Enabled = true;
                panel5.BackColor = Color.White;
            }
        }


        private void btnIptal_Click(object sender, EventArgs e)
        {
            pnlSatis.Enabled = false;
        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            pnlSatis.Enabled = false;
            panel5.BackColor = Color.Gray;
        }

        private void cmbMarka_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            crcSeçilenYakit.Text = "%" + crcSeçilenYakit.Value.ToString();


            crcTumYakit.Text = "%" + crcTumYakit.Value.ToString();
        }

        private void btnMusteriEkle_Click(object sender, EventArgs e)
        {
            mus.Adi = txtAd.Text;
            mus.Soyadi = txtSoyad.Text;
            mus.TC = txtTC.Text;
            mus.MusteriEkle();
            grdDoldur();
        }

        private void btnMusteriIptal_Click(object sender, EventArgs e)
        {
            txtTC.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
        }

        private void btnYakitEkle_Click(object sender, EventArgs e)
        {
            yak.YakitAdi = txtYakitAdi.Text;
            yak.Fiyat = Convert.ToInt32(txtYakitEkleFiyat.Text);
            yak.YakitKdv = txtYakitEkleKdv.Text;
            yak.YakitEkle();
        }

        private void btnPatronEkle_Click(object sender, EventArgs e)
        {
            Frmkulekle kul = new Frmkulekle();
            kul.Show();
        }

        private void btnYakitGüncelle_Click(object sender, EventArgs e)
        {

        }

        private void btnMarkaKaydet_Click(object sender, EventArgs e)
        {
            mm.Marka = txtMarkaAdi.Text;
            mm.MarkaEkle();
            grdDoldur();
        }

        private void btnModelEkle_Click(object sender, EventArgs e)
        {
            mm.MarkaID = Convert.ToInt32(cmbMarka.SelectedValue);
            mm.Model = txtModelEkle.Text;
            mm.ModelEkle();
            grdDoldur();
        }
       
    }
}
