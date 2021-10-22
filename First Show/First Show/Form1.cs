using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Show
{
    public partial class Form1 : Form
    {
        string st = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            st = st + textInfor.Text + "\n";
            MessageBox.Show(st);
        }

        private void btnform2_Click(object sender, EventArgs e)
        {
            Form F2 = new Form2(st);
            F2.Show();
        }
    }
}
