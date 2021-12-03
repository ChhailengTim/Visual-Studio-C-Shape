using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode7_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            //A obj = new A();
            //obj.info = "Welcome class A";

            //MessageBox.Show(obj.info);

            Account Ac = new Account();
            Ac.id = "abc122";
            Ac.name = "dara kok";
            Ac.balance = 123432.3;

            MessageBox.Show(Ac.id + "\t" + Ac.name + "\t" + Ac.balance);

        }
    }
    //class A
    //{
    //    private string _info;
    //    public string info
    //    {
    //        set { _info = value; }
    //        get { return _info; }
    //    }
    //}

    class Account
    {
        
        private string _id;
        private string _name;
        private double _balance;

        public string id { set { _id = value; } get { return _id; } }
        public string name { set { _name = value; } get { return _name; } }
        public double balance { set { _balance = value; } get { return _balance; } }

    }
}
