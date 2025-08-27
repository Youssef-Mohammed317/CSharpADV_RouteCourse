using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class FilterTypes
    {
        public static bool IsEven(int x) => x % 2 == 0;
        public static bool IsOdd(int x) => x % 2 != 0;

        public static bool IsPositive(int x) => x > 0;
        public static bool IsNegative(int x) => x < 0;
        public static bool IsPrime(int x)
        {
            if (x <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(x); i++)
            {
                if (x % i == 0) return false;
            }
            return true;
        }
        public static bool IsPalindrome(string str)
        {
            char[] arr = str.ToCharArray();
            Array.Reverse(arr);
            string reversedStr = new string(arr);
            return str == reversedStr;
        }
        public static bool ChecksLengthGreaterThan(string str, int length) => str?.Length > length;
        public static bool ChecksLengthLessThan(string str, int length) => str?.Length < length;

        public static bool IsDivisibleBy(int x, int divisor) => divisor != 0 && x % divisor == 0;
    }
}
