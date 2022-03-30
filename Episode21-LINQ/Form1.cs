using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode21_LINQ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int[] value = { 10, 20, 9, -3, 0, 7, 5, 8 };

            var source = from v in value select v;

            foreach (int s in source)
            {
                MessageBox.Show("value is :" + s);
            }
        }
    }
}
