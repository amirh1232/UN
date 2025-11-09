using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Yout Number");
            float x;
            x = float.Parse(Console.ReadLine());
            if(x%7 == 0)
            {
                Console.WriteLine("True!");
            }
            else
            {
                Console.WriteLine(x * 3);
            }
            Console.ReadKey();
        }
    }
}
