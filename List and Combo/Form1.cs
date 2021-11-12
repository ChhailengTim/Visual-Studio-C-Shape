using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace List_and_Combo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            //label1.Text = listBox1.Items[listBox1.SelectedIndex].ToString();
            if(listBox1.SelectedItems.Count > 0)
            {
                label1.Text = listBox1.SelectedItem.ToString();
            }
            else
            {
                label1.Text = "Label1";
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("Item1");
            listBox1.Items.Add("Item2");
            listBox1.Items.Add("Item3");
            listBox1.Items.Add("Item4");
            //listBox1.Items[0]="Newitem";
        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this Item", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            for (int i = listBox1.SelectedItems.Count; i > 0; i--)
            {
                //listBox1.Items.Remove(listBox1.SelectedItem);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }
    }
}
