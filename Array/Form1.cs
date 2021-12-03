using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //int[] a = new int[3] { 10, 20, 30 }; //a[0]=10; a[1]=20; a[2]=30;
            //int[] a = new int[] { 10, 20, 30, 40 };
            //int[] a = { 1, 2, 3, 4, 5 };
            //object[] a = { 10, 5.43, 'F', "Hello", DateTime.Now };

            //for (int i = 0; i < a.Length; i++)
            //{
            //    MessageBox.Show("Array a[" + i + "]" + a[i]);
            //}
            //foreach (object s in a)
            //    foreach (int s in a)
            //    {
            //        MessageBox.Show("Array a is" + s);
            //    }
            //int[,] a = new int[2, 3] { {1,2,3 }, {4,5,6 } };

            //for(int i = 0; i < a.GetLength(0); i++)
            //{
            //    for(int j = 0; i < a.GetLength(1); j++)
            //    {
            //        MessageBox.Show("Array A[" + i + "," + j+"]=" + a[i, j]);
            //    }
            //}

            //int[][] a = new int[2][];
            ////a[0] = new int[3] { 10, 20, 30 };
            ////a[1] = new int[5] { 1, 2,3, 4, 5,6 };

            //int[] b = new int[3] { 10, 20, 30 };
            //int[] c = { 1, 2, 3, 4, 5 };
            //a[0] = b;
            //a[1] = c;
            //string st = "";

            //for(int i = 0; i < a.Length; i++)
            //{
            //    for(int j = 0; j < a[i].Length; j++)
            //    {
            //        //MessageBox.Show("ArrayA[" + i + "][" + j + "]=" + a[i][j]);
            //        st = st + "A[" + i + "][" + j + "]=" + a[i][j] + "\t";
            //    }
            //    st = st + "\n";
            //}
            //MessageBox.Show(st);
        }

        //int[] a = new int[1] { 10 };
        string[] a = new string[1];
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //int[] b = new int[a.Length + 1];
            //for (int i = 0; i < a.Length; i++) b[i] = a[i];
            //a = b;

            //MessageBox.Show(a[0] + "and" + a[1]);
            if (textRoomID.Text == "" || textRoomType.Text == "" || textRoomPrice.Text == "" || textStatus.Text == "")
            {
                MessageBox.Show("Please input all data in the box!");
            }
            else
            {
                a[a.Length - 1] = textRoomID.Text + "\t" + textRoomType.Text + "\t" + textRoomPrice + "\t" + textStatus.Text;
                string[] b = new string[a.Length + 1];
                for (int i = 0; i < a.Length; i++) b[i] = a[i];
                a = b;

                textRoomID.Focus();
                textRoomID.Clear();
                textRoomType.Clear();
                textRoomPrice.Clear();
                textStatus.Clear();
            }

        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            if (textRoomID.Text != "")
            {
                textRoomType.Clear();
                textRoomPrice.Clear();
                textStatus.Clear();

                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != null)
                    {
                        string[] st = a[i].Split('\t');
                        if (st[0] == textRoomID.Text)
                        {
                            textRoomID.Text = st[0];
                            textRoomType.Text = st[1];
                            textRoomPrice.Text = st[2];
                            textStatus.Text = st[3];
                            return;
                        }
                    }
                }
                textRoomID.Focus();
                MessageBox.Show("Search room not found!");
            }
            else
            {
                textRoomID.Focus();
                MessageBox.Show("Please enter room ID to search");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (textRoomID.Text != "")
            {
                for (int i = 0; i < a.Length; i++)
                {
                    if (a[i] != null)
                    {
                        string[] st = a[i].Split('\t');
                        if (st[0] == textRoomID.Text)
                        {
                            a = a.Where(val => val != a[i]).ToArray();

                            textRoomID.Focus();
                            textRoomID.Clear();
                            textRoomType.Clear();
                            textRoomPrice.Clear();
                            textStatus.Clear();
                            return;
                        }
                    }
                }
                textRoomID.Focus();
                MessageBox.Show("Room ID not found");
            }
            else
            {
                textRoomID.Focus();
                MessageBox.Show("Please enter room ID to delete");
            }
        }
    }
}
