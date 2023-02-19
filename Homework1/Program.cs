using System;

namespace Homework1
{
    class Program
    {
        public static Random r = new Random();
        /// <summary>
        /// Обнуляет разряд десятков числа
        /// </summary>
        /// <param name="num">Исходное цисло</param>
        static void TenToZero(ref int num) => num -= num / 10 % 10 * 10;
        /// <summary>
        /// Выводит цвет, которое имеет поле с данными координатами шаматной доски
        /// </summary>
        /// <param name="x">Буквенная координата</param>
        /// <param name="y">Числовая координата</param>
        /// <returns>Цвет клетки ("Чёрный", "Белый")</returns>
        /// <exception cref="ArgumentException">Выдаёт это исключение, если координаты клетки находятся за границами доски</exception>
        static string GetChessColor(int x, int y)
        {
            if ((x < 1) || (x > 8) || (y < 1) || (y > 8))
            {
                throw new ArgumentException("Координаты клетки находятся за границами доски");
            }
            if ((x + y) % 2 == 0) return "Чёрный";
            else return "Белый";
        }
        /// <summary>
        /// Возращает количество вещественных корней квадратного уравнения вида: Ax^2+Bx+c=0
        /// </summary>
        /// <param name="a">Коэффициент при 2-й степени при неизвестном</param>
        /// <param name="b">Коэффициент при 1-й степени при неизвестном</param>
        /// <param name="c">Коэффициент при 0-й степени при неизвестном</param>
        /// <returns>Количество вещественных корней квадратного (0, 1, 2)</returns>
        static int QuantityOfRoots(int a, int b, int c)
        {
            int d = b * b - 4 * a * c;
            switch (Math.Sign(d))
            {
                case -1: return 0;
                case 0: return 1;
                default: return 2;
            }
        }
        /// <summary>
        /// Возвращает минимум из двух переданных вещественных чисел
        /// </summary>
        /// <param name="a">Первое число</param>
        /// <param name="b">Второе число</param>
        /// <returns>Минимум из двух чисел</returns>
        static double Min(double a, double b) => a < b ? a : b;
        /// <summary>
        /// Возвращает произведение всех чётных целых чисел от A до B включительно
        /// </summary>
        /// <param name="a">Начало</param>
        /// <param name="b">Конец</param>
        /// <returns>Произведение всех чётных целых чисел от A до B включительно</returns>
        static double ProdOdds(int a, int b)
        {
            double prod = 1;
            if (a % 2 != 0) a++;
            if (b - a < 2) return 0;
            for (int i = a; i <= b; i += 2)
            {
                prod *= i;
            }
            return prod;
        }
        /// <summary>
        /// Вычисляет количество чисел в наборе, меньших K, а также количество чисел, делящихся на K нацело
        /// </summary>
        /// <param name="k">Число для сравнений</param>
        /// <param name="countS">Количество чисел в наборе, меньших K</param>
        /// <param name="countD">Количество чисел, делящихся на K нацело</param>
        static void CountOfSmallerAndDiv(int k, ref int countS, ref int countD)
        {
            int temp = -1;
            for (int i = 0; temp != 0; i++)
            {
                Console.Write($"{i + 1} >>> ");
                temp = int.Parse(Console.ReadLine() ?? "0");
                if (temp < k)
                    countS++;
                if (k == 0 || temp % k == 0)
                    countD++;
            }
        }
        /// <summary>
        /// Имена времён года
        /// </summary>
        enum Seasons { Зима, Весна, Лето, Осень };
        /// <summary>
        /// Возвращает название времени года по номеру месяца
        /// </summary>
        /// <param name="num">Номер месяца</param>
        /// <returns>Время года (Зима, Весна, Лето, Осень)</returns>
        static Seasons GetSeason(int num)
        {
            switch (num)
            {
                case > 12: throw new ArgumentException("Месяцов в году не больше 12");
                case 12: return Seasons.Зима;
                case >= 9: return Seasons.Осень;
                case >= 6: return Seasons.Лето;
                case >= 3: return Seasons.Весна;
                case >= 1: return Seasons.Зима;
                default: throw new ArgumentException("Номер мясяца может быть только натуральными");
            }
        }
        /// <summary>
        /// Выводит на консоль N строк "Месяц №<номер месяца>, его сезон: <сезон для этого месяца>". Номера месяцев генерируются случайно
        /// </summary>
        /// <param name="num">Номер месяца</param>
        static void PrintSeason(int n) 
        {
            int temp = 0;
            for (var i = 0; i < n; i++)
            {
                temp = r.Next(1, 12);
                Console.WriteLine($"Месяц №{temp}, его сезон: {GetSeason(temp)}");
            }
        }

        static void Main(string[] args)
        {
            // Задание 1
            int a = 145;
            TenToZero(ref a);
            Console.WriteLine(a); // 105
            // Задание 2
            Console.WriteLine(GetChessColor(1, 2)); // Белый
            // Задание 3
            Console.WriteLine(QuantityOfRoots(1, 2, 1)); // 1
            // Задание 4
            Console.WriteLine(Min(6, Math.Sqrt(37))); // 6
            // Задание 5
            Console.WriteLine(ProdOdds(1, 7)); // 48
            // Задание 6
            int countS = 0;
            int countD = 0;
            Console.Write("K >>> ");
            int k = int.Parse(Console.ReadLine() ?? "0"); // 10
            CountOfSmallerAndDiv(k, ref countS, ref countD); // 23, -12, 3, 5, 0
            Console.WriteLine($"{countS}, {countD}"); // 4, 1
            // Задание 7
            Console.WriteLine(GetSeason(11)); // Осень
            // Задание 8
            PrintSeason(3);
        }
    }
}