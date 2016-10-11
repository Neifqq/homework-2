using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), sum = x, last, z = 0.00000001;
            double k = 1, s = x, a = x, f = 1;
            last = sum;
            do
            {
                last = sum;
                k++;
                f *= k;
                a *= x;
                s = a / f;
                if ((k % 2) == 0)
                {
                    s = -s;
                }
                sum += s;
            }
            while (Math.Abs(sum - last) > z);
            Console.WriteLine("{0:0.########}", last);
        }
    }
}
