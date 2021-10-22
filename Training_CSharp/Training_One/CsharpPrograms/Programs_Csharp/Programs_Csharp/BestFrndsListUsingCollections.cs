using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
    class BestFrndsListUsingCollections
    {
		public static void Main()
		{
			List<string> schoolFriends = new List<string>();

			schoolFriends.Add("Geeta");
			schoolFriends.Add("Nidhi");
			schoolFriends.Add("Shreya");
			schoolFriends.Add("Ankit");
			schoolFriends.Add("Tanya");
			schoolFriends.Add("Ayesha");

			List<string> collegeFirends = new List<string>();
			collegeFirends.Add("Rochna");
			collegeFirends.Add("Prabhat");
			collegeFirends.Add("Shreya");
			collegeFirends.Add("Ankit");
			collegeFirends.Add("Ravi");
			collegeFirends.Add("Ayesha");
			Console.WriteLine("****************************************");
			Console.WriteLine("____________ School Firends ____________");
			Console.WriteLine("****************************************");

			foreach (var schoolFriend in schoolFriends)
			{
				Console.WriteLine("\t\t"+schoolFriend);
			}
			Console.WriteLine("****************************************");
			Console.WriteLine("____________ College Firends ___________");
			Console.WriteLine("****************************************");
			foreach (var collegeFirend in collegeFirends)
			{
				Console.WriteLine("\t\t"+collegeFirend);
			}
			Console.WriteLine("****************************************");
			Console.WriteLine("____________ Best Firends ____________ ");
			Console.WriteLine("****************************************");
			foreach (string bestFriends in schoolFriends.Intersect(collegeFirends))
				Console.WriteLine("\t\t"+bestFriends);
			Console.WriteLine("****************************************");
			Console.WriteLine("____________ THE END ____________ ");
			Console.WriteLine("****************************************");
		}
	}
}
