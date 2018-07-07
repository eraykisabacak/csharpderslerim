using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayısalLoto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rast = new Random();
            int s1, s2, s3, s4, s5, s6;
            s1 = rast.Next(1, 5);
            s2 = rast.Next(1, 5);
            s3 = rast.Next(1, 5);
            s4 = rast.Next(1, 5);
            s5 = rast.Next(1, 5);
            s6 = rast.Next(1, 5);

            if (s1.ToString() == textBox1.Text)
            {
                label1.Text = s1.ToString();
                label1.BackColor = Color.Green;
            }else{
                label1.Text = s1.ToString();
                label1.BackColor = Color.Red;
            }
            //////////////////////////////////

            if (s2.ToString() == textBox2.Text)
            {
                label2.Text = s2.ToString();
                label2.BackColor = Color.Green;
            }else
            {
                label2.Text = s2.ToString();
                label2.BackColor = Color.Red;
            }
            /////////////////////////////////////

            if (s3.ToString() == textBox3.Text)
            {
                label3.Text = s3.ToString();
                label3.BackColor = Color.Green;
            }else
            {
                label3.Text = s3.ToString();
                label3.BackColor = Color.Red;
            }
            ////////////////////////////////////

            if (s4.ToString() == textBox4.Text)
            {
                label4.Text = s4.ToString();
                label4.BackColor = Color.Green;
            }else
            {
                label4.Text = s4.ToString();
                label4.BackColor = Color.Red;
            }

            ////////////////////////////////////

            if (s5.ToString() == textBox5.Text)
            {
                label5.Text = s5.ToString();
                label5.BackColor = Color.Green;
            }else
            {
                label5.Text = s5.ToString();
                label5.BackColor = Color.Red;
            }

            ////////////////////////////////////

            if (s6.ToString() == textBox6.Text)
            {
                label6.Text = s6.ToString();
                label6.BackColor = Color.Green;
            }else
            {
                label6.Text = s6.ToString();
                label6.BackColor = Color.Red;
            }
        }
    }
}
