using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass6
{
    internal class Range<T> where T : IComparable<T>
    {
        public T Min { set; get; }
        public T Max { set; get; }


        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public int Length()
        {
            dynamic a = Max;
            dynamic b = Min;
            return a - b;
        }
}
}