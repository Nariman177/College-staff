using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tovar
{
    public partial class Form1 : Form
    {
        struct Tovar
        {
            public string nazv;
            public int stoim;
            public int kol;
        }
        public Form1()
        {
            InitializeComponent();
        }

        Tovar[] Shop =
         {
            new Tovar{ nazv = "Blender", stoim = 90000, kol = 5},
            new Tovar {nazv = "Termomik",stoim = 290000, kol = 15},
            new Tovar {nazv = "Samsung", stoim = 280000, kol= 20},
            new Tovar {nazv = "Vw",stoim = 205000,kol = 9},
            new Tovar {nazv = "Apple Watch", stoim = 10000, kol = 20}
        };

        private void button1_Click(object sender, EventArgs e)
        {
            int value;
            value = Convert.ToInt32(textBox1.Text);
            textBox2.Clear();
            bool found = false;
            for (int i = 0; i < Shop.Length; i++)
            {
                if (Shop[i].stoim > value)
                {
                    found = true;
                    textBox2.Text += Shop[i].nazv + ":" + Shop[i].stoim + "tg.\r\n";
                }
            }

            if (!found)
            {
                textBox2.Text = "Tovari stoimostyu bolshe zadannogo znachenya ne naideni";
            }
        }
    }
}
