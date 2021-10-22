using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Calculate_Power_of_Number
    {
		static int power(int firstNumber, int secondNumber)
		{
			if (secondNumber == 0)
				return 1;
			else if (secondNumber % 2 == 0)
				return power(firstNumber, secondNumber / 2) * power(firstNumber, secondNumber / 2);
			else
				return firstNumber * power(firstNumber, secondNumber / 2) * power(firstNumber, secondNumber / 2);
		}

		public static void Main()
		{
			int firstNumber;
			int secondNumber;
			Console.WriteLine("Enter the FirstNumber:");
			firstNumber = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter the SecondNumber:");
			secondNumber = int.Parse(Console.ReadLine());
			Console.Write(power(firstNumber, secondNumber));
		}
	}
}
