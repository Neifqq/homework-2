using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 1 / Math.Sqrt(2);
            double a1, a0, b1, b0, t1, t0, p1, p0, n = double.Parse(Console.ReadLine());
            a1 = 1;
            a0 = 1;
            b1 = x;
            b0 = x;
            t1 = 0.25;
            t0 = 0.25;
            p1 = 1;
            p0 = 1;
            for (int i = 0; i < n; i++)
            {
                a1 = (a0 + b0) / 2;
                b1 = Math.Sqrt(a0 * b0);
                t1 = t0 - p0 * (a0 - a1) * (a0 - a1);
                p1 = 2 * p0;
                a0 = a1;
                b0 = b1;
                t0 = t1;
                p0 = p1;
            }
            Console.WriteLine((a1 + b1) * (a1 + b1) / (4 * t1));
        }
    }
}