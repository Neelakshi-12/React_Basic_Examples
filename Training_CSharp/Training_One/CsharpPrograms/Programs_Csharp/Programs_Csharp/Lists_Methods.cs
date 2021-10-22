using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
    class Lists_Methods
    {
        static void Main(string[] args)
        {
                var list = new List<int>();
                list.Add(16);
                list.Add(23);
                list.Add(54);
                list.Add(67);

                var array = new int[3];
                array[0] = 79;
                array[1] = 62;
                array[2] = 73;

                list.AddRange(array);

            Console.WriteLine("\n______ Add range  ______\n");
            foreach (int value in list)
                {
                    Console.WriteLine("Add Range" + value);
                }
            Console.WriteLine("\n______ Add range Ends  ______\n");
            Console.ReadLine();
            Console.WriteLine("\n______ Sort   ______\n");
            var data = new List<string>() { "banana", "mango", "apple" };

                data.Sort();

            Console.WriteLine(string.Join(",", data));
            Console.WriteLine("\n______ Sort  Ends ______\n");
            Console.ReadLine();
            Console.WriteLine("\n______Binary Search______\n");
            int i = data.BinarySearch("mango");
                Console.WriteLine(i);

                i = data.BinarySearch("banana");
                Console.WriteLine(i);

                i = data.BinarySearch("apple");
                Console.WriteLine(i);
            Console.WriteLine("\n______Binary Search Ends______\n");
            Console.ReadLine();
            Console.WriteLine("\n______ Contains  ______\n");
            bool result = data.Contains("apple");
            Console.WriteLine(result);
            Console.WriteLine("\n______ Contains Ends ______\n");
            Console.ReadLine();
            List<int> numbers = new List<int>() { 10, 45, 25, 10, 1, 30, 45, 125 };
            
            int item1 = numbers.Find(x => x == 10);
            Console.WriteLine("Find : " +item1);
            
            int item3 = numbers.FindIndex(x => x == 10);
            Console.WriteLine("FindIndex : "+ item3);
            int item4 = numbers.FindLast(x => x == 10);
            Console.WriteLine("FindLast : " +item4);
            int item5 = numbers.FindLastIndex(x => x == 10);
            Console.WriteLine("FindLastIndex : "+item5);
            int item6 = numbers.IndexOf(10);
            Console.WriteLine("IndexOf : " + item6);

            int numberIndex = numbers.FindIndex(x => x == 10);

            Console.WriteLine("FindIndex : " + numberIndex);
            Console.ReadLine();
            Console.WriteLine("\n______ Remove ______\n");
            numbers.Remove(10);
            Console.WriteLine("\n______ Remove At______\n");
            numbers.RemoveAt(2); 
            foreach (var num in numbers)
                Console.WriteLine("After Removing : " +num);
            Console.ReadLine();
            numbers.Reverse();
            Console.WriteLine("reverse List items");
            Console.WriteLine("______________________");
            // Print reversed items  
            foreach (int a in numbers)
                Console.WriteLine(a);
            Console.ReadLine();
            Console.WriteLine("\n______ Get Range______\n");
            List<int> myList = numbers.GetRange(1, 3);
        }
    }
}
