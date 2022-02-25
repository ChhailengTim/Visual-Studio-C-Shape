using System;
using System.Windows.Forms;
using PA = ProjectE7.teamA;
using PB = ProjectE7.teamB;

namespace Episode16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int i = 10;
            //int j = i;
            //i = 20;
            //MessageBox.Show("Value i=" + i + " and j=" + j);
            //person p = new person("bora","male",20);
            //person p1 = p;
            //p.name = "naro";
            //MessageBox.Show("P name=" + p.name + " sex=" + p.sex + " age=" + p.age + "\n"+
            //    "P1 name= "+p1.name+" sex= "+p1.sex+" age="+p1.age);
            MessageBox.Show(PA.ClassA.show());
            MessageBox.Show(PB.ClassA.show());
        }
    }
    struct person
    {
        public string name;
        public string sex;
        public int age;
        public person(string n,string s,int a)
        {
            name = n;sex = s;age = a;
        }
        //public person() { }
        //~person()
        //{
        //    MessageBox.Show("Bye bye class person");
        //}
    }
}
