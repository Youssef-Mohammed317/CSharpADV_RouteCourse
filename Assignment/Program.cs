using System;
using System.Collections;

namespace Assignment
{
    internal class Program
    {
        #region Q3
        static public void ReverseQueue<T>(ref Queue<T> queue)
        {
            Stack<T> stack = new Stack<T>();
            foreach (T item in queue)
            {
                stack.Push(item);
            }
            queue.Clear();
            while (stack.Count > 0)
            {
                queue.Enqueue(stack.Pop());
            }
        }
        #endregion

        #region Q5
        static public List<int> RemoveDuplicates(int[] arr)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                bool flag = true;
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j] && i != j)
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    list.Add(arr[i]);
            }
            return list;
        }

        #endregion

        #region Q6
        static public void RemoveOddsFromList(ref List<int> list)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] % 2 != 0)
                {
                    list.RemoveAt(i);
                }
            }
        }
        #endregion

        #region Q8
        static void PushToStack(ref Stack<int> stack, int target, params int[] numbers)
        {
            foreach (int number in numbers)
            {
                stack.Push(number);
            }

            int count = 0;
            foreach (int number in stack)
            {
                count++;
                if (number == target)
                {
                    Console.WriteLine($"Number {target} found in the stack, After count {count} numbers.");
                    return;
                }
            }
            Console.WriteLine($"Number {target} not found in the stack, After count {count} numbers.");
        }
        #endregion
        static void Main(string[] args)
        {
            #region Q1:Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.

            //Console.WriteLine("Enter the size of the array and number of queries:");&
            //while (int.TryParse(Console.ReadLine(), out int ArraySize) && int.TryParse(Console.ReadLine(), out int QueryNumber) && ArraySize > 0 && QueryNumber > 0)
            //{
            //    int[] MyArray = new int[ArraySize];
            //    int[] MyQueries = new int[QueryNumber];
            //    for (int i = 0; i < ArraySize; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"Enter element {i + 1}:");
            //        } while (!int.TryParse(Console.ReadLine(), out MyArray[i]));
            //    }
            //    Console.WriteLine("---------------------------");
            //    for (int i = 0; i < QueryNumber; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"Enter Query {i + 1}:");
            //        } while (!int.TryParse(Console.ReadLine(), out MyQueries[i]));
            //    }
            //    Console.WriteLine("---------------------------");
            //    foreach (int query in MyQueries)
            //    {
            //        int count = 0;
            //        foreach (int item in MyArray)
            //        {
            //            if (item == query)
            //            {
            //                count++;
            //            }
            //        }
            //        Console.WriteLine($"Number {query} occurs {count} time(s) in the array.");
            //    }

            //}

            #endregion

            #region Q2:Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //Console.WriteLine("Enter the size of the array:");
            //while (int.TryParse(Console.ReadLine(), out int ArraySize) && ArraySize > 0)
            //{
            //    int[] MyArray = new int[ArraySize];
            //    for (int i = 0; i < ArraySize; i++)
            //    {
            //        do
            //        {
            //            Console.WriteLine($"Enter element {i + 1}:");
            //        } while (!int.TryParse(Console.ReadLine(), out MyArray[i]));
            //    }

            //    Console.WriteLine("---------------------------");

            //    bool IsPalindrome = true;

            //    for(int i = 0; i < ArraySize / 2; i++)
            //    {
            //        if(MyArray[i] != MyArray[ArraySize - 1 - i])
            //        {
            //            IsPalindrome = false;
            //            break;
            //        }
            //    }
            //    if (IsPalindrome)
            //    {
            //        Console.WriteLine("The array is a palindrome.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The array is not a palindrome.");
            //    }
            //}

            #endregion

            #region Q3:Given a Queue, implement a function to reverse the elements of a queue using a stack.

            //Queue<int> MyQueue = new Queue<int>();
            //MyQueue.Enqueue(1);
            //MyQueue.Enqueue(2);
            //MyQueue.Enqueue(3);
            //MyQueue.Enqueue(4);
            //MyQueue.Enqueue(5);

            //Console.WriteLine("Initial Queue:");
            //foreach (int item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("---------------------------");
            //ReverseQueue<int>(ref MyQueue);
            //Console.WriteLine("Reversed Queue:");
            //foreach (int item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q4:Given a Stack, implement a function to check if a string of parentheses is balanced using a stack.

            //string input = "{[{}](){}}";

            //Stack<char> stack = new Stack<char>();
            //bool IsBalanced = true;
            //foreach (char c in input)
            //{
            //    if (c == '{' || c == '[' || c == '(')
            //    {
            //        stack.Push(c);
            //    }
            //    else if (c == '}' || c == ']' || c == ')')
            //    {
            //        if (stack.Count == 0)
            //        {
            //            IsBalanced = false;
            //            break;
            //        }
            //        char top = stack.Pop();
            //        if ((c == '}' && top != '{') || (c == ']' && top != '[') || (c == ')' && top != '('))
            //        {
            //            IsBalanced = false;
            //            break;
            //        }
            //    }
            //}
            //if (stack.Count == 0)
            //{
            //    IsBalanced = true;
            //}
            //else
            //{
            //    IsBalanced = false;
            //}
            //if (IsBalanced)
            //{
            //    Console.WriteLine("The string is balanced.");
            //}
            //else
            //{
            //    Console.WriteLine("The string is not balanced.");
            //}

            #endregion

            #region Q5:Given an array, implement a function to remove duplicate elements from an array.

            //int[] MyArray = { 1, 2, 3, 4, 4, 5, 6, 1, 2 };

            //foreach(int i in RemoveDuplicates(MyArray))
            //{
            //    Console.WriteLine(i);
            //}

            #endregion

            #region Q6:Given an array list , implement a function to remove all odd numbers from it.

            //List<int> MyList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //RemoveOddsFromList(ref MyList);

            //MyList.RemoveAll((i) => i % 2 != 0); // Using Lambda Expression to remove odd numbers

            //foreach (int item in MyList)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Q7:Implement a queue that can hold different data types. 
            //And insert the following data:
            //queue.Enqueue(1)
            //queue.Enqueue(“Apple”)
            //queue.Enqueue(5.28)

            //Queue<object> MyQueue = new Queue<object>();
            //MyQueue.Enqueue(1);
            //MyQueue.Enqueue("Apple");
            //MyQueue.Enqueue(5.28);

            #endregion

            #region Q8:Create a function that pushes a series of integers onto a stack. Then, search for a target integer in the stack. If the target is found, print a message indicating that the target was found how many elements were checked before finding the target (“Target was found successfully and the count = 5”). If the target is not found, print a message indicating that the target was not found(“Target was not found”).

            //Stack<int> MyStack = new Stack<int>();

            //int target = 3;

            //PushToStack(ref MyStack, target,/*prams*/1, 2, 0, 3, 5); // count from end // 2

            //PushToStack(ref MyStack, target,/*prams*/1, 2, 0, 4, 5); // 2+5=7 times
            //target = -1;
            //PushToStack(ref MyStack, target,/*prams*/1, 2, 0, 4, 5); // not found

            #endregion

            #region Q9:Given two arrays, find their intersection. Each element in the result should appear as many times as it shows in both arrays.

            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 2, 3, 3 ,10,4, 4};

            //Dictionary<int, int> result = new Dictionary<int, int>();

            //foreach (int i in arr1)
            //{
            //    foreach (int j in arr2)
            //    {
            //        if (i == j)
            //        {
            //            if (result.ContainsKey(i))
            //            {
            //                result[i]++;
            //            }
            //            else
            //            {
            //                result[i] = 1;
            //            }
            //        }
            //    }
            //}

            //foreach (KeyValuePair<int, int> kvp in result)
            //{
            //    Console.WriteLine($"Number {kvp.Key} occurs {kvp.Value} time(s) in both arrays.");
            //}

            #endregion

            #region Q10:Given an ArrayList of integers and a target sum, find if there is a contiguous sub list that sums up to the target.

            List<int> MyList = new List<int> { 1, 2, 3, 4 };

            int TargetSum = 10;

            MyList.Sort();

            foreach (int i in MyList)
            {
                if (i > TargetSum)
                {
                    MyList.Remove(i);
                }
            }

            List<List<int>> result = GetSubsets(MyList); // list of all sub-lists

            List<List<int>> result2 = new List<List<int>>(); // list of all sub-lists

            //MakeSubListsOfListItems(ref result, MyList);


            for (int i = 0; i < result.Count; i++)
            {   
                int sum = SumList(result[i]);
                if (sum == TargetSum)
                {
                    result2.Add(result[i]);
                }
            }


            foreach (var lst in result2)
            {
                Console.Write("[ ");
                foreach (var item in lst)
                {
                    Console.Write(item + " ");
                }
                Console.WriteLine("]");
            }


            #endregion

            #region Q11:Given a queue reverse first K elements of a queue, keeping the remaining elements in the same order 

            //Queue<int> MyQueue = new Queue<int>();
            //MyQueue.Enqueue(1);
            //MyQueue.Enqueue(2);
            //MyQueue.Enqueue(3);
            //MyQueue.Enqueue(4);
            //MyQueue.Enqueue(5);
            //int K = 3;
            //Stack<int> stack = new Stack<int>();
            //for (int i = 0; i < K; i++)
            //{
            //    stack.Push(MyQueue.Dequeue());
            //}
            //Queue<int> tempQueue = new Queue<int>();
            //while (MyQueue.Count > 0)
            //{
            //    tempQueue.Enqueue(MyQueue.Dequeue());
            //}
            //while (stack.Count > 0)
            //{
            //    MyQueue.Enqueue(stack.Pop());
            //}
            //while (tempQueue.Count > 0)
            //{
            //    MyQueue.Enqueue(tempQueue.Dequeue());
            //}
            //foreach (int item in MyQueue)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

        }

        //static public List<int> MakeSubListsOfListItems(ref List<List<int>> MyListOfSubLists, List<int> MyList)
        //{
        //    for (int i = 0; i < MyList.Count; i++)
        //    {
        //        List<int> sublist = new List<int>();
        //        sublist.Add(MyList[i]);
        //        MyListOfSubLists.Add(sublist);
        //        for (int j = i + 1; j < MyList.Count; j++)
        //        {
        //            List<int> sublist2 = new List<int>();
        //            sublist2.Add(MyList[j]);
        //            sublist2.Add(MyList[i]);
        //            MyListOfSubLists.Add(sublist2);
        //            for (int k = j + 1; k < MyList.Count; k++)
        //            {
        //                List<int> sublist3 = new List<int>();
        //                sublist3.Add(MyList[k]);
        //                sublist3.Add(MyList[j]);
        //                sublist3.Add(MyList[i]);
        //                MyListOfSubLists.Add(sublist3);
        //                for (int l = k + 1; l < MyList.Count; l++)
        //                {
        //                    List<int> sublist4 = new List<int>();
        //                    sublist4.Add(MyList[l]);
        //                    sublist4.Add(MyList[k]);
        //                    sublist4.Add(MyList[j]);
        //                    sublist4.Add(MyList[i]);
        //                    MyListOfSubLists.Add(sublist4);
        //                }
        //            }
        //        }
        //    }
        //    return new List<int>();
        //}
        static public List<List<int>> GetSubsets(List<int> nums)
        {
            var result = new List<List<int>>();
            int n = nums.Count;
            int total = 1 << n; // 2^n subsets

            for (int mask = 0; mask < total; mask++)
            {
                var subset = new List<int>();
                for (int i = 0; i < n; i++)
                {
                    if ((mask & (1 << i)) != 0)
                    {
                        subset.Add(nums[i]);
                    }
                }
                result.Add(subset);
            }

            return result;
        }

        static public int SumList(List<int> ints)
        {
            int sum = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                sum += ints[i];
            }
            return sum;
        }

    }
}
