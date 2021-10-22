using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Factorial_Program
    {
		static int factorial(int n)
		{
			if (n == 0)
				return 1;

			return n * factorial(n - 1);
		}

		public static void Main()
		{
			int anyNumber;
			Console.WriteLine("Enter the FirstNumber:");
			anyNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Factorial of "
							+ anyNumber + " is " + factorial(anyNumber));
		}
	}
}

