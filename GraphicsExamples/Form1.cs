using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsExamples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            // Graphics objects
            Graphics g = this.CreateGraphics();
            Pen Blackpen = new Pen(Color.Black, 10);
            Pen Bluepen = new Pen(Color.Blue, 10);
            SolidBrush drawBrush = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Arial", 16, FontStyle.Bold);

            // Colours
            Blackpen.Color = Color.Black;
            drawBrush.Color = Color.Blue;

            // Text code
            g.DrawString("Hello", drawFont, drawBrush, 50, 40);
           
            // Shapes on screen
            g.DrawEllipse(Blackpen, 200, 250, 200, 100);
            g.DrawEllipse(Blackpen, 245, 250, 100, 100);
            g.DrawEllipse(Bluepen, 255, 260, 80, 80);
            g.FillEllipse(drawBrush, 255, 260, 80, 80);
            g.DrawEllipse(Blackpen, 400, 250, 200, 100);
            g.DrawEllipse(Blackpen, 445, 250, 100, 100);
            g.DrawEllipse(Bluepen, 455, 260, 80, 80);
            g.FillEllipse(drawBrush, 455, 260, 80, 80);

            // this is a test comment
            //bruh moment
        }
    }
}
