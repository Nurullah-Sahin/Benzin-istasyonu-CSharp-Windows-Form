using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class csYakitlar
    {
        vtBaglanti vt = new vtBaglanti();

        public int YakitID { get; set; }
        public string YakitAdi { get; set; }
        public string YakitKdv { get; set; }
        public int Fiyat { get; set; }


        public void YakitEkle()
        {

            vt._Calistir("insert into T_Yakitlar(YakitAdi,YakitKdv,Fiyat) values (" + YakitAdi + ",'" + YakitKdv + "','" + Fiyat + "')");

        }

        public DataTable YakitListesi()
        {
            return vt._Liste("select * from T_Yakitlar");

        }

        
    }
}
