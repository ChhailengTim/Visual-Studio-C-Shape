using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace show18
{
    class ClsSource: List<ClsDataDesign>
    {
        public ClsSource(ListView Lst) {            
            for(int i=0; i<Lst.Items.Count; i++){
                Add(new ClsDataDesign(Lst.Items[i].SubItems[0].Text,
                                      Lst.Items[i].SubItems[1].Text,
                                      Lst.Items[i].SubItems[2].Text));
                }
        }
    }
}
