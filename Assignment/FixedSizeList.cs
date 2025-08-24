using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class FixedSizeList<T>
    {
        int Capacity;
        public List<T> List;

        public FixedSizeList(int capacity)
        {
            Capacity = capacity;
            List = new List<T>();
        }

        public void Add(T item)
        {
            if (this.List.Count < Capacity)
            {
                List.Add(item);
            }
            else
            {
                throw new Exception("Error: List is Already full");
            }
        }

        public T Get(int index)
        {
            if(index < 0 || index >= this.List.Count)
                throw new ArgumentOutOfRangeException("index");
            return List[index];
        }
    }
}
