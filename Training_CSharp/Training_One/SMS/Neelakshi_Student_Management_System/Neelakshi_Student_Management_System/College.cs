using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neelakshi_Student_Management_System
{
	class College
	{
		public string CollegeName { get; set; }
		public double CollegeId { get; set; }
		private List<StudentItem> studentItems = new List<StudentItem>();
		private List<Students> students = new List<Students>();

	
		public void AddStudentItem(StudentItem studentItem)
		{
			this.studentItems.Add(studentItem);
		}

	
		public List<StudentItem> GetStudentItem()
		{
			return this.studentItems;
		}


		public void AddStudent(Students students)
		{
			this.students.Add(students);
		}

		
		public List<Students> GetStudent()
		{
			return this.students;
		}


	}
}
