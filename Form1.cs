using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaintTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics drawingSpace;
            drawingSpace = e.Graphics;

            drawingSpace.DrawLine(Pens.Black, 0, 0, 200, 100);
            drawingSpace.DrawLine(Pens.Black, 0, 100, 200, 100);
            drawingSpace.DrawRectangle(Pens.Blue, 200, 100, 50, 100);
            drawingSpace.DrawEllipse(Pens.CadetBlue, 200, 100, 50, 100);
            string s = "space";

            PrintControllerWithStatusDialog();
        }
    }
}
