using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vs10._6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            System.Text.StringBuilder messageBoxCS = new System.Text.StringBuilder();


            if (e.Control&&e.KeyCode==Keys.F1) { messageBoxCS.AppendFormat("{0}+Control", e.KeyCode);
                MessageBox.Show(messageBoxCS.ToString(), "누른 키");
                
            }
            else if (e.Shift && e.KeyCode == Keys.F1) { messageBoxCS.AppendFormat("{0}+Shift", e.KeyCode);
                MessageBox.Show(messageBoxCS.ToString(), "누른 키");
                
            }
            else if(e.Alt && e.KeyCode == Keys.F1) { messageBoxCS.AppendFormat("{0}+Alt", e.KeyCode);
                MessageBox.Show(messageBoxCS.ToString(), "누른 키");
                
            }
            
           
            
            


           
        }
    }
}
