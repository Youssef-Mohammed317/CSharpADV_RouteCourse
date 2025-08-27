using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{

    internal static class FilterLists
    {
        public static List<T> Filter<T>(List<T> list, Func<T, bool> filterBy)
        {
            List<T> result = new List<T>();
            if (list?.Count > 0 && filterBy is not null)
            {
                foreach (T item in list)
                {
                    if (filterBy.Invoke(item))
                    {
                        result.Add(item);
                    }
                }
            }
            return result;
        }
    }
}
