using System;
using System.Reflection;
using System.Diagnostics;


namespace RektableApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double b, d, a, x1, x2, g;
            Console.WriteLine("Введите число B: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число D: ");
            d = Convert.ToInt32(Console.ReadLine());
            g = Math.Sqrt(d);


            if (d >= 0)
            {
                x1 = (-b - g) / (2 * a);
                x2 = (-b + g) / (2 * a);
                Console.Write("Число x1 равно" + x1);
                Console.Write("Число x2 равно" + x2);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Числа введены неверно перезапускаю процесс");
                var fileName = Process.GetCurrentProcess().MainModule.FileName;
                Process.Start(fileName);
            }
        }
    }
}