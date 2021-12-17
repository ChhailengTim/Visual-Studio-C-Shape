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

namespace Epiose9_PictureBox
{
    public partial class Form1 : Form
    {

        byte[][] store=new byte[1][];
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All File|*.*|Text File|*.text|Image|*.jpg;*.bmp;*.gif"; //"Label|*.Extention|...;
            openFileDialog1.ShowDialog();

            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
            //pictureBox1.ImageLocation = openFileDialog1.FileName; //@"c:\image.jpg";
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            store[store.Length - 1] = ms.GetBuffer();

            listBox1.Items.Add(store[store.Length - 1]);

            byte[][] b = new byte[store.Length + 1][];
            for (int i = 0; i < store.Length; i++) b[i] = store[i];
            store = b;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItems.Count > 0)
            {
                MemoryStream ms = new MemoryStream((byte[])listBox1.SelectedItem);
                pictureBox1.Image = Image.FromStream(ms);
            }
        }
    }
}
