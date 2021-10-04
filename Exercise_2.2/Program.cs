using System;

//Дано натуральное число. Определить: среднее арифметическое его цифр

namespace Exercise_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double res = 0.0;
            int count = 0; //переменная для хранения количества цифр в числе
            var rand = new Random();
            var n = rand.Next(1, 100000); //генерация случайного числа от 1 до 100000

            Console.WriteLine("Исходное число: " + n); //вывод исходного числа
            while (n != 0) //цикл для разбиения числа и определения количества цифр 
            {
                res += n % 10;
                count++;
                n /= 10;
            }
            Console.WriteLine("\nСреднее арифметическое: " + (res / count)); //вывод результата
            Console.ReadKey();
        }
    }
}
