using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter A Number between 1 and 7");
            int x;
            try
            {
                x = Convert.ToInt16(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("END!");
                Console.ReadKey();
                return;
            }
            switch (x)
            {
                case 1:
                    Console.WriteLine("Saturday");
                    break;
                case 2:
                    Console.WriteLine("Sunday");
                    break;
                case 3:
                    Console.WriteLine("Monday");
                    break;
                case 4:
                    Console.WriteLine("Tuesday");
                    break;
                case 5:
                    Console.WriteLine("Wednesday");
                    break;
                case 6:
                    Console.WriteLine("Thursday");
                    break;
                case 7:
                    Console.WriteLine("Friday");
                    break;
                default:
                    Console.WriteLine("END!");
                    Console.ReadKey();

                    return;
            }
            Console.ReadKey();


        }
    }
}
