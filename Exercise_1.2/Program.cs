using System;

namespace Exercise_1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            string n = Console.ReadLine();
            int N = Convert.ToInt32(n);
            int sum = 0;

            for (int i = 1; i < N; i++) //цикл для перебора чисел
                if (N % i == 0) sum += i; //проверка является число делителем

            //вывод результата
            if (sum == N) //если число равно сумме своих делителей
                Console.WriteLine("\nЧисло совершенное!");
            else
                Console.WriteLine("\nЧисло НЕ совершенное!");
            Console.ReadKey();
        }
    }
}
