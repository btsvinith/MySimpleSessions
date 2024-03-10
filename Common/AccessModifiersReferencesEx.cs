using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common
{
    internal class AccessModifiersReferencesEx
    {
       
        //public The code is accessible for all classes
        public List<T> GetArrangeValues<T>(List<T> values, bool isAsc)
        {
            return ArrangeValues(values, isAsc);
        }

        //protected The code is accessible within the same class, or in a class that is inherited from that class.
        protected List<T> ArrangeValuesProtected<T>(List<T> values, bool isAsc)
        {
            return ArrangeValues(values, isAsc);
        }

        //internal The  member can be accessed by any code in the same assembly, but not from another assembly.
        internal List<T> ArrangeValuesInternal<T>(List<T> values, bool isAsc)
        {
            return ArrangeValues(values, isAsc);
        }

        //protected internal The member can be accessed by any code in the assembly in which it's declared, or from within a derived class in another assembly.
       protected internal List<T> ArrangeValuesProtectedInternal<T>(List<T> values, bool isAsc)
        {
            return ArrangeValues(values, isAsc);
        }

        //Private The code is only accessible within the same class
        private List<T> ArrangeValues<T>(List<T> values, bool isAsc)
        {
            // Creating the empty container, as the size of input parameter size
            IEnumerable<T> result = new List<T>();

            // Order the input array and assign it to result
            if (isAsc)
                result = values.OrderBy(x => x);
            else
                result = values.OrderByDescending(x => x);

            // Return the arranged numbers/values.
            return result.ToList();
        }

    }
}
