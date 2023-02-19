using System;

namespace Homework1
{
    class Program
    {
        /// <summary>
        /// Обнуляет разряд десятков числа
        /// </summary>
        /// <param name="num">Исходное цисло</param>
        static void TenToZero(ref int num)
        {
            num -= num / 10 % 10 * 10;
        }
        static void Main(string[] args)
        {
            // Задание 1
            int a = 145;
            TenToZero(ref a);
            Console.WriteLine(a); // 105
        }
    }
}