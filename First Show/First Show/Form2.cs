using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace First_Show
{
    public partial class Form2 : Form
    {
        string s;
        public Form2(string st)
        {
            InitializeComponent();
            s = st;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "\n" + s;
        }
    }
}
