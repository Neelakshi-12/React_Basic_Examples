using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Largest_Number2
    {
        static void Main()
        {
             Console.WriteLine("Enter Any Three Numbers");
            int SIZE = 3;
            int[] array = new int[SIZE];
            int largestNumber = 0, secondLargeNumber = 0;
            for (int i = 0; i < SIZE; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (array[0] < array[1])
            {
                largestNumber = array[1];
                secondLargeNumber = array[0];
            }
            else
            {
                largestNumber = array[0];
                secondLargeNumber = array[1];
            }
            for (int i = 2; i < SIZE; i++)
            {
                if (array[i] > largestNumber)
                {
                    secondLargeNumber = largestNumber;
                    largestNumber = array[i];
                }
                else if (array[i] > secondLargeNumber)
                {
                    secondLargeNumber = array[i];
                }
            }
            Console.WriteLine("\n\nLargest Number : {0} \nSecond Largest Number : {1}", largestNumber, secondLargeNumber);
            Console.ReadLine();

        }
    }
}
