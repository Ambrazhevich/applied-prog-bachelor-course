using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialog1.FileName;
                textBox1.Text = path;
            }
            else
            {
                path = null;
            }
            var httpRequest = (HttpWebRequest)HttpWebRequest.Create("http://localhost:56507/home/Read?path=" + path);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            var reader = new StreamReader(httpResponse.GetResponseStream());
            string result = reader.ReadToEnd();
            richTextBox1.Text = result;
            reader.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
