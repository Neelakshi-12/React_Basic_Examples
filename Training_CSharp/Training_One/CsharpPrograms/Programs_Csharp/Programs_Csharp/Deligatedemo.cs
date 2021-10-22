using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp

{
    delegate void PrintMethod(string message);
    class Deligatedemo
    {
        static void Display(string message)
        {

            Console.WriteLine($"Display called (message)");
        }

        static void Show(string message)
        {
            Console.WriteLine($"Show called (message)");
        }
          
        static void Main()
        {

            var pm = new PrintMethod(Display);
           // pm.Invoke("This is from main");
            pm += Show;
            //pm = new PrintMethod(Show);
            pm.Invoke("This is cool");
        }

    }
}
