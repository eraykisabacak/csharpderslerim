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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Araba rb2 = new Araba();
            rb2.renk = "Yeşil";
            rb2.hiz = 140;
            rb2.motor = 1220.36;
            rb2.fiyat = 35250;
            rb2.durum = 'I';

            label1.Text = rb2.renk;
            label2.Text = rb2.hiz.ToString();
            label3.Text = rb2.motor.ToString();
            label4.Text = rb2.fiyat.ToString();

            if (rb2.durum == 'S')
            {
                label5.Text = "Sıfır";
            }
            if (rb2.durum == 'I')
            {
                label5.Text = "İkinci El";
            }

            pictureBox1.BackColor = Color.LightSeaGreen;
        }
    }
}
