using System;

class Program // база
{
    static void Main(string[] args) // база
    {

        Console.Write("Введите N: ");
        int N = int.Parse(Console.ReadLine()); // запись числа


        int sum = 0;
        for (int i = 1; i <= N; i++) // формула шага цикла
        {
            sum += i; // цикл i добавляется для считывания суммы
        }

        Console.WriteLine("Сумма первых {0} натуральных чисел, при шаге цикла единица: {1}", N, sum); // Вывод
    }
}



