using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    class csMusteriler:vtBaglanti
    {
        vtBaglanti vt = new vtBaglanti();
        public int MusteriID { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int MusteriPuan { get; set; }
        public string TC { get; set; }



        

        public DataTable MusteriListesi()
        {
            return _Liste("select MusteriID, Adi &' '& Soyadi as AdveSoyad from T_Musteriler");

        }

        public DataTable Musteriler()
        {
            return _Liste("select * From T_Musteriler");
        }
        public void MusteriEkle()
        {
            
            bool gelen = vt.Kontrol("T_Musteriler", "TC", TC);
            if (gelen == false)
            {
                vt._Calistir("insert into T_Musteriler(TC,Adi,Soyadi) values ('" + TC + "','" + Adi + "','" + Soyadi + "')");
            }
            else
            {
                MessageBox.Show(TC + " TC Numarasına Sahip Müşteri Kaydı bulunmaktadır");
            }

         
        }
        private bool Kontrol(string p1, string p2, int TC)
        {
            throw new NotImplementedException();
        }
        
    }
}
