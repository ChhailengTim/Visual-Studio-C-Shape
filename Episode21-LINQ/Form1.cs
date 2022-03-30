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
            //    int[] value = { 10, 20, 9, -3, 0, 7, 5, 8 };

            //    var source = from v in value
            //                 where v >0 && v<10
            //                 select v;

            //    value[0] = 50;

            //    foreach (int s in source)
            //    {
            //        MessageBox.Show("value is : " + s);
            //    }


            string[] host_name = { "asp.net", "kkbc.org", "dara.net", "bopha.org", "aming.kh", "tola.com", "kkbbc.com", "nono.net", "lola.", "momo.tv" };

            var source = from v in host_name
                         where v.Substring(v.LastIndexOf(".")).Length > 3
                         //orderby v descending //big to small
                         orderby v ascending //small to big
                         select v;


            string k = "";
            foreach(string s in source)
            {
                k += s + "\n";
            }
            MessageBox.Show(k);

        }
    }
}
