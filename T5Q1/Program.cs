using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T5Q1
{
    internal class Program
    {
        public static float mohit(float x,float y)
        {
            float z = (float)Math.Sqrt((x*x) + (y*y));
            return (x + y + z);
        }
        public static float masahat(float x, float y)
        {
            return x * y/2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("do zele ghaem mosalas ghaem khod ra vared konid ");
            float x, y,P,S;
            x = float.Parse(Console.ReadLine());
            y = float.Parse(Console.ReadLine());
            P = mohit(x, y);
            S = masahat(x, y);
            Console.WriteLine("Mohit mosalas =" + P);
            Console.WriteLine("Masahat mosalas =" + S);
            Console.ReadKey();
        }
    }
}
