using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Odd_Even_Number
    {
        public static bool evenNumber(int anyNumber)
        {
            return (anyNumber % 2 == 0);
        }
        public static void Main()
        {
            int anyNumber;
            Console.WriteLine("Enter the Number:");
            anyNumber = int.Parse(Console.ReadLine());

            if (evenNumber(anyNumber) == true)
                Console.WriteLine("This Number is Even");
            else
                Console.WriteLine("This Number is Odd");
        }
    }
}
