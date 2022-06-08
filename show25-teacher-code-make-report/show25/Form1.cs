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

namespace show25
{
    public partial class Form1 : Form
    {

        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlDataReader dr;// = new SqlDataReader();
        DataTable dt = new DataTable();
        DataRow drow;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "data source=desktop-25ncc32;initial catalog=library;integrated security=true";
            cnn.Open();
            cmm.Connection = cnn;

            cmm.CommandText = "Select * from tblstaff";
            dr = cmm.ExecuteReader();
            dr.Read();
            txtID.Text = dr[0].ToString();
            txtName.Text = dr[1].ToString();
            txtSex.Text = dr[2].ToString();
            txtPhone.Text = dr[3].ToString();
            MemoryStream ms = new MemoryStream((byte[]) dr[4]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = Image.FromStream(ms);
            dr.Close();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            cmm.CommandText = "select * from tblstaff";
            da = new SqlDataAdapter(cmm);
            dt = new DataTable();
            da.Fill(dt);
            drow = dt.NewRow();
            drow[0] = txtID.Text;
            drow[1] = txtName.Text;
            drow[2] = txtSex.Text;
            drow[3] = txtPhone.Text;
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms,pictureBox1.Image.RawFormat);
            drow[4] = ms.GetBuffer();
            dt.Rows.Add(drow);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(dt);
            txtID.Clear(); txtName.Clear(); txtSex.Clear(); txtPhone.Clear();
            pictureBox1.Image = null; txtID.Focus();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Form F = new Form2(txtID.Text);
            F.Show();
        }
        int i=0;
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (btnsave.Text == "Save")
            {
                cmm.CommandText = "select * from tblstaff";
                da = new SqlDataAdapter(cmm);
                dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0) i = 0;
                else return;                    
                    btnsave.Text = "New";                
            }
            i++; if (i >= dt.Rows.Count) i = 0;
            drow = dt.Rows[i];
            txtID.Text = drow[0].ToString();
            txtName.Text = drow[1].ToString();
            txtSex.Text = drow[2].ToString();
            txtPhone.Text = drow[3].ToString() ;
            MemoryStream ms = new MemoryStream((byte[]) drow[4]);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
