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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace visualex
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string strTemp; // 필드
        FontStyle []ft= new FontStyle[4];
        
            
        private void UpdateLabel(string s, bool b)
        {
            FontStyle[] fs = new FontStyle[4];
            if (s == "굵게")
            {

                if (b == true)
                {
                    fs[0]=FontStyle.Bold;
                    
                }
                    else
                {
                    fs[0] = FontStyle.Regular;
                    
                }
                
            }
            if (s == "밑줄")
            {

                if (b == true)
                {
                    fs[1]=FontStyle.Underline;
                }
                else
                {
                    fs[1] = FontStyle.Regular;
                }

            }
            if (s == "이텔릭")
            {

                if (b == true)
                {
                    fs[2] = FontStyle.Italic;
                }
                else
                {
                    fs[2] = FontStyle.Regular;
                }

            }
            if (s == "취소선")
            {

                if (b == true)
                {
                    fs[3] = FontStyle.Strikeout;
                }
                else
                {
                    fs[3] = FontStyle.Regular;
                }

            }
            FontStyle fss = fs[0] | fs[1] | fs[2] | fs[3];
            label3.Font = new Font(Font, fss);

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleLeft;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleCenter;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label3.TextAlign = ContentAlignment.MiddleRight;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox1.Text,checkBox1.Checked);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox2.Text, checkBox2.Checked);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox3.Text, checkBox3.Checked);
        }
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            UpdateLabel(checkBox4.Text, checkBox4.Checked);
        }

       
    }
}
