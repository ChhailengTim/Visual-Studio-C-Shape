using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //List<int> obj = new List<int>();
            //obj[0] = 123;
            staff s1 = new staff("Nara", 700);
            staff s2 = new staff("Bopha", 800);
            staff s3 = new staff("Mona", 600);
            staff s4 = new staff("Koko", 900);
            store obj = new store();
            obj[0] = s1;
            obj[1] = s2;
            obj[2] = s3;
            obj[3] = s4;

            //for(int i=0;i<4;i++)
            //{
            //    staff s = obj[0];
            //    MessageBox.Show("Staff name: " + s.name + " Salary: " + s.salary);
            //}
            staff s = obj["ona"];
            if (s != null)
            {
                MessageBox.Show("Staff name: " + s.name + " Salary: " + s.salary);
            }else
                MessageBox.Show("Staff not found");
        }
    }
    class store
    {
        staff[] st = new staff[100];
        public int count = 0;
        public staff this[int index]
        {
            set { st [index] = value; count++; }
            get { return st[index]; }
        }
        public staff this[string index]
        {
            get
            {
                for (int i = 0; i < this.count; i++)
                    if (st[i].name == index) return st[i];
                return null;
            }
        }
    }
    class staff
    {
        public string name;
        public double salary;
        public staff(string n,double s) { name = n;salary = s; }
    }
}
