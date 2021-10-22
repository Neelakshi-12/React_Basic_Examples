using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
    class DictionaryDemo
    {
		public static void Main()
		{
			Dictionary<int, string> studentNames = new Dictionary<int, string>();
			studentNames.Add(1, "Yellow");
			studentNames.Add(3, "Blue");
			studentNames.Add(2, "Green");

			foreach (KeyValuePair<int, string> item in studentNames)
				Console.WriteLine("Key: {0}, Value: {1}", item.Key, item.Value);

		}

	}
}
