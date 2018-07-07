using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Foreach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int toplam = 0;
            int[] sinav = { 70, 65, 85, 100, 90 };
            foreach(int x in sinav)
            {
                listBox1.Items.Add(x);
                toplam = toplam + x;

            }
            label1.Text = toplam.ToString();

            int ortalama = toplam / sinav.Length;

            label2.Text = ortalama.ToString();
        }
    }
}
