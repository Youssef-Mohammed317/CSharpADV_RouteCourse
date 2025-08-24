using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Range<T> where T : IComparable<T>
    {

        public T Min { get; set; }
        public T Max { get; set; }
        public Range(T min, T max)
        {
            Min = min;
            Max = max;
        }

        public bool IsInRange(T value)
        {
            return value.CompareTo(Min) >= 0 && value.CompareTo(Max) <= 0;
        }

        public double Length()
        {
            try
            {
                double minVal = Convert.ToDouble(Min);
                double maxVal = Convert.ToDouble(Max);
                return maxVal - minVal;
            }
            catch
            {
                throw new InvalidOperationException("Length() is only supported for numeric types.");
            }
        }
        public override string ToString()
        {
            return $"Range: [{Min}, {Max}]";
        }
    }
}
