using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
	class StackDemo
	{

		public static void Main()
		{
			Stack<int> numbers = new Stack<int>();
			numbers.Push(1);
			numbers.Push(2);
			numbers.Push(3);
			numbers.Push(4);

			foreach (var item in numbers)
				Console.Write(item + ",\n");
			Console.WriteLine("Number of elements before POP: {0} \n\n", numbers.Count);
			while (numbers.Count > 0)
				Console.Write(numbers.Pop() + ",\n");

			Console.WriteLine();
			Console.WriteLine("Number of elements after POP: {0} \n\n", numbers.Count);
		}
	}
}
