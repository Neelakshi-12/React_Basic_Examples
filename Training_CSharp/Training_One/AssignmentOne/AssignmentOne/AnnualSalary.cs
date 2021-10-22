using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class AnnualSalary
    {

        public static void Main()
        {
            string name;
            int empId;
            int basic;
            int specialAllowances;
            int percentageOfBonus;
            int monthlyTaxSavingInvestments;
            int netSalary;
            int totalNetSalary;

            Console.WriteLine("Enter your Full Name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee ID:");
            empId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter basic:");
            basic = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter specialAllowances:");
            specialAllowances = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter percentageOfBonus:");
            percentageOfBonus = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter monthlyTaxSavingInvestments:");
            monthlyTaxSavingInvestments = int.Parse(Console.ReadLine());

            // Calculate gross salary
            int gross = basic + specialAllowances;
            Console.WriteLine("Gross Salary:" + gross);
            int annualSalary = basic + specialAllowances + monthlyTaxSavingInvestments;
            Console.WriteLine("Annual Salary:" + annualSalary);
            netSalary = gross - monthlyTaxSavingInvestments;
            Console.WriteLine("********************************************");
            if (netSalary > 100000)
            {
                 totalNetSalary = (netSalary - 30 / 100);
                Console.WriteLine("Net Salary:" + totalNetSalary);
            }
            else if(netSalary > 100000 && netSalary < 150000)
            {
                 totalNetSalary = (netSalary - 20 / 100);
                Console.WriteLine("Net Salary:" + totalNetSalary);

            }
            else
            {
                 totalNetSalary = (netSalary);
                Console.WriteLine("Net Salary:" + totalNetSalary);
            }
                int annualIncome = gross - totalNetSalary;
                 Console.WriteLine("Annual Income:" + annualIncome);
            int annualGrossperMonth = annualIncome / 12;
            Console.WriteLine("Annual Gross Per Month:" + annualGrossperMonth);
            int taxPayable = totalNetSalary;
            Console.WriteLine("Tax Payable:" + taxPayable);

        }
    }
}
