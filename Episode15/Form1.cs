using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //public delegate void del_show(string st);
        private void Form1_Load(object sender, EventArgs e)
        {
            //sample1
            //del_show del_obj = new del_show(show);
            //del_obj("Welcome delegate function");
            //sample2
            List<student> obj = new List<student>();
            obj.Add(new student("nora", "male", 95));
            obj.Add(new student("lola", "male", 40));
            obj.Add(new student("koko", "female", 45));
            obj.Add(new student("momo", "male", 90));
            obj.Add(new student("naro", "female", 85));


            student.pass_student(obj);
        }
        //public void show(string st)
        //{
        //    MessageBox.Show(st);
        //}
        public class student
        {
            public string name { set; get; }
            public string sex { set; get; }
            public double average { set; get; }
            public student(string n,string s,double a)
            {
                name = n;sex = s;average = a;
            }
            public static void pass_student(List<student> stu)
            {
                foreach(student s in stu)
                {
                    if (s.average >= 50)
                    {
                        MessageBox.Show("Student name: " + s.name + " Sex: " + s.sex + " Average: " + s.average);
                    }
                }
            }
        }
    }
}
