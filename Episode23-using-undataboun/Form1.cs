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

namespace Episode23_using_undataboun
{
    public partial class Form1 : Form
    {
        SqlConnection cnn = new SqlConnection();
        SqlCommand cmm = new SqlCommand();
        SqlDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cnn.ConnectionString = "Data Source=NAME;Intial catalog=DATABASE-NAME;Integrated Security=True";
            cnn.Open();
            cmm.Connection = cnn;

            //SQL statements; (Execute: Insert,Delete,Update,Select:)
                                //Delete From TABLE where condition
                                //Update TABLE set f1=v,f2=v,... where condition
            //cmm.CommandText = "Insert into TABLE_NAME values('data','data','data','data')";
            //cmm.ExecuteNonQuery();

            cmm.CommandText = "Select * from TABLE_NAME";
            dr = cmm.ExecuteReader();
            while (dr.Read())
            {
                MessageBox.Show(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4]);
            }
            dr.Close();
        }
    }
}
