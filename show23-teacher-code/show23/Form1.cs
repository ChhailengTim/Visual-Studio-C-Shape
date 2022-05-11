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

namespace show23
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
            cnn.ConnectionString = "Data Source=DESKTOP-25NCC32;Initial catalog=Library;Integrated Security=True";
            cnn.Open();
            cmm.Connection = cnn;
            //SQL statements; (Execute: Insert,Delete,Update ,Select:)
                               //Delete From Table1 where condition
                               //Update Table1 set f1=v,f2=v,... where condition
            //cmm.CommandText = "Insert into TblReader values('R1','Nana','student','PP','017909090')";
            //cmm.ExecuteNonQuery();
            cmm.CommandText = "Select * from TblReader";
            dr = cmm.ExecuteReader();
            while (dr.Read()) {
                MessageBox.Show(dr[0] + "\t" + dr[1] + "\t" + dr[2] + "\t" + dr[3] + "\t" + dr[4]);
            }
            dr.Close();
        }
    }
}
