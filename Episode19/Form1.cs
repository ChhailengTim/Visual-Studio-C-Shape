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
using System.Runtime.Serialization.Formatters.Binary;

namespace Episode19
{
    public partial class Form1 : Form
    {
        BinaryFormatter BF = new BinaryFormatter();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Save data into file
            FileStream Fs = new FileStream("Episode19.txt", FileMode.Append);

            product obj = new product("cigar", 100, 3.5);
            BF.Serialize(Fs, obj);
            Fs.Close();
            //Open data from file
            Fs = new FileStream("Episode19.txt", FileMode.Open);

            while(Fs.Position!=Fs.Length)
            {
                obj = (product)BF.Deserialize(Fs);
                MessageBox.Show(obj.name + "\t" + obj.qty + "\t" + obj.price);
            }
            Fs.Close();
        }
    }
    [Serializable]class product
    {
        public string name { set; get; }
        public int qty { set; get; }
        public double price { set; get; }
        public  product (string n, int q, double p) { name = n; qty = q;price = p; }
    }
}
