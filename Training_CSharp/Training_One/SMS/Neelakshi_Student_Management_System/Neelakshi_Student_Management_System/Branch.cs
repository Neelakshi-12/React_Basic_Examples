using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neelakshi_Student_Management_System
{

		class Branch
		{
			public int BranchId { get; set; }
			private List<Fees> Fees = new List<Fees>();
		public Students Students { get; set; }


		public void AddBranchStudentItem(Fees Fees)
			{
				this.Fees.Add(Fees);
			}

			public List<Fees> GetBranchStudentItem()
			{
				return this.Fees;
			}

	
			public double GetTotalBranchValue()
			{
				double total = 0;
				foreach (var feesTotal in Fees)
				{
					total += feesTotal.GetBranchStudentItemValue();
				}
				return total;
			}
		}
	}
