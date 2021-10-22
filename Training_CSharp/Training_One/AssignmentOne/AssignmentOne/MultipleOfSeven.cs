using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class MultipleOfSeven
    {
        public static void Main()
        {
            int j, n,table;

            Console.Write("\n\n");
            Console.Write("Multiples of Seven\n");
            Console.Write("-----------------------------------");
            Console.Write("\n\n");

            Console.Write("Table to be calculated, Enter Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (j = 1; j <= 10; j++)
            {
                table = n * j;
                Console.Write("\n" +table);
                Console.Write("\n");
                //  int trail = table / 2;
             }

        }

    }
}

