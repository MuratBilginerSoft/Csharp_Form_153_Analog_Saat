using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnalogSaat_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            SaatOlustur saat = new SaatOlustur();
            saat.Saniye(DateTime.Now.Second,this);
            saat.Dakika(DateTime.Now.Minute,this);
            saat.Saat(DateTime.Now.Hour, this);
            saat.Cerceve(this);
            saat.Sus(this);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            SaatOlustur saat = new SaatOlustur();
            this.Refresh();
            saat.Saniye(DateTime.Now.Second, this);
            saat.Dakika(DateTime.Now.Minute, this);
            saat.Saat(DateTime.Now.Hour, this);
            saat.Sus(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
