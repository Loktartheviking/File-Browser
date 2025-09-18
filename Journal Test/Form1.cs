using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Journal_Test
{
    public partial class Form1 : Form
    {
        public string selectedFileName;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Process.Start(selectedFileName);
        }

        private void filePath_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fileName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        { 
            OpenFileDialog fileDir = new OpenFileDialog();

            fileDir.InitialDirectory = "c:\\";
            fileDir.Filter = "Text files (*.txt, *.TXT, *.log)|*.txt;*.TXT;*.log";
            fileDir.FilterIndex = 0;
            fileDir.RestoreDirectory = true;

            if (fileDir.ShowDialog() != DialogResult.OK)
            {
                return;

            }

            string selectedFileName = fileDir.FileName;
            this.selectedFileName = selectedFileName;
            textBox1.Text = selectedFileName;

        }
    }
}
