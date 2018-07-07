using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_Egzersiz_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            int s1, s2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            s1 = Convert.ToInt16(textBox3.Text);
            s2 = Convert.ToInt16(textBox4.Text);
            proje = Convert.ToInt16(textBox5.Text);
            ortalama = (s1 + s2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " Ortalama: " + ortalama);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int fiyat;
            double kdv8, kdv18;
            fiyat = Convert.ToInt32(textBox6.Text);
            kdv8 = ((fiyat / 100) * 8) + fiyat;
            kdv18 = ((fiyat / 100) * 18) + fiyat;
            listBox2.Items.Add("Fiyatın Yüzde 8 :" + kdv8 + " Fiyatın Yüzde 18 :" + kdv18);
        }
    }
}
