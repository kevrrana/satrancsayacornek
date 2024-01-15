using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace satrançsaatiornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sureBeyaz = 10, sureSiyah = 10;

        private void timerBeyaz_Tick(object sender, EventArgs e)
        {
            sureBeyaz--;
            lblBeyaz.Text = sureBeyaz.ToString();

            if (sureBeyaz <= 0)
            {
                timerBeyaz.Stop();
                MessageBox.Show("Siyah Kazandı");

            }
        }

        private void btnBeyaz_Click(object sender, EventArgs e)
        {
            timerBeyaz.Stop();
            timerSiyah.Start();
        }

        private void btnSiyah_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start() ;
            timerSiyah.Stop() ;
        }

        private void btnBaşlat_Click(object sender, EventArgs e)
        {
            timerBeyaz.Start() ;
        }

        private void timerSiyah_Tick(object sender, EventArgs e)
        {
            sureSiyah--;
            lblBeyaz.Text = sureSiyah.ToString();

            if (sureSiyah <= 0)
            {
                timerSiyah.Stop();
                MessageBox.Show("Beyaz Kazandı");
            }
        }
    }
}
