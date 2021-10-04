using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = string.Empty;
            int b, c, n;

            Console.WriteLine("Введите число: ");
            if (!int.TryParse(Console.ReadLine(), out n)) return; //возбращает булево значение и преобразованное значение в out

            while ((n % 2) == 0) //проверка значения на остаток
            {
                n = n / 2;
                s += "2*";
            }
            b = 3; 
            c = (int)Math.Sqrt(n) + 1;
            //разложение на простые множители
            while (b < c) 
            {
                if ((n % b) == 0)
                {
                    if (n / b * b - n == 0)
                    {
                        s += b.ToString() + "*";
                        n = n / b;
                        c = (int)Math.Sqrt(n) + 1;
                    }
                    else
                        b += 2;
                }
                else
                    b += 2;
            }
            s += n.ToString();
            Console.WriteLine("\nРазложение: " + s); //вывод разложенного числа на простые множители 
            Console.ReadKey();
        }
    }
}
