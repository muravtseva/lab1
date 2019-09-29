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
            // Часовая стрелка делит круг на 12 частей
            double hAngle = 360.0 / 12.0;
            // Минутная стрелка поворачивает часовую за 60 минут
            double mAngle = hAngle / 60.0;
            // Секундная стрелка поворачивает минутную за 60 секунд
            double sAngle = mAngle / 60.0;

            double result = hAngle * h + mAngle * m + sAngle * s;

            Console.WriteLine(string.Format("Угол поворота стрелки: {0}", result));
        }

        static void N4()
        {
            Console.Write("Введите переменную A: ");
            string aS = Console.ReadLine();
            Console.Write("Введите переменную В: ");
            string bS = Console.ReadLine();

            int a = Convert.ToInt32(aS);
            int b = Convert.ToInt32(bS);

            a += b;
            b = a - b;
            a -= b;

            Console.WriteLine("A = {0}; B = {1}", a, b);
        }

        static void N5()
        {
            Console.Write("Введите первый катет: ");
            string cathet1S = Console.ReadLine();
            
            Console.Write("Введите второй катет: ");
            string cathet2S = Console.ReadLine();

            double cathet1 = Convert.ToDouble(cathet1S);
            double cathet2 = Convert.ToDouble(cathet2S);

            double hypotenuse = Math.Sqrt(cathet1 * cathet1 + cathet2 * cathet2);

            double S = .5 * cathet1 * cathet2;
            double P = cathet1 + cathet2 + hypotenuse;
            Console.WriteLine(String.Format("Гипотенуза: {0}", hypotenuse));
            Console.WriteLine(String.Format("S = {0}; P = {1}", S, P));
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            N1();
            Console.WriteLine("Задание 2");
            N2();
            Console.WriteLine("Задание 3");
            N3();
            Console.WriteLine("Задание 4");
            N4();
            Console.WriteLine("Задание 5");
            N5();
        }
    }
}
