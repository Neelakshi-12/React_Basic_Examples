using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{
    class HashSetDemo
    {
        static void Main(string[] args)
        {
            HashSet<string> names = new HashSet<string> {
                "Neelakshi",
                "Shreya",
                "Rochna"
            };
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
            Console.ReadKey();
        }
    }
}
