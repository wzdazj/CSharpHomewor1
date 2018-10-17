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

        private void button1_Click(object sender, EventArgs e)
        {


            Random ran = new Random();
            Color randomColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            Pen pen = new Pen(Color.Blue);


            double per1 = Convert.ToDouble(textBox1.Text);
            double per2 = Convert.ToDouble(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);


            graphics = this.panel1.CreateGraphics();

            this.panel1.HorizontalScroll.Visible = true;
            this.panel1.VerticalScroll.Visible = true;

            panel1.AutoScroll = true;


            graphics.Clear(Color.White);
            if (checkBox1.Checked)
            {
                pen.Color = randomColor;
            }

            if (checkBox2.Checked)
            {
                pen.Width = ran.Next(1, 10);
            }
            drawCayleyTree(n, 200, 310, 100, -Math.PI / 2, -Math.PI / 2, per1, per2, pen);

        }

        private Graphics graphics;
        private double th1 = 30 * Math.PI / 180;
        private double th2 = 20 * Math.PI / 180;



        void drawCayleyTree(int n, double x0, double y0, double leng, double th, double _th, double per1, double per2, Pen treePens)
        {
            if (n == 0)
            {
                return;
            }

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * Math.Cos(_th);
            double y2 = y0 + leng * Math.Sin(_th);

            drawLine(x0, y0, x1, y1, treePens);

            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1, _th + th1, per1, per2, treePens);
            drawCayleyTree(n - 1, x2, y2, per2 * leng, th - th2, _th - th2, per1, per2, treePens);
        }

        void drawLine(double x0, double y0, double x1, double y1, Pen treePens)
        {
            graphics.DrawLine(treePens, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Random ran = new Random();
            Color randomColor = Color.FromArgb(ran.Next(0, 255), ran.Next(0, 255), ran.Next(0, 255));
            Pen pen = new Pen(randomColor, ran.Next(1, 10));


            double per1 = Convert.ToDouble(textBox1.Text);
            double per2 = Convert.ToDouble(textBox2.Text);
            int n = Convert.ToInt32(textBox3.Text);


            graphics = this.CreateGraphics();
            graphics.Clear(Color.White);
            drawCayleyTree(n, 200, 310, 100, -Math.PI / 2, -Math.PI / 2, per1, per2, pen);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            panel1.AutoScroll = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
