using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffee_PC
{
    public partial class Form1 : Form
    {
        string start = "";
        string stop = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void txtPCnum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnST_Click(object sender, EventArgs e)
        {
            if(txtPCnum.Text !="")
            {
                string[] st = start.Split('\n');
                Boolean dpl = false;
                
                foreach (string s in st)
                {
                    string[] ss = s.Split('>');
                    if (ss[0] == txtPCnum.Text)
                    {
                        MessageBox.Show("The [ " + txtPCnum.Text + " ] is already used.");
                        dpl = true;
                        break;
                    }
                    else
                    {
                        dpl = false;
                    }
                }
                if(dpl==false)
                {
                    txtST.Text = DateTime.Now.ToLongTimeString();
                    start += txtPCnum.Text + ">" + txtST.Text + "\n";
                }
            }
            else
            {
                MessageBox.Show("Please verify you box pc number again!");
            }
        }

        private void btnSP_Click(object sender, EventArgs e)
        {
            if (txtPCnum.Text != "")
            {
                string[] st = start.Split('\n');
                start = "";

                foreach (string s in st)
                {
                    string[] ss = s.Split('>');
                    if(ss[0]==txtPCnum.Text)
                    {
                        txtST.Text = ss[1];
                    }
                    else
                    {
                        start += s + "\n";
                    }
                }
                txtSP.Text = DateTime.Now.ToLongTimeString();
                txtTU.Text = (DateTime.Parse(txtSP.Text) - DateTime.Parse(txtST.Text)).ToString();
                stop += txtPCnum.Text + ">" + txtTU.Text + "\n";
            }
            else
            {
                MessageBox.Show("Please verify your box PC Number again!");
            }
        }

        private void btnRP_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stop);
        }
    }
}
