using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[5];
            Console.WriteLine("Enter 5 Number");
            for (int i = 0; i < 5; i++)
            {
                x[i] = Convert.ToInt16(Console.ReadLine());
            }
            int count = 0;
            bool Found = false;

            for(int i = 0; i < 5; i++)
            {
                if (x[i] == 2)
                {
                    count = i + 1;
                    Found = true;
                    break;
                }
                
            }
            if (Found)
            {
                Console.WriteLine("2 was founded in cell number " + count);
            }
            else
            {
                Console.WriteLine("2 wasnot founded ");
            }

            Console.ReadKey();
        }
    }
}
