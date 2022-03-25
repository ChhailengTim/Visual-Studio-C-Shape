using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Episode20_redo_code
{
    class ClsDataDesign
    {
        public string Pro_id { set; get; }
        public string Pro_name { set; get; }
        public int Qty { set; get; }
        public double Price { set; get; }
        public ClsDataDesign(string id,string name,int q,double p)
        {
            Pro_id = id;
            Pro_name = name;
            Qty = q;
            Price = p;
        }
    }
}
