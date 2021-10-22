using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Student_Data
    {
        public static void Main()
        {
            string studentName;
            string compliment;
            int marksOne;
            int marksTwo;
            int marksThree;

            Console.WriteLine("Enter your Full Name:");
            studentName = Console.ReadLine();
            Console.WriteLine("Enter Marks Obtained in Maths:");
            marksOne = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks Obtained in Science:");
            marksTwo = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Marks Obtained in English:");
            marksThree = int.Parse(Console.ReadLine());

            int averageNumber = marksOne + marksTwo + marksThree / 3;
            int totalNumber = marksOne + marksTwo + marksThree;
            if (totalNumber >= 60)
                compliment = "First🎈";
            else
            if (totalNumber < 60 && totalNumber >= 50)
                compliment = "Second✨";
            else
            if (totalNumber < 50 && totalNumber >= 35)
                compliment = "Pass😊";
            else
                compliment = "Fail 😔";

            Console.Write("Name of Student :" + studentName);
            Console.Write("Marks in Maths : {0}\nMarks in Science : {1}\nMarks in English : {2}\n", marksOne, marksTwo, marksThree);
            Console.WriteLine("Average Marks scored Among all Subjects:" + averageNumber);
            Console.WriteLine("Total Marks Scored :" + totalNumber);
            Console.WriteLine("Grade :" + compliment);

        }
    }




}
