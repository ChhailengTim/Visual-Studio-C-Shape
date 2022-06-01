using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Episode25_store_picture_database
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr; // = new SqlDataReader();
        DataTable dt = new DataTable();
        DataRow drow;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "data source=DEVICE;initial catalog=DATABASENAME;integrate security=true";
            cnn.Open();
            cmm.Connection = cnn;

            cmm.CommandText = "Select * from DATABASENAME";
            dr = cmm.ExecuteReader();
            dr.Read();
            txtId.Text = dr[0].ToString();
            txtName.Text = dr[1].ToString();
            txtSex.Text = dr[2].ToString();
            txtPhone.Text = dr[3].ToString();

            MemoryStream ms = new MemoryStream((byte[])dr[4]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromStream(ms);
            dr.Close();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            cmm.CommandText = "select * from tblstaff";
            da = new SqlDataAdapter(cmm);
            dt = new DataTable();
            da.Fill(dt);
            drow = dt.NewRow();
            drow[0] = txtId.Text;
            drow[1] = txtName.Text;
            drow[2] = txtSex.Text;
            drow[3] = txtPhone.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            drow[4] = ms.GetBuffer();
            dt.Rows.Add(drow);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            txtId.Clear(); txtName.Clear(); txtSex.Clear(); txtPhone.Clear();
            pictureBox1.Image = null; txtId.Focus();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            //OpenFileDialog.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            //pictureBox1.Image = System.Drawing.Image.FromFile(OpenFileDialog.FileName);
        
    }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
