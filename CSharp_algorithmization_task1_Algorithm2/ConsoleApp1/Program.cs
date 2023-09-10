using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidal_agorithm
{
    class Algorithm2_Euclide
    {
        static void Main(string[] args)
        {
            int m, n, nod; // Задача переменных
            Console.Write("Введите первое число: ");
            m = Convert.ToInt32(Console.ReadLine()); // конвертация в 32-бит для чисел
            Console.Write("Введите второе число: ");
            n = Convert.ToInt32(Console.ReadLine()); // конвертация в 32-бит для чисел

            while (m != n) // m не может быть равно n
            {
                if (m > n)
                {
                    m = m - n;
                }
                else
                {
                    n = n - m;
                }
            }

            nod = n; // Наибольший общий делитель
            Console.WriteLine("Наибольший общий делитель (НОД): " + nod);

            Console.ReadKey();
        }
    }
}