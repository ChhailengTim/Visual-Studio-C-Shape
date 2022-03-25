using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace show18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (!File.Exists("E7file.txt"))
            //{
            //    FileStream Fs = new FileStream("E7file.txt", FileMode.CreateNew);
            //}
            //else {
                //FileStream Fs = new FileStream("E7file.txt", FileMode.Append);
                //StreamWriter sw = new StreamWriter(Fs);
                //sw.WriteLine("nara@female@013909090");
                //sw.Close(); Fs.Close();
            //}
            //FileStream Fs = new FileStream("E7file.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(Fs);
            //while (!sr.EndOfStream)
            //{
            //    MessageBox.Show(sr.ReadLine());
            //}
            //Fs.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            ListViewItem T = listView1.Items.Add(txtRoom.Text);
            T.SubItems.Add(txtCustName.Text);
            T.SubItems.Add(txtDate.Text);
            txtRoom.Clear(); txtDate.Clear(); txtCustName.Clear(); txtRoom.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {            
            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            FileStream Fs = new FileStream(saveFileDialog1.FileName, FileMode.Create);
            StreamWriter sw = new StreamWriter(Fs);
            for (int i = 0; i < listView1.Items.Count; i++)
            {
                sw.WriteLine(listView1.Items[i].Text + "@" + 
                             listView1.Items[i].SubItems[1].Text + "@" + 
                             listView1.Items[i].SubItems[2].Text);
            }
            listView1.Items.Clear();
            sw.Close(); Fs.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            FileStream Fs = new FileStream(openFileDialog1.FileName, FileMode.Open);
            StreamReader sr = new StreamReader(Fs);
            string[] st;
            listView1.Items.Clear();
            while (!sr.EndOfStream)
            {
                st = sr.ReadLine().Split('@');
                ListViewItem T = listView1.Items.Add(st[0]);
                T.SubItems.Add(st[1]);
                T.SubItems.Add(st[2]);
            }
            
            Fs.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form F = new Form2(listView1);
            F.Show();
        }
    }
}
