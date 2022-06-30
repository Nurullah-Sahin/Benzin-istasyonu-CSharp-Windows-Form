using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class csSatislar
    {
        vtBaglanti vt = new vtBaglanti();

        
        
        public int Litre { get; set; }
        public int Tutar { get; set;}
        public int YakitID { get; set; }
        public int MusteriID { get; set; }


        public csSatislar()
        {
                        
            this.Litre = 0;
            this.Tutar = 0;
            this.YakitID = 1;
            this.MusteriID = 1;
        }


        public void Satis()
        {

            vt._Calistir("insert into T_Satis(Litre,Tutar,YakitID,MusteriID) values ('" + Litre + "','" + Tutar + "','" + YakitID + "','" + MusteriID + "')");

        }
    }
}
