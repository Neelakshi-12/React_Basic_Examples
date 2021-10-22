using System;
namespace AssignmentOne
{

    class Sample_Interest                                                                                      //Assignment program - 1 : Sample Interest
    {
        public static void Main()
        {
            float principal;
            float rate;
            float time;
            Console.WriteLine("Enter the Principal:");
            principal = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Rate of interest:");
            rate = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Time period:");
            time = float.Parse(Console.ReadLine());
            float sampleInterest = (principal * rate * time) / 100;
            Console.WriteLine("Simple Interest is: " + sampleInterest);
         
        }
        //document comments : 3 slash (///)

        /// <summary>
        /// Display the num1 and num2 values.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param> 
       /* private static void Display(int num1, int num2)
        {
            
        }*/
    }
}
