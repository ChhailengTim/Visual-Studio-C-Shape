using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show18
{
    public partial class Form2 : Form
    {
        ListView L;
        public Form2(ListView Lst)
        {
            InitializeComponent();
            L = Lst;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ClsDataDesignBindingSource.DataSource = new ClsSource(L);
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
