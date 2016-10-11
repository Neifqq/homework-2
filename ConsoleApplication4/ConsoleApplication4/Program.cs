using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0, last, k = 1, s, log = Math.Log(10, 4), z = 0.000001;
            do
            {
                last = sum;
                s = 1 / ((4 * k - 2) * (4 * k - 1));
                sum += s;
                k++;
            }
            while (((8 * sum + log) - (8 * last + log)) > z);
            Console.WriteLine(8*last + log);
            // Выводит неточно, хотя проверял каждый шаг. Возможно, проблема в логарифме.
        }
    }
}
