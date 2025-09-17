using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrawingProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Color myColor = new Color();
            myColor = Color.Red;

            Pen myPen = new Pen(myColor);
            myPen.Width = 6;

            myPen.StartCap = System.Drawing.Drawing2D.LineCap.Triangle;
            myPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;


            e.Graphics.DrawLine(myPen, 100, 100, 100, 300);
            e.Graphics.DrawRectangle(myPen, 200, 300, 50, 50);
            e.Graphics.DrawEllipse(myPen, 50, 50, 99, 99);

        }
    }
}
