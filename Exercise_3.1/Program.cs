using System;

//В одномерном целочисленном массиве переставить элементы в обратном порядке, не используя других массивов

namespace Exercise_3._1
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

            int tmp = 0; //переменная для временного хранения значений
            for (int i = 0; i < array.Length / 2; ++i) //перестановка элементов массива
            {
                tmp = array[i];
                array[i] = array[array.Length - i - 1];
                array[array.Length - i - 1] = tmp;
            }
            Console.WriteLine("\nПолученный массив: "); //вывод массива с переставленными элементами
            foreach (int b in array)
                Console.Write(b + " ");
            Console.ReadKey();
        }
    }
}
