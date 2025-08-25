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
        }
    }
}
