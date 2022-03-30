using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] value = { 10, 20, 9, -3, 0, 7, 5, 8 };

            //var source = from v in value 
            //             where  v>0 && v<10
            //             select v;

            //value[0] = 50;

            //foreach (int s in source) {
            //    MessageBox.Show("value is : " + s);
            //}

            //string[] host_name ={ "asp.net","kkbc.org","dara.net","bopha.org","tola.com",
            //                    "kkbbc.com","nono.net","lola.","momo.tv"};

            ////MessageBox.Show(host_name[0].Substring(1));
            //var source = from v in host_name
            //             where v.Substring(v.LastIndexOf(".")).Length > 3
            //             orderby v ascending//descending
            //             select v;
            //string k = "";
            //foreach (string s in source)
            //{
            //    k += s + "\n";
            //}
            //MessageBox.Show(k);
            product[] obj = new product[] {new product("cocacola",100,8.5),
                                           new product("7-up",     50,8.0),
                                           new product("tiger",    80,20.5),
                                           new product("abc",     150,25.5),
                                           new product("anchor",  200,15.5),
                                           };

            var source = from v in obj
                         where v.price <20
                         orderby v.pname
                         select new Lpro(v.pname,v.price);

            string k = "";
            //foreach (product s in source) {
            //    k += s.pname + "\t" + s.qty + "\t" + s.price + "\n";
            //}
            foreach (Lpro s in source)
            {
                k += s.pname + "\t" + s.price + "\n";
            }
            MessageBox.Show(k);
        }
    }
    class Lpro {
        public string pname { set; get; }
        public double price { set; get; }
        public Lpro(string n, double p) { pname = n; price = p; }
    }
    class product {
        public string pname { set; get; }
        public int qty { set; get; }
        public double price { set; get; }
        public product(string n, int q, double p) { pname = n; qty = q; price = p; }
    }
}
