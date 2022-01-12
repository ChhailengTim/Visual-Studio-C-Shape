using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            A obj = new B();
            obj.show();
            obj.show_A();
        }
    }
    abstract class A
    {
        public abstract void show_A();

        public void show() { MessageBox.Show("Welcome class A"); }
    }
    sealed class B:A
    {
        public override void show_A()
        {
            MessageBox.Show("Welcome abstract class A");
        }
    }
    //class C : B
    //{

    //}
}
