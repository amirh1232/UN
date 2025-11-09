using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T1.Q1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                float r;
                Console.WriteLine("inter your Circle's radius Or 0 for Exit");
                r = float.Parse(Console.ReadLine());
                if (r <= 0)
                {
                    break;
                }
                float s, p;
                s = (float)r * r;
                s = (float)(s * 3.14);
                p = (float)( r * 3.14 *2);
                Console.WriteLine("Masahat = " + s );
                Console.WriteLine("Mohit = " + p);
            }
        }
    }
}
