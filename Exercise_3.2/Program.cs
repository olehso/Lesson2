using System;
using System.Linq;

//Найти количество элементов массива, встречающихся в нем один раз.

namespace Exercise_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10]; //объявление массива
            var rand = new Random();
            for (int i = 0; i < array.Length; i++)
                array[i] = rand.Next(0, 100); //заполнение массива случайными числами от 0 до 100
            Console.WriteLine("Исходный массив: "); //вывод исходного массива
            foreach (int a in array) //цикл для обхода всего массива и вывода его элементов
                Console.Write(a + " ");
            Console.WriteLine();
            Console.WriteLine("\nКоличество НЕ повторяющихся элементов: {0}", array.Count(p => array.Count(u => u == p) == 1)); //подсчет количества элементов
            Console.ReadKey();
        }
    }
}
