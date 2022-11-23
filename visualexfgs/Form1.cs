using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace visualexfgs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] a = { "버튼", "체크 상자", "라디오 버튼" };
            for(int i = 0; i < 3; i++) { listBox1.Items.Add(a[i]); }
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] a = { "리스트 상자", "콤보 상자", "체크 리스트 상자" };
            for (int i = 0; i < 3; i++) { listBox1.Items.Add(a[i]); }
        }
    }
}
