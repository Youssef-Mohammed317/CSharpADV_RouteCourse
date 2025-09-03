using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringEqualityComparer : IEqualityComparer
    {
        public new bool Equals(object? x, object? y)
        {

            //return x?.ToString()?.ToLower() == y?.ToString()?.ToLower();
            return ((string?)x)?.ToLower().Equals(((string?)y)?.ToLower()) ?? false;
        }

        public int GetHashCode(object obj)
        {
            //throw new NotImplementedException();
            return ((string?)obj)?.ToLower()?.GetHashCode() ?? throw new Exception("Message");
        }
    }
}
