using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neelakshi_Student_Management_System
{
    class Students
    {
		public string StudentName { get; set; }
		private List<College> colleges = new List<College>();
		private List<Branch> branches = new List<Branch>();

	
		public double GetTotalStudentValue()
		{
			double total = 0;
			foreach (var branch in branches)
			{
				total += branch.GetTotalBranchValue();
			}
			return total;
		}


		
		public void AddCollege(College college)
		{
			this.colleges.Add(college);
		}

		
		public List<College> GetColleges()
		{
			return this.colleges;
		}

		
		public void AddBranch(Branch branch)
		{
			this.branches.Add(branch);
		}

		
		public List<Branch> GetBranches()
		{
			return this.branches;
		}
	}
}
