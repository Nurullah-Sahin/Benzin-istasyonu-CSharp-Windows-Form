using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje
{
    class csMarkaModel
    {
        vtBaglanti vt = new vtBaglanti();
        public int MarkaID { get; set; }
        public int ModelID { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }




        public csMarkaModel()
        {
            this.Model = string.Empty;
            this.Marka = string.Empty;
            this.ModelID = -1;
            this.MarkaID = -1;

        }





        public void MarkaEkle()
        {
            bool gelen = vt.Kontrol("T_Marka", "Marka", Marka);
            if (gelen == false)
            {
                vt._Calistir("insert into T_Marka(Marka) values ('" + Marka + "')");
            }
            else
            {
                MessageBox.Show(Marka + " Markasının Kaydı Bulunmaktadır");
            }

        }

        public void ModelEkle()
        {
            bool gelen = vt.Kontrol("T_Model", "Model", Model);
            if (gelen == false)
            {
                vt._Calistir("insert into T_Model(Model) values ('" + Model + "')");
            }
            else
            {
                MessageBox.Show(Model + " Modelinin Kaydı Bulunmaktadır");
            }

        }

        public DataTable ModelListesi()
        {
            return vt._Liste("select * from T_Model");

        }

        public DataTable MarkaListesi()
        {
            return vt._Liste("select * from T_Marka");

        }

        public void MarkaGuncelle()
        {
            vt._Calistir("Update T_Marka set Marka='" + Marka + "' where MarkaID=" + MarkaID + "");
        }


        public void MarkaSil()
        {

            vt._Calistir("delete * from  T_Marka where MarkaID=" + MarkaID + "");

        }

        public void cmbDoldur(ComboBox cmb)
        {

            DataTable dtb = new DataTable();
            dtb = vt._Liste("select * from T_Marka");
            cmb.DataSource = dtb;
            cmb.DisplayMember = "Marka";
            cmb.ValueMember = "MarkaID";

        }

        public DataTable MarkaModelleri()
        {


            return vt._Liste("select * from T_Model where MarkaID=" + MarkaID + "");
        }
    
    
        public DataTable MarkaModelListesi()
        {
            return vt._Liste("select T_Marka.MarkaID, T_Marka.Marka, T_Model.Model From T_Marka, T_Model Where T_Marka.MarkaID = T_Model.MarkaID");
        }
    
    }
}

