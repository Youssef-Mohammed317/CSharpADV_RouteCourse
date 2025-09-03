using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class StringEqualityComparerT : IEqualityComparer<string>
    {
        public bool Equals(string? x, string? y)
        {
            return x?.ToLower().Equals(y?.ToLower()) ?? false;
        }

        public int GetHashCode([DisallowNull] string obj)
        {
            return obj?.ToLower()?.GetHashCode() ?? 0;
        }
    }
}
