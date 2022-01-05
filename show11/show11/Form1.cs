using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Iperson obj = new person();
            ((Iperson1)obj).show();
            ((Iperson2)obj).show();
            //obj.show2();
        }
    }
    interface Iperson1 {
        void show(); //{ MessageBox.Show("Welcome Iperson show"); }
    }
    interface Iperson2 {
        void show();
    }
    interface Iperson : Iperson1, Iperson2 { }
    //class sample : Form1, person { }
    class person:Iperson {
        void Iperson1.show() { MessageBox.Show("Welcome Iperson1 show"); }
        void Iperson2.show() { MessageBox.Show("Welcome Iperson2 show"); }
        //public void show1() { MessageBox.Show("Welcome Iperson1 show"); }
        //public void show2() { MessageBox.Show("welcome Iperson2 show"); }
    }
}
