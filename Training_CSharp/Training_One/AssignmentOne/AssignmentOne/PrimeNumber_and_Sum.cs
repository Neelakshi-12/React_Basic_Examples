using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentOne
{
    class PrimeNumber_and_Sum
    {
        public static void Main()
        {
            bool notPrime = false;
            int primeNumbers;

            Console.WriteLine("Enter your Target?");
            int target = Int32.Parse(Console.ReadLine());

            for (int i = 2; i <= target; i++)
            {
                for (primeNumbers = 2; primeNumbers < i; primeNumbers++)
                {
                    if (i % primeNumbers == 0)
                    {
                        notPrime = true;
                        break;
                    }
                }

                if (!notPrime)
                {
                    Console.Write("{0} ", primeNumbers);
                    int a, p, k, s = 0;


                    for (a = 2; a <= primeNumbers; a++)
                    {
                        k = 2;
                        p = 1;
                        while (k < a)
                        {
                            if (a % k == 0)
                            {
                                p = 0;
                                break;
                            }
                            k++;
                        }
                        if (p == 1)
                        {
                            s = s + a;
                        }
                    }

                    Console.WriteLine("Sum of prime numbers:" + s);
                }
                else
                    notPrime = false;
            }
           

            Console.ReadLine();
        }
    }
 }
