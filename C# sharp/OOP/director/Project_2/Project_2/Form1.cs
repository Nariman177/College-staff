﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            


            button1.Click += button1_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Привет");
            Form2 newForm = new Form2();
            newForm.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
