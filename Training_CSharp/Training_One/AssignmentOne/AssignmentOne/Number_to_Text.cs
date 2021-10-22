using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Number_to_Text
    {
        static void printValue(char digit)
        {

            switch (digit)
            {

                case '0':
                    Console.Write("Zero ");
                    break;

                case '1':
                    Console.Write("One ");
                    break;

                case '2':
                    Console.Write("Two ");
                    break;

                case '3':
                    Console.Write("Three ");
                    break;

                case '4':
                    Console.Write("Four ");
                    break;

                case '5':
                    Console.Write("Five ");
                    break;

                case '6':
                    Console.Write("Six ");
                    break;

                case '7':
                    Console.Write("Seven ");
                    break;

                case '8':
                    Console.Write("Eight ");
                    break;
                case '9':
                    Console.Write("Nine ");
                    break;
            }
        }
        static void printWord(string N)
        {
            int i, length = N.Length;

            for (i = 0; i < length; i++)
            {
                printValue(N[i]);
            }
        }

        public static void Main()
        {
            string anyNumber;
            Console.WriteLine("Enter the Number:");
            anyNumber = Console.ReadLine();

            printWord(anyNumber);
        }
    }
}
