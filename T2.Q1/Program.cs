using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter yor Number");
            int x;
            x = Convert.ToInt16(Console.ReadLine());
            if( x<10 && x %2 == 0)
            {
                Console.WriteLine("True !");
            }
            Console.ReadKey();
        }
        
    }
}
