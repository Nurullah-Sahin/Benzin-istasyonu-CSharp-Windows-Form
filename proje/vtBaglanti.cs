using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace proje
{
    class vtBaglanti
    {
        public OleDbConnection Baglanti()
        {

            OleDbConnection bag = new OleDbConnection("Provider= Microsoft.Jet.OleDB.4.0;Data Source=vtBenzinIstasyonu.mdb");
            return bag;

        }

        
        public void _Calistir(string sqlstr)
        {
            OleDbConnection con = Baglanti();
            con.Open();
            OleDbCommand komut = new OleDbCommand(sqlstr, con);
            komut.ExecuteNonQuery();
            con.Close();


        }


        public DataTable _Liste(string sqlstr)
        {
            OleDbConnection con = Baglanti();
            con.Open();
            OleDbDataAdapter adap = new OleDbDataAdapter(sqlstr, con);
            DataTable dtb = new DataTable();
            adap.Fill(dtb);
            con.Close();
            return dtb;


        }

        public bool Kontrol(string TabloAdi, string AlanAdi, string ArananDeger)
        {
            bool donen = false;

            DataTable dtb = _Liste("Select * from " + TabloAdi + " where " + AlanAdi + "='" + ArananDeger + "' ");

            if (dtb.Rows.Count > 0)
            {
                donen = true;
            }
            return donen;

        }

        
    }
}
