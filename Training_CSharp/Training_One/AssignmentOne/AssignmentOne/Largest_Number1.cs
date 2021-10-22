using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Largest_Number1
    {
        static void Main()
        {
            int anyNumber, firstNumber, secondNumber, thirdNumber, temp;
            Console.WriteLine("Enter the Number:");
            firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number:");
            secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Number:");
            thirdNumber = int.Parse(Console.ReadLine());

            temp = firstNumber > secondNumber ? firstNumber : secondNumber;
            //comparing the temp variable with c and storing the result in the variable  
            anyNumber = thirdNumber > temp ? thirdNumber : temp;
            //prints the largest number  
            Console.WriteLine("The largest number is: " + anyNumber);

            /*Console.WriteLine("Enter Any Three Numbers");
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
            Console.ReadLine();*/

        }
    }
}
