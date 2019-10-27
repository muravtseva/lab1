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

            Console.WriteLine("h: {0}; m: {1}; s: {2}", hours, minutes, totalSeconds);
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

            Console.WriteLine("Угол поворота стрелки: {0}", result);
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
            Console.WriteLine("Гипотенуза: {0}", hypotenuse);
            Console.WriteLine("S = {0}; P = {1}", S, P);
        }
        private static void N6()
        {
            Console.Write("Введите четырехзначное число: ");
            string numS = Console.ReadLine();
            int num = Convert.ToInt32(numS);
            if(num > 9999 || num < 1000)
            {
                Console.WriteLine("Неверное число");
                return;
            }
            int res = num % 10;
            num /= 10;
            res *= num % 10;
            num /= 10;
            res *= num % 10;
            num /= 10;
            res *= num;

            Console.WriteLine("Результат: {0}", res);
        }
        static void N7()
        {
            Console.Write("Введите трехзначное число: ");
            string numS = Console.ReadLine();
            int num = Convert.ToInt32(numS);
            if (num > 999 || num < 100)
            {
                Console.WriteLine("Неверное число");
                return;
            }

            int res = (num % 10) * 100;
            num /= 10;
            res += (num % 10) * 10;
            num /= 10;
            res += num;
            Console.WriteLine("Результат: {0}", res);
        }

        static void N8()
        {
            Console.Write("Введите число: ");
            string numS = Console.ReadLine();
            double n = Convert.ToDouble(numS);

            double res = n * (n * (n * (3 * n - 5) + 2) - 1) + 7;
            Console.WriteLine("Результат: {0}", res);
        }
        static void N9()
        {
            Console.Write("Введите a1: ");
            double a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b1: ");
            double b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c1: ");
            double c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d1: ");
            double d1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите a2: ");
            double a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b2: ");
            double b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c2: ");
            double c2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d2: ");
            double d2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите a3: ");
            double a3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите b3: ");
            double b3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите c3: ");
            double c3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите d3: ");
            double d3 = Convert.ToDouble(Console.ReadLine());

            double determinant = a1 * b2 * c3 - a1 * b3 * c2 - b1 * a2 * c3 + b1 * a3 * c2 + c1 * a2 * b3 - c1 * a3 * b2;

            if(determinant == 0)
            {
                Console.WriteLine("Определитель равен нулю");
                return;
            }

            double de1 = d1 * b2 * c3 - d1 * b3 * c2 - b1 * d2 * c3 + b1 * d3 * c2 + c1 * d2 * b3 - c1 * d3 * b2;
            double de2 = a1 * d2 * c3 - a1 * d3 * c2 - d1 * a2 * c3 + d1 * a3 * c2 + c1 * a2 * d3 - c1 * a3 * d2;
            double de3 = a1 * b2 * d3 - a1 * b3 * d2 - b1 * a2 * d3 + b1 * a3 * d2 + d1 * a2 * b3 - d1 * a3 * b2;

            double x1 = (de1 / determinant);
            double x2 = (de2 / determinant);
            double x3 = (de3 / determinant);
            Console.WriteLine("x1 = {0}; x2 = {1}; x3 = {2}", x1, x2, x3);

        }

        static void Ind1()
        {
            string[] titles =     { "Название",  "Вид",  "Адрес",              "Рейтинг (из 10)" };
            string[] pafos =      { "Пафос",     "Р",    "Ул. Артема, 300а",   "9" };
            string[] chelentano = { "Челентано", "РБП",  "Бул. Пушкина, 510",  "8" };
            string[] vkusnyaski = { "Вкусняшки", "К",    "Просп. Ильича, 320", "6" };
            Console.WriteLine(new String('-', 84));
            Console.WriteLine("| {0, -80} |", "Рестораны и кафе");
            Console.WriteLine(new String('-', 84));
            Console.WriteLine("| {0, -16} | {1, -8} | {2, -30} | {3, -17} |", titles[0], titles[1], titles[2], titles[3]);
            Console.WriteLine(new String('-', 84));
            Console.WriteLine("| {0, -16} | {1, -8} | {2, -30} | {3, -17} |", pafos[0], pafos[1], pafos[2], pafos[3]);
            Console.WriteLine("| {0, -16} | {1, -8} | {2, -30} | {3, -17} |", chelentano[0], chelentano[1], chelentano[2], chelentano[3]);
            Console.WriteLine("| {0, -16} | {1, -8} | {2, -30} | {3, -17} |", vkusnyaski[0], vkusnyaski[1], vkusnyaski[2], vkusnyaski[3]);
            Console.WriteLine(new String('-', 84));
            Console.WriteLine("| {0, -80} |", "Перечисляемый тип: Р – ресторан, РБП – ресторан быстрого питания, К – кафе");
            Console.WriteLine(new String('-', 84));
        }

        static void Ind2()
        {
            Console.Write("Введите a (a != 0): ");
            double a = Convert.ToDouble(Console.ReadLine());
            if(a == 0)
            {
                Console.WriteLine("Неверно задан параметр.");
                return;
            }
            Console.Write("Введите b (b != 0): ");
            double b = Convert.ToDouble(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Неверно задан параметр.");
                return;
            }
            Console.Write("Введите x: ");
            double x = Convert.ToDouble(Console.ReadLine());

            double R = x * x * (x + 1) / b - Math.Pow(Math.Sin(x + a), 2);
            double s = Math.Sqrt(x * b / a) + Math.Pow(Math.Cos(Math.Pow(x + b, 3)), 2);

            Console.WriteLine("R = {0}; s = {1}", R, s);
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine("1. Задание 1");
            Console.WriteLine("2. Задание 2");
            Console.WriteLine("3. Задание 3");
            Console.WriteLine("4. Задание 4");
            Console.WriteLine("5. Задание 5");
            Console.WriteLine("6. Задание 6");
            Console.WriteLine("7. Задание 7");
            Console.WriteLine("8. Задание 8");
            Console.WriteLine("9. Задание 9");
            Console.WriteLine("10. Индивидуальное задание 1");
            Console.WriteLine("11. Индивидуальное задание 2");
            Console.Write("Введите номер задания: ");

            string read = Console.ReadLine();

            Int32 number = Convert.ToInt32(read);

            switch (number)
            {
                case 1:
                    N1();
                    break;
                case 2:
                    N2();
                    break;
                case 3:
                    N3();
                    break;
                case 4:
                    N4();
                    break;
                case 5:
                    N5();
                    break;
                case 6:
                    N6();
                    break;
                case 7:
                    N7();
                    break;
                case 8:
                    N8();
                    break;
                case 9:
                    N9();
                    break;
                case 10:
                    Ind1();
                    break;
                case 11:
                    Ind2();
                    break;
            }

        }

    }
}
