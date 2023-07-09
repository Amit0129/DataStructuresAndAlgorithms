using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresAndAlgorithms
{
    public class PrimeNumber
    {
        public void Prime()
        {
            Console.WriteLine("Enter Starting Number : ");
            int start = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Enter Ending Number : ");
            int end = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Prime numbers between " + start + " and " + end + " are : ");
            int count;
            for (int i = start; i <= end; i++)
            {
                count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                        count++;
                }
                if (count == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
