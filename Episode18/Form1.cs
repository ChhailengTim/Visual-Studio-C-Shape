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

namespace Episode18
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
            //FileStream Fs = new FileStream("Episode18.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(Fs);
            //sw.WriteLine("nara@male@0123456789");
            //sw.Close();
            //Fs.Close();

            //FileStream Fs = new FileStream("Episode18.txt", FileMode.Open);
            //StreamReader sr = new StreamReader(Fs);

            //while (!sr.EndOfStream)
            //{
            //    MessageBox.Show(sr.ReadLine());
            //}
            //Fs.Close();
        }

        private void textRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //FileStream Fs = new FileStream("holtel.txt", FileMode.Append);
            //StreamWriter sw = new StreamWriter(Fs);
            //sw.WriteLine( textRoom.Text +"/" + textCustName.Text +"/"+ textDate.Text);
            //sw.WriteLine("Customer Name :" + textCustName.Text);
            //sw.WriteLine("Date :" + textDate.Text);
            //sw.Close();
            //Fs.Close();

            FileStream Fs = new FileStream("HomeWork.txt", FileMode.Append);
            RoomID obj = new RoomID(textRoom.Text);
            BF.Serialize(Fs, obj);
            CusName obj1 = new CusName(textCustName.Text);
            BF.Serialize(Fs,obj1);
            Days obj2 = new Days(textDate.Text);
            BF.Serialize(Fs, obj2);
            Fs.Close();


        }
        [Serializable]
        class RoomID
        {
            public string id { set; get; }
            public RoomID(string roomid) { id = roomid;  }
        }
        [Serializable]
        class CusName
        {
            public string name { set; get; }
            public CusName(string cusname) { name = cusname; }
        }
        [Serializable]
        class Days
        {
            public string day { set; get; }
            public Days(string date) { day = date; }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FileStream Fs = new FileStream("HomeWork.txt", FileMode.Open);
            RoomID obj = new RoomID(textRoom.Text);
            CusName obj1 = new CusName(textCustName.Text);
            Days obj2 = new Days(textDate.Text);

            while (Fs.Position != Fs.Length)
                {
                obj = (RoomID)BF.Deserialize(Fs);
                obj1 = (CusName)BF.Deserialize(Fs);
                obj2 = (Days)BF.Deserialize(Fs);
                MessageBox.Show(obj.id+"\t"+obj1.name+"\t"+obj2.day);
            }
            Fs.Close();
        }

        //    private void btnShow_Click(object sender, EventArgs e)
        //    {
        //        FileStream Fs = new FileStream("holtel.txt", FileMode.Open);
        //       StreamReader sr = new StreamReader(Fs);
        //        MessageBox.Show(sr.ReadLine());
        //        string st = "";
        //        while (!sr.EndOfStream)
        //        {
        //            st += sr.ReadLine() + "\n";
        //        }
        //        MessageBox.Show(st);
        //        Fs.Close();
        //    }
    }
}
