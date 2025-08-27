using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class StringFunctions
    {
        public static int GetCountOfUppercaseLetters(string input)
        {
            //if (string.IsNullOrEmpty(input))
            //{
            //    return 0;
            //}

            int count = 0;
            if(input?.Length > 0)
                foreach (char c in input)
                {
                    if (char.IsUpper(c))
                        count++;
                }
            return count;
        }
        public static int GetCountOfLowercaseLetters(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return 0;
            }
            int count = 0;
            foreach (char c in input)
            {
                if (char.IsLower(c))
                    count++;
            }
            return count;
        }
    }
}
