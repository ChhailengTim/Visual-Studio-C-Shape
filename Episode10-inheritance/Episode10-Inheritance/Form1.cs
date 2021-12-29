using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode10_Inheritance
{
    public partial class Form1 : Form
    {
        class ParentClass
        {
            public ParentClass()
            {
                MessageBox.Show("Welcome Parent class show");
            }
            public ParentClass(string st)
            {
                MessageBox.Show(st);
            }
        }
        class ChildClass : ParentClass
        {
            public ChildClass() : base("Hello! Parent class show")
            {
                MessageBox.Show("Welcome Child class show");
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChildClass obj = new ChildClass();

            //student stu = new student();
            //stu.name = "dara";
            //stu.sex = "male";
            //stu.address = "pp";
            //stu.Class = "E7";
            //stu.show_info();
            //staff st = new staff();
            //st.name = "Bora";
            //st.sex = "female";
            //st.address = "pp";
            //st.salary = 600;
            //st.show_info();
        }
    }
    class sample
    {
    }
    class Person
    {
        public string name;
        public string sex;
        public string address;

        public void show_info()
        {
            MessageBox.Show("Person name: " + name + " Sex: " + sex + " address: " + address);
        }
    }
    class student : Person
    {
        public string Class;
    }
    class staff : Person
    {
        public double salary;
    }
}
