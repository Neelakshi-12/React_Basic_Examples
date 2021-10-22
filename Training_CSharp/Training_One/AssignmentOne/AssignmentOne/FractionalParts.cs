using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class FractionalParts
    {
        public static void Main()
        {
            double anyNumber;
            Console.WriteLine("Enter the Number:");
            anyNumber = Double.Parse(Console.ReadLine());
            Console.WriteLine("Entered Number" + anyNumber);
            long firstPart = (long)anyNumber;
            double secondPart = anyNumber - firstPart;
            Console.WriteLine("Integer part = " + firstPart);
            Console.WriteLine("Fractional part = " + secondPart);
        }
    }
}
