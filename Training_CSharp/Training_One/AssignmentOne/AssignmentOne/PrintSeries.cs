using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class PrintSeries
    {
        public static void Main()
        {
            
            int firstNumber;
           
            Console.WriteLine("Enter the FirstNumber:");
            firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("........Series will be ........");
            for (int i = 1; i <= firstNumber; i++)
            {

                Console.WriteLine(i * i *4);

            }
  
                int a, b, c;
            Console.WriteLine("........Series will be ........");
            for (a = 1; a < firstNumber; a++)
                {
                    c = 1;
                    for (b = 1; b <= a; b++)
                    {
                        c = c * a;
                    }
                Console.WriteLine(c);
                }


        }
    }
}
