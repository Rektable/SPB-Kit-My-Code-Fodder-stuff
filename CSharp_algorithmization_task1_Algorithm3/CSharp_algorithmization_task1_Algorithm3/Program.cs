using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Numerics;


namespace Algorithm3_Factorial
{
    class Program
    {
        static void Main(string[] args) // без этого никак
        {
            Console.WriteLine("Введите число");
            long n = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(fact(n));
            Console.ReadLine();
        }
        static BigInteger fact(BigInteger num) // библиотекой System.Numerics вычисляет факториал. Большие числа лучше не вставлять, чревато. Будет долго, а при огромных зависнет.
        {
            return (num == 0) ? 1 : num * fact(num - 1); // сама формула расчёта факториала
        }

    }
}