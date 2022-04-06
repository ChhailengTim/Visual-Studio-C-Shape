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


            //string[] host_name = { "asp.net", "kkbc.org", "dara.net", "bopha.org", "aming.kh", "tola.com", "kkbbc.com", "nono.net", "lola.", "momo.tv" };

            ////MessageBox.Show(host_name[0].Substring(0));
            //var source = from v in host_name
            //             where v.Substring(v.LastIndexOf(".")).Length > 3
            //             //orderby v descending //big to small
            //             orderby v ascending //small to big
            //             select v;


            //string k = "";
            //foreach(string s in source)
            //{
            //    k += s + "\n";
            //}
            //MessageBox.Show(k);

            //product[] obj = new product[]
            //{ 
            //    new product("cocacola", 100, 8.5),
            //    new product("cocacola", 100, 8.5),
            //    new product("hanuman", 50, 8.6),
            //    new product("tiger", 80, 25.5),
            //    new product("abc", 150, 25.5),
            //    new product("anchor", 200, 15.5),

            //};

            //var source = from v in obj
            //             where v.price<20
            //             orderby v.pname
            //                 //select v;
            //             select new Lpro(v.pname, v.price);
            //string k = "";
            ////foreach (product s in source)
            ////{
            ////    k += s.pname + "\t" + s.qty + "\t" + s.price + "\n";
            ////}
            //foreach(Lpro s in source)
            //{
            //    k += s.pname + "\t" + s.price + "\n";
            //}
            //MessageBox.Show(k);

            product[] pro = new product[]
            {
                new product("p01","coca",100,8.5),
                new product("p02","7-up",100,7.5),
                new product("p03","abc",100,25.5),
                new product("p04","tiger",100,20.5),
            };

            //order[] R = new order[]
            //{
            //    new order("r001","p01",5,8.5),
            //    new order("r001","p03",25,25.5),
            //    new order("r002","p01",10,8.5),
            //    new order("r002","p03",30,25.5),
            //    new order("r002","p04",20,80.5),
            //    new order("r003","p01",15,8.5),
            //}; //pname, qty, price, rid

            //var source = from vp in pro
            //             join vr in R on vp.pid equals vr.pid
            //             select new Lorder(vp.pname, vr.qty, vr.price, vr.rid);
            //string st = "";
            //foreach(Lorder s in source)
            //{
            //    st += s.pname + "\t" + s.qty + "\t" + s.price + "\t" + s.rid + "\n";
            //}
            //MessageBox.Show(st);

            //var value = new { v1 = 1234, v2 = "Hello!", v3 = DateTime.Now, v4 = pro[0] };
            //MessageBox.Show(value.v1 + "\t" + value.v2 + "\t" + value.v3.ToShortDateString() + "\t" + value.v4.pid + "\t" + value.v4.pname + "\t" + value.v4.qty);
            Reader[] Re = new Reader[]
            {
                new Reader("R001","bora","student"),
                new Reader("R002","nana","student"),
                new Reader("R003","lola","officer"),
                new Reader("R004","koko","teacher"),
                new Reader("R005","momo","student"),
            };

            string[] type = { "student", "teacher", "officer", "other" };

            var source = from vt in type
                         join vr in Re on vt equals vr.type into new_list_reader
                         select new { v1 = vt, v2 = new_list_reader };

            string st = "";

            foreach(var s in source)
            {
                st += "Type Reader is " + s.v1 + "\n";
                foreach(Reader r in s.v2)
                {
                    st += r.rid + "\t" + r.rname + "\t" + r.type + "\n";
                }
            }
            MessageBox.Show(st);
        }
    }
    class Reader
    {
        public string rid { set; get; }
        public string rname { set; get; }
        public string type { set; get; }
        public Reader(string id,string n,string t)
        {
            rid = id;
            rname = n;
            type=t;
        }
    }
    class Lorder
    {
        public string pname { set; get; }
        public int qty { set; get; }
        public double price { set; get; }
        public string rid { set; get; }
        public Lorder(string n,int q, double p,string id)
        {
            pname = n;
            qty = q;
            price = p;
            rid = id;
        }
    }
    class Lpro
    {
        public string pname { set; get; }
        public double price { set; get; }
        public Lpro(string n,double p) { pname = n; price = p; }
    }
    class product
    {
        public double pid { set; get; }
        public string pname { set; get; }
        public int qty { set; get; }
        public double price { set; get; }
        public product(string n, string v, int q,double p) { pname = n;qty = q;pid = p; }
    }
    class order
    {
        public string rid { set; get; }
        public string pid { set; get; }
        public int qty { set; get; }
        public double price { set; get; }
        public order(string id, string pi,int q, double p)
        {
            rid = id;
            pid = pi;
            qty = q;
            price=p;
        }
    }
}
