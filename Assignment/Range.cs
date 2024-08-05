using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    class Range<T> where T : IComparable<T>
    {

        public dynamic Min { get; set; }
        public dynamic Max { get; set; }


        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T Value)
        {
            return Value.CompareTo(Min) >= 0 && Value.CompareTo(Max) <= 0;
        }

        public T Length()
        {
            return Max - Min;
        }

    }
}
