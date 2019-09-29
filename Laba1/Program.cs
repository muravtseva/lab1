using System;

namespace Laba1
{
    class LabaMura
    {
        static void N1()
        {
            Console.Write("Введите число:");
            string xString = Console.ReadLine().Replace('.', ','); // Считываем число и заменяем точку на запятую.
            double x = Convert.ToDouble(xString); // Преобразуем число из String в Double
            x *= 10; // Заносим в целую часть первую цифру после запятой
            // Например:
            // Было 2.4123
            // Стало 24.123
            int d = (int)Math.Truncate(x); // Обрезаем число и преобразовуем к Integer
            // Было 24.123
            // Стало 24
            d %= 10; // Берем остаток от деления на 10
            // Было 24
            // 24 / 10 = 2 и остаток 4
            Console.Write("d = ");
            Console.WriteLine(d);
        }

        static void N2()
        {
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            N1();
            Console.WriteLine("Задание 2");
            N2();
        }
    }
}
