using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtAdd_TextChanged(object sender, EventArgs e)
        {
            
        }
private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "")
            {
                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string[] st = listBox1.Items[i].ToString().Split('\t');
                    if (st[0] == txtAdd.Text)
                    {
                        txtAdd.Text = st[0];
                        txtTitle.Text = st[1];
                        txtQty.Text = st[2];
                        txtAuthor.Text = st[3];
                        listBox1.SelectedIndex = i;
                        return;
                    }

                }
                MessageBox.Show("Search book not found");
            }
            else MessageBox.Show("Please Enter book id to search");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                if (MessageBox.Show("Are you sure delete this item", "", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    for (int i = listBox1.SelectedItems.Count; i > 0; i--)
                    {
                        listBox1.Items.Remove(listBox1.SelectedItem);
                    }
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAdd.Text != "" && txtQty.Text != "" && txtTitle.Text != "" && txtAuthor.Text != "")
            {

                for (int i = 0; i < listBox1.Items.Count; i++)
                {
                    string[] st = listBox1.Items[i].ToString().Split('\t');
                    if (st[0] == txtAdd.Text)
                    {
                        if (MessageBox.Show("Update information", "", MessageBoxButtons.YesNo) ==
                            DialogResult.Yes)
                        {
                            listBox1.Items[i] = txtAdd.Text + "\t" + txtTitle.Text + "\t" +
                                   txtQty.Text + "\t" + txtAuthor.Text;
                            txtAdd.Clear(); txtTitle.Clear(); txtQty.Clear(); txtAuthor.Clear();
                            txtAdd.Focus();
                        }
                        return;
                    }
                }
                listBox1.Items.Add(txtAdd.Text + "\t" + txtTitle.Text + "\t" +
                                   txtQty.Text + "\t" + txtAuthor.Text);
                txtAdd.Clear(); txtTitle.Clear(); txtQty.Clear(); txtAuthor.Clear();
                txtAdd.Focus();
            }
            else
            {
                MessageBox.Show("Please verify you TextBox input again!");
            }

        }
    }

}
