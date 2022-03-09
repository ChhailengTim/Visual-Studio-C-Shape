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

namespace Episode18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            //FileStream Fs = new FileStream("Episode18.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(Fs);
            //sw.WriteLine("nara@male@0123456789");
            //sw.Close();
            //Fs.Close();

            //FileStream Fs = new FileStream("Episode18.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(Fs);

            //while (!sr.EndOfStream)
            //{
            //    MessageBox.Show(sr.ReadLine());
            //}
            //Fs.Close();
        }

        private void textRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream("holtel.txt", FileMode.Append);
            StreamWriter sw = new StreamWriter(Fs);
            sw.WriteLine( textRoom.Text +"/" + textCustName.Text +"/"+ textDate.Text);
            //sw.WriteLine("Customer Name :" + textCustName.Text);
            //sw.WriteLine("Date :" + textDate.Text);
            sw.Close();
            Fs.Close();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream("holtel.txt", FileMode.Open);
           StreamReader sr = new StreamReader(Fs);
            MessageBox.Show(sr.ReadLine());
            string st = "";
            while (!sr.EndOfStream)
            {
                st += sr.ReadLine() + "\n";
            }
            MessageBox.Show(st);
            Fs.Close();
        }
    }
}
