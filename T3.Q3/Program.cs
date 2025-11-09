using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.Q3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float y;

            float x = 1;
            while(true)
            {
                
                Console.WriteLine("Enter your Number and 0 for Exit");
                y = float.Parse(Console.ReadLine());
                if (y == 0 || x == 0)
                {
                    Console.ReadKey();
                    break;
                }
                x = x * y;
                Console.WriteLine(x);
                
            }
        }
    }
}
