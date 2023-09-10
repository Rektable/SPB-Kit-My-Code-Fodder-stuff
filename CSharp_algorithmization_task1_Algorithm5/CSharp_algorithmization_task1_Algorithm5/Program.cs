using System;
using System.IO;
using System.Net.Security;

class Alg5 // база
{
    static void Main(string[] args) // база
                                    // После этого идет страшно вырубай, код можно было и лучше написать, используя связь &&, потом перепишу может
    {
        int q, w, e, r, t, y, u, i, o, p, a, s, d, f, g, h, j, k, l, z;
        Console.WriteLine("Введите 1-ое число");
        Console.WriteLine("Числа вводить не больше двузначных пока-что");
        q = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 2-ое число");
        w = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 3-е число");
        e = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 4-ое число");
        r = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 5-ое число");
        t = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 6-ое число");
        y = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 7-ое число");
        u = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 8-ое число");
        i = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 9-ое число");
        o = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 10-ое число");
        p = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 11-ое число");
        a = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 12-ое число");
        s = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 13-ое число");
        d = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 14-ое число");
        f = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 15-ое число");
        g = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 16-ое число");
        h = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 17-ое число");
        j = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 18-ое число");
        k = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 19-ое число");
        l = Int32.Parse(Console.ReadLine());
        Console.WriteLine("Введите 20-ое число");
        z = Int32.Parse(Console.ReadLine());

        int count = 0;
        if (q > 10)
            count++;
        if (w > 10)
            count++;
        if (e > 10)
            count++;
        if (r > 10)
            count++;
        if (t > 10)
            count++;
        if (y > 10)
            count++;
        if (u > 10)
            count++;
        if (i > 10)
            count++;
        if (o > 10)
            count++;
        if (p > 10)
            count++;
        if (a > 10)
            count++;
        if (s > 10)
            count++;
        if (d > 10)
            count++;
        if (f > 10)
            count++;
        if (g > 10)
            count++;
        if (h > 10)
            count++;
        if (j > 10)
            count++;
        if (k > 10)
            count++;
        if (l > 10)
            count++;
        if (z > 10)
            count++;

        Console.WriteLine("Количество чисел больше 10 составляет: " + count);
        Console.ReadKey();
    }
}