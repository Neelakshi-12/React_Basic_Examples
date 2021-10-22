using System;
namespace Neelakshi_Student_Management_System
{

    class Program
		{
			static void Main(string[] args)
			{

			StudentItem studentItem1 = new StudentItem() { Name = "Neelakshi", Id = 1 , Fees = 15000 };
			StudentItem studentItem2 = new StudentItem() { Name = "Shreya", Id = 2 , Fees = 25000 };
			StudentItem studentItem3 = new StudentItem() { Name = "Rochna", Id = 3 , Fees = 35000 };
			StudentItem studentItem4 = new StudentItem() { Name = "Shweta", Id = 4 , Fees = 45000 };
			StudentItem studentItem5 = new StudentItem() { Name = "Sonal", Id = 5 , Fees = 55000 };

		
			College college = new College() { CollegeName = "Gautam Buddha University" , CollegeId =  12345 };

			college.AddStudentItem(studentItem1);
			college.AddStudentItem(studentItem2);
			college.AddStudentItem(studentItem3);
			college.AddStudentItem(studentItem4);
			college.AddStudentItem(studentItem5);

			
			Students student1 = new Students() { StudentName = "Neelakshi" };
			Students student2 = new Students() { StudentName = "Shreya" };

			
			college.AddStudent(student1);
			college.AddStudent(student2);

			
			student1.AddCollege(college);
			student2.AddCollege(college);

			Branch branch1 = new Branch() { BranchId = 10001 };
			Branch branch2 = new Branch() { BranchId = 10002 };
			Branch branch3 = new Branch() { BranchId = 10003 };
			Branch branch4 = new Branch() { BranchId = 10004 };
			Branch branch5 = new Branch() { BranchId = 10005 };
			Branch branch6 = new Branch() { BranchId = 10006 };

			student1.AddBranch(branch1);
			student2.AddBranch(branch2);

		
			branch1.Students = student1;
			branch2.Students = student2;

			
			Fees fee1 = new Fees() { Sem = 1 };
			Fees fee2 = new Fees() { Sem = 2 };
			Fees fee3 = new Fees() { Sem = 1 };
			Fees fee4 = new Fees() { Sem = 1 };
			Fees fee5 = new Fees() { Sem = 2 };
			Fees fee6 = new Fees() { Sem = 2 };
			

		
			fee1.StudentItem = studentItem1;
			fee2.StudentItem = studentItem2;
			fee3.StudentItem = studentItem3;
			fee4.StudentItem = studentItem4;
			fee5.StudentItem = studentItem5;
			

			branch1.AddBranchStudentItem(fee1);
			branch2.AddBranchStudentItem(fee2);
			branch3.AddBranchStudentItem(fee3);
			branch4.AddBranchStudentItem(fee4);
			branch5.AddBranchStudentItem(fee5);
			branch6.AddBranchStudentItem(fee6);
			

			DisplayCollegeInfo(college);
		}
		private static void DisplayCollegeInfo(College college)
		{
			double companyTotal = 0;
			double total = 0;
			Console.WriteLine("College Information " + college.CollegeName);
			DrawLine();
			Console.WriteLine("Student  Information:");
			DrawLine();
			foreach (var Students in college.GetStudent())
			{
				Console.WriteLine($"Student Name : " + Students.StudentName);
				DrawLine();
				foreach (var branch in Students.GetBranches())
				{
					total = 0;
					Console.WriteLine($"Branch ID : {branch.BranchId}");
					DrawLine();
					Console.WriteLine("Student Name \t Fees \t Semester \t Total");
					DrawLine();
					foreach (var Fees in branch.GetBranchStudentItem())
					{
						Console.WriteLine($"{Fees.StudentItem.Name} \t " +
							$"{Fees.StudentItem.Fees} \t " +
							$"{Fees.Sem} \t" +
							$"{Fees.GetBranchStudentItemValue()}");
						companyTotal = companyTotal + Fees.StudentItem.Fees * Fees.Sem;
					}
					DrawLine();
					Console.WriteLine("\t\tTotal Amount : " + branch.GetTotalBranchValue());
					DrawLine();
				}
				DrawLine();
				total = Students.GetTotalStudentValue();
				

			}
			DrawLine();
			Console.WriteLine("Grand Total Amount : " + total);
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
