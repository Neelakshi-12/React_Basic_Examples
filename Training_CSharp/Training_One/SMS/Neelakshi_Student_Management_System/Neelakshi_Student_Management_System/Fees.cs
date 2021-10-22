using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neelakshi_Student_Management_System
{
    class Fees
    {
		public StudentItem StudentItem { get; set; }
		public int Sem { get; set; }

		public double GetBranchStudentItemValue()
		{
			return StudentItem.Fees * Sem;
		}
	}
}
