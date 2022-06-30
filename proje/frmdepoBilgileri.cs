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
    public partial class frmdepoBilgileri : Form
    {
        public frmdepoBilgileri()
        {
            InitializeComponent();
        }

        private void frmdepoBilgileri_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            btnBenzin95.Enabled = true;
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            btnBenzin97.Enabled = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            btnDizel.Enabled = true;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            btnEurodizel.Enabled = true;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            btnLpg.Enabled = true;
        }
    }
}
