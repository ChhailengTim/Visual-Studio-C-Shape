using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Iperson obj = new person();
            //((Iperson1)obj).show();
            //((Iperson2)obj).show();
            //obj.show2();
        }
    }
    interface Iperson1 {
        void show1(); //{ MessageBox.Show("Welcome Iperson show"); }
    }
    interface Iperson2
    {
        void show2();
    }
    interface Iperson : Iperson1, Iperson2
    {

    }
    //class sample : Form1.person { }
   // class person:Iperson1, Iperson2
   // {
        //public void Iperson1.show1() { MessageBox.Show("Welcome Iperson1 show"); }
        //public void Iperson2.show2() { MessageBox.Show("Welcome Iperson2 show"); }
        //public void show1() { MessageBox.Show("Welcome Iperson1 show"); }
        //public void show2() { MessageBox.Show("Welcome Iperson2 show"); }

    //}
}

