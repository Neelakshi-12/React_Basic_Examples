using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Swap_Number
    { 
    public static void Main()
    {
        Console.WriteLine("**** Before Swapping ****:");
        int firstNumber;
        int secondNumber;
        Console.WriteLine("Enter the FirstNumber:");
        firstNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the SecondNumber:");
        secondNumber = int.Parse(Console.ReadLine());
        //logic
        firstNumber = firstNumber - secondNumber;
        secondNumber = firstNumber + secondNumber;
        firstNumber = secondNumber - firstNumber;
        Console.WriteLine("**** After Swapping ****:");
        Console.WriteLine("First Number is: " + firstNumber);
        Console.WriteLine("Second Number is: " + secondNumber);
    }

}
}

