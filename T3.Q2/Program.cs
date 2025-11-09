using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T3.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //printing I
            for(int i=0;i <= 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("  *");
            }
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine();

            //Printing E

            for (int i = 0; i <= 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("*");
            }
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine("*");
            }
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine();

            //Printing H

            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("*       *");
            }
            for (int i = 0; i <= 8; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine("*       *");
            }



            Console.ReadKey();
        }
    }
}
