using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show25
{
    public partial class Form2 : Form
    {
        string store;
        public Form2(string id)
        {
            InitializeComponent();
            store = id;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'LibraryDataSet.TblStaff' table. You can move, or remove it, as needed.
            this.TblStaffTableAdapter.Fill(this.LibraryDataSet.TblStaff,store);

            this.reportViewer1.RefreshReport();
        }
    }
}
