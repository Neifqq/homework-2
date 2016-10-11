using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double z = 0.0000000001, sum = 1, last, s = 1, n = 0;
            last = sum;
            do
            {
                last = sum;
                n++;
                s = 1/((2 * n + 1) * (2 * n + 1));
                if (n % 2 != 0)
                {
                    s = -s;
                }
                
                sum += s;
            }
            while (Math.Abs(sum - last) > z);
            Console.WriteLine("{0:0.##########}", last);
        }
    }
}
