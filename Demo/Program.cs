namespace Demo
{
    public delegate int GetCountOfUppercaseLettersDelegate(string input);
    // new delegate type [Class]
    // ref from delegate instance can be used to call the method or more
    // apply the signature of the delegate type
    // can be used to call static or instance method

    

    internal class Program
    {
        delegate void Del(in int a,out int b, out int c);
        static public void Compare(in int a, out int b, out int c)
        {
            b = a * a;
            c = b * a;
        }
        static void Main(string[] args)
        {
            #region Example 01
            ////int x = StringFunctions.GetCountOfUppercaseLetters; // invalid

            //GetCountOfUppercaseLettersDelegate del;
            ////del = new GetCountOfUppercaseLettersDelegate(StringFunctions.GetCountOfUppercaseLetters);
            //del = StringFunctions.GetCountOfUppercaseLetters;
            //del += StringFunctions.GetCountOfUppercaseLetters;
            //del += StringFunctions.GetCountOfLowercaseLetters;

            ////del -= StringFunctions.GetCountOfLowercaseLetters;
            ////del -= StringFunctions.GetCountOfUppercaseLetters;

            ////del = null;


            //int x = del?.Invoke("Hello World! This Is A Test.") ?? 0;

            //Console.WriteLine(x);
            #endregion

            #region Example 02
            //int[] arr = { 5, 3, 8, 4, 2 };

            //SortingAlgorithms<int>.BubbleSort(arr, SortingTypes.CompareAsc);

            //SortingAlgorithms<int>.BubbleSort(arr, SortingTypes.CompareDesc);

            //SortingAlgorithms<int>.BubbleSort(arr, (a, b) => a > b);

            //SortingAlgorithms<int>.BubbleSort(arr, (a, b) => a < b);


            //Console.WriteLine(string.Join(", ", arr));

            //string[] strings = { "Hello", "world", "This", "is", "a", "Test" };

            ////SortingAlgorithms<string>.BubbleSort(strings, (a, b) => a.Length > b.Length);
            //SortingAlgorithms<string>.BubbleSort(strings, SortingTypes.CompareAsc);
            //Console.WriteLine(string.Join(", ", strings));
            #endregion

            #region Example 03
            //List<int> numbers = Enumerable.Range(0, 100).ToList(); // new List<int> { 5, 3, 8, 4, 2 };

            ////List<int> evenNumbers = FilterLists.Filter(numbers, n => n % 2 == 0);
            ////List<int> oddNumbers = FilterLists.Filter(numbers, n => n % 2 != 0);

            //List<int> evenNumbers = FilterLists.Filter(numbers, FilterTypes.IsEven);
            //List<int> oddNumbers = FilterLists.Filter(numbers, FilterTypes.IsOdd);
            //List<int> div = FilterLists.Filter(numbers, (a) => FilterTypes.IsDivisibleBy(a,7));

            //Console.WriteLine($"Even Numbers: {string.Join(", ", evenNumbers)}");
            //Console.WriteLine($"Odd Numbers: {string.Join(", ", oddNumbers)}");

            //Console.WriteLine($"Divisible by 7: {string.Join(", ", div)}");

            //List<string> words = new List<string>
            //{
            //    "level", "world", "radar", "hello", "civic", "test", "deified", "example", "rotor"
            //};

            //List<string> palindromes = FilterLists.Filter(words, FilterTypes.IsPalindrome);

            //Console.WriteLine($"Palindromes: {string.Join(", ", palindromes)}");

            //List<string> longWords = FilterLists.Filter(words, (s) => FilterTypes.ChecksLengthGreaterThan(s, 4));
            //Console.WriteLine($"Words with length greater than 4: {string.Join(", ", longWords)}");

            //List<string> shortWords = FilterLists.Filter(words, (s) => FilterTypes.ChecksLengthLessThan(s, 5));
            //Console.WriteLine($"Words with length less than 5: {string.Join(", ", shortWords)}");
            #endregion

            #region Example 04
            //Predicate<int> predicate = FilterTypes.IsEven;

            //predicate.Invoke(14);
            //predicate(14);

            //Func<int, bool> func = FilterTypes.IsEven;
            //func.Invoke(14);
            //func(14);

            //Action<string> action = Console.WriteLine;
            //action.Invoke("Hello World!");
            //action("Hello World!");

            //Action<int> action1 = (x) => Console.WriteLine(x * x);
            //action1(5);
            //action1(10);

            #endregion

            #region Example 05
            //del dele = Compare;
            //int b, c;
            //dele(5, out b,out c);

            //Console.WriteLine(b);
            //Console.WriteLine(c);
            #endregion

            #region Example 06

            //Action<string> action = delegate (string s) {
            //    Console.WriteLine(s);
            //};

            //Func<int, string> Number = delegate (int n)
            //{
            //    return n.ToString();
            //};

            //Func<int, int, int> Add = delegate (int a, int b)
            //{
            //    return a + b;
            //};

            //Func<int, int, int> Add2 =  (int a, int b) =>
            //{
            //    int c = a + b;
            //    return c;
            //};
            //Func<int, int, int> Add3 =  (a, b) =>
            //{
            //    int c = a + b;
            //    return c;
            //};
            //Func<int, int, int> Add4 = (int a, int b) => a + b;

            //Func<int, int, int> Add5 = (a, b) => a + b;

            //Func<int, int> func = a => a + a;

            //Func<int> func2 = () => 10;

            #endregion

            #region Example 07
            //List<int> list = [1, 2, 3, 4, 5, 6, 7];

            //bool flag = list.Exists(x => x == 2);

            //Console.WriteLine(flag);

            //int num = list.Find(x => x % 2 != 0);

            //int num2 = list.FindLast(x => x % 2 != 0);

            //List<int> oddNumbers = list.FindAll(x => x % 2 != 0);

            //Console.WriteLine(string.Join(", ", oddNumbers));

            //int index = list.FindIndex(x => x % 2 != 0);

            //int index2 = list.FindLastIndex(x => x % 2 != 0);

            //List<int> newList = list.ConvertAll(x => x * x);

            //Console.WriteLine(string.Join(", ", newList));

            //newList.ForEach(x => Console.WriteLine(x));

            ////newList.Sort((a, b) => b - a);

            //list.RemoveAll(x => x % 2 == 0);

            //Console.WriteLine(string.Join(", ", list));

            #endregion

            #region Example 08

            //Action action = FunctionsReturnsDelegate.GetAction();

            //action();
            //FunctionsReturnsDelegate.GetAction().Invoke();
            //FunctionsReturnsDelegate.GetAction()();

            //Predicate<int> predicate = FunctionsReturnsDelegate.GetPredicate();
            //bool isEven = predicate(10);
            //Console.WriteLine(isEven);

            //bool isOdd = FunctionsReturnsDelegate.GetPredicate()(11);
            //Console.WriteLine(isOdd);

            //Func<int, int, int> func = FunctionsReturnsDelegate.GetFunc();
            //int sum = func(5, 10);
            //Console.WriteLine(sum);

            //int sum2 = FunctionsReturnsDelegate.GetFunc()(20, 30);
            //Console.WriteLine(sum2);
            
            #endregion
        }
    }
}
