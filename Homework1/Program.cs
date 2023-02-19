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
        /// <returns>Цвет клетки</returns>
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
        static void Main(string[] args)
        {
            // Задание 1
            int a = 145;
            TenToZero(ref a);
            Console.WriteLine(a); // 105
            // Задание 2
            Console.WriteLine(GetChessColor(1, 2));
        }
    }
}