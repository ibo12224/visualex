using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs10._6._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (c == '1') return;///////////234567890124456771ssiiiissssssssssssssssssssssssssssssss
            if (c == '2') return;
            if (c == '3') return;
            if (c == '4') return;
            if (c == '5') return;
            if (c == '6') return;
            if (c == '7') return;
            if (c == '8') return;
            if (c == '9') return;
            if (c == '0') return;
            if (c == '-') return;
            else e.Handled = true;


        }
    }
}
