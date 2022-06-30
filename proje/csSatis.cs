using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class csSatis
    {
        vtBaglanti vt = new vtBaglanti();

        public int SatisID { get; set; }
        public string Tarih { get; set; }
        public int Litre { get; set; }
        public int Tutar { get; set; }
        public int TYakitID { get; set; }
        public int MusteriID { get; set; }


        public void SatisEkle()
        {

            

        }

        public DataTable SatisListesi()
        {
            return vt._Liste("select * from T_Satis");

        }
    }
}
