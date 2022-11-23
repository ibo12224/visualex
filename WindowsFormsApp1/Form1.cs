using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {



        

        public Form1()
        {
            InitializeComponent();
        }
        Form f;
        

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            openFileDialog1.ShowDialog();

            String filename = openFileDialog1.FileName;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            {
                StreamReader w = new StreamReader(fs);
                textBox1.Text = w.ReadLine();

            }

        }

    }
}
