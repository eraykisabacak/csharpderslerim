﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dinamik_Araclar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = new Button();
            Point btnkonum = new Point(20,10);

            btn.Location = btnkonum;
            btn.Name = "Buttonum";
            btn.Text = "Tıkla";
            btn.BackColor = Color.Green;
            btn.Height = 50;
            btn.Width = 75;
            this.Controls.Add(btn);

            Label lbl = new Label();
            Point lblkonum = new Point(120,10);
            lbl.Location = lblkonum;
            lbl.Name = "Label1";
            lbl.Text = "Merhaba";
            lbl.BackColor = Color.Red;
            lbl.AutoSize = true;
            this.Controls.Add(lbl);

           

            for(int i = 1;i <= 5; i++)
            {
                TextBox txt = new TextBox();
                Point txtkonum = new Point(300, i * 35);
                txt.Location = txtkonum;
                txt.Name = "Textbox" + i;
                txt.Text = i.ToString();
                this.Controls.Add(txt);

            }



        }
    }
}
