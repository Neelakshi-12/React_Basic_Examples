using System;

namespace TrainingCsharpPrograms
{
    struct Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
    }
    class Program_1
    {
        public static void display()
        {

            Console.WriteLine("Welcome to C #!!");                                //Assignment program - 1
            // Console.ReadLine(); or  ctrl key+f5
            string name;                                                          //Assignment program - 2
            int id;
            Console.WriteLine("Enter Your  Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter  Your Id:");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("My Name is :" + name);
            Console.WriteLine("My ID is : " + id);                            
            Student s1 = new Student();                                           //Assignment program - 3 (used struct keyword)
            s1.StudentId = 1;
            s1.StudentName = "Shashi";
            Console.WriteLine("Id : " + s1.StudentId + " \t Name : " + s1.StudentName);
            Student s2 = s1;
            s2.StudentName = "Ravi";
            Console.WriteLine("Id : " + s1.StudentId + " \t Name : " + s1.StudentName);
            Console.WriteLine("Id : " + s2.StudentId + " \t Name : " + s2.StudentName);
        }
    }
}

class OutputAssignment1
{

    public static void Main(String[] args)
    {

        TrainingCsharpPrograms.Program_1.display();

    }
}
class OutputAssignment2
{

    public static void Main(String[] args)
    {

        Console.WriteLine("Welcome to OutputAssignment2");

    }
}
