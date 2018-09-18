using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int i = Convert.ToInt32(this.textBox1.Text);
            int j = Convert.ToInt32(this.textBox2.Text);

            int cheng = i * j;

            this.label1.Text = "这两个数的积为：" + cheng;

        }
    }
}
