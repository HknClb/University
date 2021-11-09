using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vize_soru_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = -525; i < 526; i++)
            {
                if (i % 3 == 0)
                {
                    if (i % 4 == 0)
                        listBox1.Items.Add(i);
                    else
                        listBox2.Items.Add(i);
                }
                else if(i % 4 == 0)
                    listBox3.Items.Add(i);
                else
                    listBox4.Items.Add(i);
            }
        }
    }
}
