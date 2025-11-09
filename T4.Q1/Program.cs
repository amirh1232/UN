using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];
            Console.WriteLine("Enter 10 Number");
            for (int i = 0; i < 10; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
            }
            int count = 0;
            for (int i = 0; i< 10; i++)
            {
                if (x[i] % 2 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("You have " + count+" Even Number");
            Console.ReadKey();

        }
    }
}
