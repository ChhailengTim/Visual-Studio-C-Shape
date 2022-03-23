using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace show20
{
    class ClsSource: List<ClsDataDesign>
    {
        public ClsSource() {
            Add(new ClsDataDesign("p001", "cocacola", 100, 8.5));
            Add(new ClsDataDesign("p002", "7-up", 100, 7.5));
            Add(new ClsDataDesign("p003", "tiger", 100, 22.5));
            Add(new ClsDataDesign("p004", "anchor", 100, 15.5));
        }
    }
}
