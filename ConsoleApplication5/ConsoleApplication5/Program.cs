using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            double k = double.Parse(Console.ReadLine()), l = 1.5 / k, n= 0.5, sum = 0;
            do
            {
                sum += (Math.Abs(Math.Cos(1 / (n + l) + ((n + l) * (n + l)) / 4) - Math.Cos(1 / n + (n * n) / 4))) * l;
                n += l;
                Console.WriteLine(sum);
            }
            while (n <= (2 - l));
            Console.WriteLine(sum);
        }
    }
}
