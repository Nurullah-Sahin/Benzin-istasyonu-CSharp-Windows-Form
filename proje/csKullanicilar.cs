using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace proje
{
    class csKullanicilar
    {
        vtBaglanti vt = new vtBaglanti();

        public int KullaniciID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        public string E_posta { get; set; }

        


        public csKullanicilar()
        {

            this.KullaniciID = -1;
            this.Adi = string.Empty;
            this.Soyadi = string.Empty;
            this.KullaniciAdi = string.Empty;
            this.Sifre = string.Empty;
            this.E_posta = string.Empty;
            
            
            
            
        }


        public void KullaniciKaydet()
        {

            vt._Calistir("insert into T_Kullanicilar(Adi,Soyadi,KullaniciAdi,Sifre,E_posta) values ('" + Adi + "','" + Soyadi + "','" + KullaniciAdi + "','" + Sifre + "','" + E_posta + "')");

        }

        public DataTable KullaniciListesi()
        {
            return vt._Liste("select * From T_Kullanicilar");
        }

        

        

        public DataTable Kontrol()
        {
            DataTable dtb = new DataTable();

            dtb = vt._Liste("select * From T_Kullanicilar Where KullaniciAdi= '" + KullaniciAdi + "' and Sifre='" + Sifre + "'");
            return dtb;

        }

        


        
    }
}
