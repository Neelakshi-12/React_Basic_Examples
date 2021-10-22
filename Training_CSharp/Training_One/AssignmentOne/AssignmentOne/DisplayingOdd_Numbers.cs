using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class DisplayingOdd_Numbers
    {
        public static void Main()
        {
            int i, n, sum = 0;

            Console.Write("Enter Number of Odd terms to be displayed: ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe odd numbers are :");
            for (i = 1; i < n; i++)
            {
                Console.Write("{0} ", 2 * i - 1);
                sum += 2 * i - 1;
            }
            Console.Write("\nThe Sum of odd Numbers upto {0} terms : {1} \n", n, sum);
        }
    }
}
