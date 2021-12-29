using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode10_inheritance
{
    class ParentClass
    {
        public ParentClass()
        {
            MessageBox.Show("Welcome Parent class show");
        }
        public ParentClass(String st)
        {
            MessageBox.Show(st);
        }
    }
    class ChildClass: ParentClass
    {
        public ChildClass(): base("Hello! parent class show")
        {
            MessageBox.Show("Welcome Child class show");
        }
    }
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
                MessageBox.Show("Person name: " + name + "Sex: " + sex + "address: " + address);
            }
        }
        class student: Person
        {
            public string Class;
        }
        class staff: Person
        {
            public double salary;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChildClass obj = new ChildClass();


            //student stu = new student();
            //stu.name = "Dara";
            //stu.sex = "Male";
            //stu.address = "Phnom Penh";
            //stu.Class = "E7";
            //staff st = new staff();
            //st.name = "Bro";
            //st.sex = "Female";
            //st.address = "PP";
            //st.salary = 600;
            //st.show_info();
        }
    }
}
