using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proje
{
    class csAraclar:vtBaglanti
    {
        public string Plaka { get; set; }
        public int ModelID { get; set; }
        public int MusteriID { get; set; }
        public int AracID { get; set; }




        public void AracEkle()
        {

            _Calistir("insert into T_Araclar(Plaka,MusteriID,ModelID) values ('" + Plaka + "'," + MusteriID + "," + ModelID + ")");

        }
        public DataTable AracListesi()
        {

            return _Liste("select AracID, Plaka, MusteriID, Model from T_Araclar as a left join T_Model as m ON a.ModelID=m.ModelID");
        }
    }
}
