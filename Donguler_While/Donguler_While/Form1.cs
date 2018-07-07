using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Donguler_While
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = 1;
            int toplam = 0;
            while (i <= 5)
            {
                listBox1.Items.Add("Merhaba Elazığ");
                listBox2.Items.Add(i);
                toplam += i;
                i++;
            }
            listBox2.Items.Add("Toplam: "+toplam);
        }
    }
}
