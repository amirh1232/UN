using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1.Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float temp;
                Console.WriteLine("Enter your room Temperature in Celsius or A-Z to exit");
                try
                {
                    temp = float.Parse(Console.ReadLine());
                }
                catch
                {
                    break;
                }
                Console.WriteLine("Your Temperature is " + ((temp*9.8)+32) +" Farenheit");

            }
        }
    }
}
