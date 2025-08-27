using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal static class FunctionsReturnsDelegate
    {
        public static Action GetAction()
        {
            return () => Console.WriteLine("Hello from Action delegate!");
        }

        public static Predicate<int> GetPredicate()
        {
            return (x) => x % 2 == 0; // Checks if a number is even
        }

        public static Func<int, int, int> GetFunc()
        {
            return (a, b) => a + b; // Adds two integers
        }
    }
}
