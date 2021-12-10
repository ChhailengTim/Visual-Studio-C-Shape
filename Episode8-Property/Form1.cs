using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Episode8_Property
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //person.show();
            int i=1;


            person obj = new person("Bopha","Female","0184213057");
            //obj.name = "Bopha";
            //obj.sex = "Female";
            //obj.phone = "01084213057";
            obj.show_infor();
        }
    }
}

class person
{
    public string name { set; get; }
    public string sex { set; get; }
    public string phone { set; get; }

    public person(string name, string sex, string phone)
    {
        this.name = name;
        this.sex = sex;
        this.phone = phone;
    }
    public person()
    {

    }
    ~person()
    {
        MessageBox.Show("Bye bye class person");
    }

    public static void show()
    {
        MessageBox.Show("Welcome static method");
    }
    public void show_infor()
    {
        MessageBox.Show(name + "\t" + sex + "\t" + phone);
    }
}
