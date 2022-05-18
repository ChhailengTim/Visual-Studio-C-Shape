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

namespace Episode24_access_database_command
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
            cnn.ConnectionString = "Data Source=NAME-SERVER;intitail catalog=NAME-DATABASE;integrated security=TRUE";
            cnn.Open();
            cmm.Connection = cnn;

            cmm.CommandText = "Select * from TABLE-NAME";
            da = new SqlDataAdapter(cmm);
            da.Fill(ds);
            dv = ds.Tables[0].DefaultView;
        }
    }
}
