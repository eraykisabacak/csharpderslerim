using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Degiskenler_int
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n1, n2, n3, ort;
            n1 = 50;
            n2 = 60;
            n3 = 80;
            ort = (n1 + n2 + n3) / 3;
            label1.Text="Ortalama: "+ ort;
        }
    }
}
