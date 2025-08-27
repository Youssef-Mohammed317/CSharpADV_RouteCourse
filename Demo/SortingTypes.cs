using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class SortingTypes
    {
        public static bool CompareAsc(int x, int y)
        {
            return x > y;
        }
        public static bool CompareDesc(int x, int y)
        {
            return x < y;
        }

        public static bool CompareAsc(string x, string y)
        {
            return x?.Length > y?.Length;
        }
        public static bool CompareDesc(string x, string y)
        {
            return x?.Length < y?.Length;
        }
    }
}
