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
            double k = double.Parse(Console.ReadLine()), l = 1.5 / k, n = 0.5, sum = 0;
            n += l;
            do
            {
                sum += -Math.Tan(1 / n + n) * l;
                n += l;
                Console.WriteLine(sum);
            }
            while (n <= (2));
            Console.WriteLine(sum);
        }
    }
}
