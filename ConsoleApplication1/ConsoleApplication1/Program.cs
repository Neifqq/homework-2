using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication14
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine()), sum = 0, last, z = 0.0001, a, b, c, d, e;
            // Для удобства делим выражение на мелкие функции.
            // Можно без 5 переменных всё запихнуть в sum, но будет непонятно.
            // (-1)^n = a
            // (2n)! = b
            // (1 - 2n) Не буду делать переменную, и так всё понятно.
            // (n)! = c
            // 4^n = d
            // x^n = e
            double n = 1;
            a = 1;
            b = 1;
            c = 1;
            d = 1;
            e = 1; // Посчитал вручную для n = 0, в цикл неудобно этот случай вставлять.
            sum += ((a * b * e) / (c * c * d));
            Console.WriteLine(sum);
            last = sum;
            do
            {
                last = sum;
                a *= -1;
                b = b * 2 * n * (2 * n - 1);
                c *= n;
                d *= 4;
                e *= x;
                sum += ((a * b * e) / (c * c * d * (1 - 2 * n)));
                n++;
                Console.WriteLine(sum);
            }
            while (Math.Abs(sum - last) > z);
            last = Math.Round(last, 4);
            Console.WriteLine("Искомое {0},шаг {1},проверка {2}", last, n, Math.Sqrt(1 + x));
            // Так получается, что между шагами число растёт на больше, чем 1 знак после запятой,
            // и поэтому придётся обрезать число вручную (если точность не задана изначально).
            // upd Я вручную ввёл точность.
        }
    }
}