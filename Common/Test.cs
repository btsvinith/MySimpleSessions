using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    internal class Test
    {
        public void Testmethod()
        {
            Sorting sorting = new Sorting();
            sorting.ArrangeValues(new List<int>(), true);
        }
    }
}
