using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programs_Csharp
{

    class Student
    {
        public int StudentID { get; set; }

        public string StudentName { get; set; }
    }

    class Test

    {

        public int M1 { get; set; }

        public int M2 { get; set; }

        public int M3 { get; set; }


        public int Total { get; set; }
    }

    class StudentReportSystem
    {

        public static void Main()

        {

            Student student1 = new Student() { StudentID = 1, StudentName = "Neelakshi" };

            Student student2 = new Student() { StudentID = 2, StudentName = "Shreya" };

            Test test1 = new Test() { M1 = 10, M2 = 20, M3 = 10 };

            Test test2 = new Test() { M1 = 15, M2 = 20, M3 = 20 };

            Test test3 = new Test() { M1 = 13, M2 = 10, M3 = 20 };

            Test test4 = new Test() { M1 = 12, M2 = 20, M3 = 10 };

            List<Test> testsResult1 = new List<Test>();

            testsResult1.Add(test1);

            testsResult1.Add(test3);

            List<Test> testsResult2 = new List<Test>();

            testsResult2.Add(test2);

            testsResult2.Add(test4);

            Dictionary<Student, List<Test>> testResult = new Dictionary<Student, List<Test>>();
            testResult.Add(student1, testsResult1);
            testResult.Add(student2, testsResult2);

            DisplayTestResult(testResult);
        }
        private static void DisplayTestResult(Dictionary<Student, List<Test>> testResult)
        {
            Console.WriteLine("\t ___ Student Mark Report ___");
            DrawLine();
            foreach (KeyValuePair<Student, List<Test>> val in testResult)
            {
                Console.WriteLine($"StudentId: {val.Key.StudentID} \t Student Name: {val.Key.StudentName}");
                DrawLine();

                Console.WriteLine("M1 \t M2 \t M3 \t TM \t AM");
                foreach (var item in val.Value)
                {
                    double total = item.M1 + item.M2 + item.M3;
                    double averageMarks = (item.M1+item.M2 + item.M3) / 3;
                    Console.WriteLine($"{ item.M1} \t { item.M2} \t { item.M3} \t {total} \t{averageMarks}");
               
                 }
                DrawLine();
            }

        }

        private static void DrawLine()
        {
            Console.WriteLine();
            for (int i = 0; i < 40; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }

    }
}
