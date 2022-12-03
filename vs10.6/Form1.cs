using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs10._6
{
    public partial class Form1 : Form
    {
        Rectangle rect;
        private Graphics gp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            rect.Width = e.X - rect.X + 1;
            rect.Height = e.Y - rect.Y + 1;
            gp.DrawRectangle(System.Drawing.Pens.Red, rect);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black, rect);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rect.X = e.X;
            rect.Y = e.Y;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gp = this.CreateGraphics();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            gp.Dispose();
        }
    }
}
