using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show18
{
    class ClsDataDesign
    {
        public string Room { set; get; }
        public string cust_name { set; get; }
        public string date { set; get; }
        public ClsDataDesign(string r,string n, string d){
            Room = r; cust_name = n; date = d;
        }
    }
}
