using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class Vendor_and_Client
    {
        public static void Main()
        {
            string name;
            int numberOfResources;
            int numberOfHours;
            int totalCosts;
            int externalResources;
            int externalResourceAmount;
            int payableAmount;

            Console.WriteLine("Enter your Full Name:\n");
            name = Console.ReadLine();
            Console.WriteLine("************************");
            Console.WriteLine("The Amount per Hour is 20 Dollars/Hour");
            Console.WriteLine("************************ \n");

            Console.WriteLine("Enter Total Number of Resources:");
            numberOfResources = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Total Number of Hours:");
            numberOfHours = int.Parse(Console.ReadLine());

            totalCosts = numberOfResources * 20 * numberOfHours;
            Console.WriteLine("The Total Cost For your Project: \n" + totalCosts);
            Console.WriteLine("************************");
            Console.WriteLine("For Vendor :");
            Console.WriteLine("************************ \n");

            Console.WriteLine("Enter Total External Resources Used: \n 1.) Hardware \n 2.)Software \n 3.)Both ");
            externalResources = int.Parse(Console.ReadLine());
            if (externalResources == 1)
            {
                Console.WriteLine("Hardware");
                externalResourceAmount = totalCosts * 30 / 100;
                payableAmount = totalCosts - externalResourceAmount;
                Console.WriteLine("payable amount to the Client:" + payableAmount);
            }
            else if (externalResources == 2)
            {
                Console.WriteLine("Software");
                externalResourceAmount = totalCosts * 50 / 100;
                payableAmount = totalCosts - externalResourceAmount;
                Console.WriteLine("payable amount to the Client:" + payableAmount);
            }
            else if (externalResources== 3)
            {
                Console.WriteLine("Used Both");
                externalResourceAmount = totalCosts;
                payableAmount = totalCosts - externalResourceAmount;
                Console.WriteLine("payable amount to the Client:" + payableAmount);
            }
            else
            {
                Console.WriteLine("Didn't Used Any External Resource.");
                Console.WriteLine("payable amount to the Vendor:\n" + totalCosts);
            }
            Console.WriteLine("\n");
            Console.WriteLine("************************ \n");
            Console.WriteLine("Profits or Loss Realized by the vendor is :\n");
            Console.WriteLine("************************ \n");
            if (externalResources < 1)
            {
                Console.WriteLine("Vendor is in Profit \n");
            }else
            {
                Console.WriteLine("Vendor is in Loss \n");
            }
        }
        }
}
