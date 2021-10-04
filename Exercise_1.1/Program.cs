using System;

namespace Exercise_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            var rand = new Random();

            for (int i = 0; i < 9; i++) //цикл для генерирования 9 случайных чисел
            {
                var N = rand.Next(1, 100); //генерация чисел от 1 до 100
                Console.WriteLine("Число:" + N);
                if (N % 9 == 1 || N % 9 == 2) count++; //проверка остатка и подсчёт количества чисел 
            }
            Console.WriteLine("Количество чисел: " + count); //вывод результата
            Console.ReadKey();
        }
    }
}
