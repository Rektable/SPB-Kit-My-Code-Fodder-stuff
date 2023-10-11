using System; // Хуйню сморозил номер 2, это подключение библиотек
class Algorithm1_lowestnumber // без задачи класса программа не начнётся на C#
{

    static void Main(string[] args) // начало программы, точка входа
    {
        {
            Console.Write("Введите первое число: ");
            int number1 = Convert.ToInt32(Console.ReadLine()); // задаем первое число, конвертируется в 32бита число чтобы распознать
            Console.Write("Введите второе число: ");
            int number2 = Convert.ToInt32(Console.ReadLine()); // второе число
            Console.Write("Введите третье число: ");
            int number3 = Convert.ToInt32(Console.ReadLine()); // третье число
            
            int min_value = Math.Min(Math.Min(number1, number2), number3); // Минимальное значение

            
            Console.WriteLine("Минимальное число: " // Выдаем результат
                              + min_value);
        }
    }
}
