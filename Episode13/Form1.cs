using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 5;
            //i = i + 10;
            //A obj = new A(5);
            //obj = obj + 10;
            //MessageBox.Show("obj x value is " + obj.x);
            //obj = obj - 5;
            //MessageBox.Show("obj x value is " + obj.x);

            Product p1 = new Product("A", 10, 1.2);
            Product p2 = new Product("B", 10, 2.3);
            double totale_amount = p1 + p2;
            MessageBox.Show("Total amout is " + totale_amount);

        }
    }
    class Product
    {
        public string name;
        public int qty;
        public double price;
        public Product(string n,int q,double p)
        {
            name = n;
            qty = q;
            price = p;
        }
        public Product() { }
        public static double operator +(Product p1,Product p2)
        {
            return (p1.qty * p1.price) + (p2.qty * p2.price);
        }
    }
    class A
    {
        public int x;
        public A(int a) { x = a; }
        public A() { }

        public static A operator -(A p1, int p2)
        {
            p1.x = p1.x - p2;
            return p1;
        }
        public static A operator +(A p1,int p2)
        {
            p1.x = p1.x + p2;
            return p1;
        }
    }
}
