using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinif_ornek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Araba rb = new Araba();
            rb.renk = "Mavi";
            rb.hiz = 160;
            rb.motor = 1245.56;
            rb.fiyat = 50000;
            rb.durum = 'S';
            rb.YIL = -2016;
            rb.MARKASI = "volkswagen";
            rb.muayene = 2017;
            rb.plaka = "37 DT 555";
            rb.sahip = "Eray Kısabacak";

            label1.Text = rb.renk;
            label2.Text = rb.hiz.ToString();
            label3.Text = rb.motor.ToString();
            label4.Text = rb.fiyat.ToString();

            if (rb.durum == 'S')
            {
                label5.Text = "Sıfır";
            }
            if(rb.durum == 'I')
            {
                label5.Text = "İkinci El";
            }

            label6.Text = rb.YIL.ToString();
            label7.Text = rb.MARKASI;
            label8.Text = rb.muayene.ToString();
            label9.Text = rb.plaka;
            label10.Text = rb.sahip;


            pictureBox1.BackColor = Color.CadetBlue;
            
        }
    }
}
