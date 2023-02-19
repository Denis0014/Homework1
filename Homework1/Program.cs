using System;

namespace Homework1
{
    class Program
    {
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
            switch (Math.Sign(d)) { 
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
        /// <returns>Минимум из двух чисел (double)</returns>
        static double Min(double a, double b) => a < b ? a : b;

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
        }
    }
}