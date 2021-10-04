using System;

//Дано натуральное число. Найти число, получаемое из исходного перестановкой его первой и последней цифр

namespace Exercise_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            string x = Console.ReadLine(); //вводим число
            char[] ch = x.ToCharArray(); //получаем массив символов

            char tmp = ch[0]; //помещаем первую цифру в переменную для временного хранения
            ch[0] = ch[ch.Length - 1]; //помещаем на место первой цифры последнюю
            ch[ch.Length - 1] = tmp; //на место последней первую из переменной tmp

            Console.WriteLine("\nПолученное число"); //вывод результата
            foreach (char a in ch) //цикл для обхода всего массива и вывода его чисел
            {
                Console.Write(a);
            }
            Console.ReadKey();
        }
    }
}
