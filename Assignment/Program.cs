
using System.Collections;
using System.Runtime.Intrinsics.X86;

namespace Assignment
{
    internal class Program
    {
        #region Q2

        static public void SortArrayList(ref ArrayList arr)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                for (int j = 0;j < arr.Count - 1;j++)
                {
                    if ((int)arr[j + 1] < (int)arr[j])
                    {
                        object temp = arr[j];

                        arr[j] = arr[j + 1];

                        arr[j + 1] = temp;
                    }
                }
            }
        }
        static public void ReverseArrayList(ref ArrayList arr)
        {
            for (int i = 0, j = arr.Count - 1; j != i && j > 0 && i < arr.Count - 1; i++, j--)
            {
                object temp = arr[j];

                arr[j] = arr[i];

                arr[i] = temp;
            }
        }
        #endregion

        #region Q3
        static public List<int> GetEven(List<int> ints)
        {
            List<int> list = new List<int>();
            foreach(int i in ints)
            {
                if(i % 2 == 0)
                    list.Add(i);
            }

            return list;
        }
        #endregion

        #region Q5
        static public int GetFirstNonRepeatedChar(string str)
        {

            bool IsRepeated = false;
            for (int i = 0; i < str.Length;i++)
            {
                IsRepeated = false;
                for(int j = 0; j < str.Length;j++)
                {
                    if(str[j] == str[i] && i != j)
                    {
                        IsRepeated = true;
                        break;
                    }
                }
                if(!IsRepeated)
                { 
                    return i;
                }
            }
            return -1;

        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            /*Create a generic Range<T> class that represents a range of values from a minimum value to a maximum value. 
                The range should support basic operations such as checking if a value is within the range and determining the length of the range.
                Requirements:
                Create a generic class named Range<T> where T represents the type of values.
                Implement a constructor that takes the minimum and maximum values to define the range.
                Implement a method IsInRange(T value) that returns true if the given  value is within the range, otherwise false.
                Implement a method Length() that returns the length of the range (the difference between the maximum and minimum values).
                Note: You can assume that the type T used in the Range<T> class implements the IComparable<T> interface to allow for comparisons.
             */

            //Range<int> range = new Range<int>(10, 100);
            //Console.WriteLine(range.Length());

            //Console.WriteLine(range.IsInRange(15));
            //Console.WriteLine(range.IsInRange(5));


            #endregion

            #region Q2:You are given an ArrayList containing a sequence of elements. 
            //try to reverse the order of elements in the ArrayList in-place(in the same arrayList)
            //without using the built-in Reverse.
            //Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.


            //ArrayList array = new ArrayList() {1,2,3,4,7,8,6,7,2,0,1,3,-4,-2,3,2 };

            //SortArrayList(ref array);

            //foreach(var a in array)
            //{
            //    Console.WriteLine(a);
            //}
            //Console.WriteLine("----------------");
            //ReverseArrayList(ref array);
            //foreach (var a in array)
            //{
            //    Console.WriteLine(a);
            //}
            #endregion

            #region Q3:You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.

            //List<int> ints = new List<int> {1,2,3,4,5,6,7,8,9,10,11,12,13,14,15};

            //List<int> list = GetEven(ints);
            //foreach(int i in list)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q4
            /*
             * implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
                Requirements:
                Create a generic class named FixedSizeList<T>.
                Implement a constructor that takes the fixed capacity of the list as a 
                parameter.
                Implement an Add method that adds an element to the list, but throws an exception if the list is already full.
                Implement a Get method that retrieves an element at a specific index in the list but throws an exception for invalid indices.
             */

            FixedSizeList<int> list = new FixedSizeList<int>(4);

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            try
            {
                list.Add(5);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0;i<4;i++)
            {
                Console.WriteLine(list.Get(i));
            }

            #endregion

            #region Q5:Given a string, find the first non-repeated character in it and return its index. If there is no such character, return 
            // Hint: you can use dictionary

            //string str = "poeeHHcpello";
            //int i = GetFirstNonRepeatedChar(str);
            //Console.WriteLine(str[i]);

            #endregion
        }
    }
}
