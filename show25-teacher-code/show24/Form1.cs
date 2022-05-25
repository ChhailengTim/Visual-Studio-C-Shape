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
namespace show24
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();

        SqlDataAdapter da = new SqlDataAdapter();
        DataSet ds = new DataSet();
        DataView dv = new DataView();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=desktop-25ncc32;initial catalog=library;integrated security=true";
            cnn.Open();
            cmm.Connection = cnn;

            cmm.CommandText = "Select * from TblBook";
            da = new SqlDataAdapter(cmm);
            ds = new DataSet();
            da.Fill(ds);
            dv = ds.Tables[0].DefaultView;

            //dataGridView1.DataSource = dv;

            txtBid.DataBindings.Add(new Binding("text", dv, "Book_id"));
            txtBtitle.DataBindings.Add(new Binding("text", dv, "B_title"));
            txtQty.DataBindings.Add(new Binding("text", dv, "qty"));
            txtAuthor.DataBindings.Add(new Binding("text", dv, "author"));
            txtDates.DataBindings.Add(new Binding("text", dv, "Dates"));
        }

        private void tbnUpdate_Click(object sender, EventArgs e)
        {
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Update(ds);
            MessageBox.Show("Update completed");
        }

        private void dataGridView1_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            dataGridView1.Rows[e.Row.Index - 1].Cells[5].Value = "Add New";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            if (e.ColumnIndex == 5) {
                if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Add New")) { 
                    //Command Insert SQL statement
                    MessageBox.Show("Add completed");
                    dataGridView1.Rows[e.RowIndex].Cells[5].Value = "Delete";
                }
                else if (dataGridView1.Rows[e.RowIndex].Cells[5].Value.Equals("Delete"))
                {
                    //Command Delete SQL statement
                }
            }
        }
    }
}
