using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operator
{
    public partial class Form1 : Form
    {
        string start = "";
        string stop = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 1234;
            //double d = i;
            //double d = 12342154365215;
            //int i = (int)d; //inplicit
            //int i = Convert.ToInt32(d); //explicit
            //MessageBox.Show(d.ToString());

            //DateTime dt = DateTime.Parse("10/27/2021"); //explicit

            //DateTime dt;
            //bool b = DateTime.TryParse("10/27/2021",out dt); //implicit
            //if (b==true)
            //{
            //    MessageBox.Show(dt.ToShortDateString());
            //}
            //else
            //{
            //    MessageBox.Show("Date is wrong");
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textPcNum.Text != "")
            {
                textStart.Text = DateTime.Now.ToLongTimeString();
                start = start + textPcNum.Text + ">" + textStart.Text + "\n";
            }
            else
            {
                MessageBox.Show("Please verify your box pc-number again!");
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if(
                textPcNum.Text !="")
            {
                string[] st = start.Split('\n');

                foreach(string s in st)
                {
                    if(s !="")
                    {
                        string[] ss = s.Split('>');
                        if(ss[0]==textPcNum.Text)
                        {
                            textStart.Text = ss[1];
                            break;
                        }
                    }
                }

                textStop.Text = DateTime.Now.ToLongTimeString();

                string Start = textStart.Text;
                string Stop = textStop.Text;

                TimeSpan Result = DateTime.Parse(Stop) - DateTime.Parse(Start);

                textResult.Text = Start + " and " + Stop + " duration " + Result.ToString();
            }
            else
            {
                MessageBox.Show("Please verify your box pc-number again!");
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            MessageBox.Show(start);
        }
    }
}
