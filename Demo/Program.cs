using System.Collections;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region HashTable
            //Hashtable phoneNote =
            //    new Hashtable(new StringEqualityComparer()) //
            //{
            //    //["Yossef"] = 456,
            //    //["Manar"] = 456,
            //    {"Manar" , 444 },
            //    {"Mona" , 123 },
            //    {"Ahmed" , 222 },
            //    {"Yasser" , 333 },
            //};
            //phoneNote.Add("Ali", 555);
            //phoneNote.Add("Mostafa", 355);
            //if (phoneNote.ContainsKey("mostafa"))
            //{
            //    Console.WriteLine("This key exist");
            //}
            //else
            //{
            //    phoneNote.Add("mostafa", 456);
            //}

            //phoneNote["Omar"] = 417;
            //phoneNote["Omr"] = phoneNote["Omar"]; // get and set

            //if (phoneNote.ContainsKey("Omr"))
            //    Console.WriteLine("Exist");
            //else
            //    Console.WriteLine("Not Exist");

            //foreach (DictionaryEntry item in phoneNote)
            //{
            //    Console.WriteLine($"Key: {item.Key} \t Value: {item.Value}");
            //}

            #endregion

            #region Dictionary<TKey,TValue>

            #region Example 01
            //Dictionary<string, int> phoneNote = 
            //    new Dictionary<string, int>(new StringEqualityComparerT())
            //{
            //    {"mona",111 }, {"Yasser",222}, {"Salma",333 }
            //};


            //KeyValuePair<string, int>[] array = new KeyValuePair<string, int>[] { 

            //    new KeyValuePair<string, int>("Mona",123),
            //    new KeyValuePair<string, int>("Mona2",223),

            //};

            //if(phoneNote.ContainsKey("Mona"))
            //    Console.WriteLine("Exist");

            //bool flag = phoneNote.TryGetValue("Salma", out int num);
            //if (!flag) phoneNote.Add("Salma", num);

            //if (!phoneNote.ContainsKey("Salma"))
            //    phoneNote.Add("Salma", 333);

            //foreach(int value in phoneNote.Values)
            //    Console.WriteLine(value);

            //foreach(string key in phoneNote.Keys)
            //    Console.WriteLine(key);

            //foreach (KeyValuePair<string,int> phone in phoneNote)
            //    Console.WriteLine(phone.Key + "\t" + phone.Value);

            #endregion

            #region Example 02
            //Employee employee = new Employee(10,"Omar",20000);
            //Employee employee2 = new Employee(20,"Ahmed",40000);
            //Employee employee3 = new Employee(30,"Salma",10000);
            //Employee employee4 = new Employee(40,"Mona",30000);

            //Dictionary<Employee, string> dic = 
            //    new Dictionary<Employee, string>(new EmployeeIdEqualityComparer()); //new Dictionary<Employee,string>();

            //dic.Add(employee, "1st");
            //dic.Add(employee3, "2st");
            //dic.Add(employee4, "3st");



            #endregion

            #endregion

            #region Sorted Dictionary<TKey,TValue>

            #endregion
        }
    }
}
