using System;

//Дано натуральное число. Определить количество цифр в нем;

namespace Exercise_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0; //переменная для хранения количества цифр в числе
            var rand = new Random();
            var n = rand.Next(1, 100000); //генерация случайного числа от 1 до 100000
            Console.WriteLine("Исходное число: " + n); //вывод исходного числа
            for (int i = n; i > 0; i /= 10)  // Определение количества цифр в числе
                count++;
            Console.WriteLine("\nКоличество цифр в числе: " + count); //вывод результата
            Console.ReadKey();
        }
    }
}
