using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_4._2_Drobnyi
{
    public partial class Form1 : Form
    {
        triangle new_triangle = new triangle();
        hexagon new_hexagon = new hexagon();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox2.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PointF[] shape = new PointF[new_hexagon.n];
            shape[0] = new PointF(0, 0);
            shape[1] = new PointF(0, 0);
            shape[2] = new PointF(0, 0);
            shape[3] = new PointF(0, 0);
            shape[4] = new PointF(0, 0);
            shape[5] = new PointF(0, 0);


            var graphics = e.Graphics;
            var x = pictureBox1.Width / 2;
            var y = pictureBox1.Height / 2;
            var r = 70;

            //создаем 6 точек
            for (int a = 0; a < new_hexagon.n; a++)
            {
                shape[a] = new PointF(
                   x + r * (float)Math.Cos(a * 60 * Math.PI / 180f),
                   y + r * (float)Math.Sin(a * 60 * Math.PI / 180f));
            }

            graphics.DrawPolygon(Pens.Red, shape);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Point[] shape = new Point[new_triangle.n];
            shape[0] = new Point(200, 100);
            shape[1] = new Point(300, 200);
            shape[2] = new Point(100, 200);


            var graphics = e.Graphics;

            graphics.DrawPolygon(Pens.Red, shape);
        }
    }
}
