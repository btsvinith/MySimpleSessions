using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Test : AgeCalculator
    {
        private void TestMethod()
        {
            AgeCalculator ageCalculator = new AgeCalculator();
            GetAgeProtected(new DateTime());
            GetAgeProtectedInternal(new DateTime());
            ageCalculator.GetAgeProtectedInternal(new DateTime());
        }
    }
}
