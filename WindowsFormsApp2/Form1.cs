using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        private void UpdateLabel(string s, bool b)
        {
            if (s == "적용")
            {
                if (b)
                {
                    fontDialog1.ShowApply = true;

                }
                else
                {
                    fontDialog1.ShowApply = false;
                }
            }
            if (s == "색상")
            {
                if (b)
                {
                    fontDialog1.ShowColor = true;
                }
                else
                {
                    fontDialog1.ShowColor = false;
                }
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text, checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();

        }
    }
}
