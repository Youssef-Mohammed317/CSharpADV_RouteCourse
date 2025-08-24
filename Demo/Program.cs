using System.Collections;

namespace Demo
{
    internal class Program
    {
        static public int SumArrayList(ArrayList list)
        {
            int sum = 0;
            foreach (int item in list) // unboxing
            {
                sum += item;
            }
            return sum;
        }
        static void Main(string[] args)
        {
            #region non-generic Collections

            #region ArrayList
            //ArrayList arrayList = new ArrayList(); // auto size, non-generic, stores object

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}"); // 0,0

            //arrayList.Add(1); // capacity 4, count 1

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList.AddRange(new int[] { 2, 3, 4, 5 }); // capacity 8, count 5 // implements ICollection

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList.Insert(0, -1);

            //arrayList.Insert(arrayList.Count, 6); // add at the end else will throw exception if index is out of range

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList.InsertRange(0, new int[] { -3, -2 });

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //foreach (int item in arrayList) // there is unboxing here // casting from object to int
            //{
            //    Console.WriteLine(item);
            //}

            //arrayList.TrimToSize(); // set capacity to count

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList.Remove(3); // removes first occurrence of 3

            //arrayList.RemoveAt(0); // removes item at index 0

            //arrayList.RemoveRange(0, 2); // removes 2 items starting from index 0

            //int firstElement = (int?)arrayList[0]??0; // unboxing

            //Console.WriteLine($"First Element: {firstElement}");
            //if(arrayList.Contains(5))
            //{
            //    Console.WriteLine("ArrayList contains 5");
            //}

            //arrayList.Clear(); // clear all items

            //arrayList = new ArrayList() { 1, 2, 3, 4, 5 }; // collection initializer // capacity 5, count 5

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList = new ArrayList(); // capacity 0, count 0

            //arrayList.Add(1); // capacity 4, count 1
            //arrayList.Add(2); // capacity 4, count 2
            //arrayList.Add(3); // capacity 4, count 3
            //arrayList.Add(4); // capacity 4, count 4
            //arrayList.Add(5); // capacity 8, count 5

            //Console.WriteLine($"ArrayList Capacity: {arrayList.Capacity}, Count: {arrayList.Count}");

            //arrayList = new ArrayList(arrayList); // capacity 5, count 5 // copy constructor

            //Console.WriteLine(SumArrayList(arrayList));

            #endregion

            #endregion
        }
    }
}
