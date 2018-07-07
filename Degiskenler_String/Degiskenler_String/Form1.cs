using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_String
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string sehir;
            //sehir = textBox1.Text;
           //label1.Text = sehir;

            string ad, soyad, yas, meslek,sehir ;
            ad = textBox2.Text;
            soyad = textBox3.Text;
            yas = maskedTextBox1.Text;
            meslek = textBox4.Text;
            sehir = textBox5.Text;

            listBox1.Items.Add(ad + " " + soyad + " " + yas + " " + meslek + " " + sehir);
        }
    }
}
