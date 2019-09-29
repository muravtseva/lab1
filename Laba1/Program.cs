using System;

namespace Laba1
{
    class LabaMura
    {
        static void N1()
        {
            Console.Write("Введите число: ");
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
            Console.Write("Введите секунды: ");
            string secondsS = Console.ReadLine();
            ulong totalSeconds = Convert.ToUInt64(secondsS);
            ulong hours = totalSeconds / 3600;
            totalSeconds -= (hours) * 3600;
            ulong minutes = totalSeconds / 60;
            totalSeconds -= (minutes) * 60;

            Console.WriteLine(String.Format("h: {0}; m: {1}; s: {2}", hours, minutes, totalSeconds));
            // Подставляем значения в нужные места строки (обозначены как {число}) 
        }

        static void N3()
        {
            Console.Write("Введите h (0 <= h <= 11): ");
            string hS = Console.ReadLine();
            
            int h = Convert.ToInt32(hS);            
            if(h < 0 || h > 11)
            {
                Console.WriteLine("Неверно введено h");
                return;
            }
            
            Console.Write("Введите m (0 <= m <= 59): ");
            string mS = Console.ReadLine();
            
            int m = Convert.ToInt32(mS);
            if (m < 0 || m > 59)
            {
                Console.Write("Неверно введено m");
                return;
            }

            Console.WriteLine("Введите s (0 <= s <= 59): ");
            string sS = Console.ReadLine();

            int s = Convert.ToInt32(sS);
            if (s < 0 || s > 59)
            {
                Console.WriteLine("Неверно введено s");
                return;
            }

            double hAngle = 360.0 / 12.0;
            double mAngle = hAngle / 60.0;
            double sAngle = mAngle / 60.0;

            double result = hAngle * h + mAngle * m + sAngle * s;

            Console.WriteLine(String.Format("Угол поворота стрелки: {0}", result));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            N1();
            Console.WriteLine("Задание 2");
            N2();
            Console.WriteLine("Задание 3");
            N3();
        }
    }
}
