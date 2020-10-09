using System;

namespace LABA_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Money bab = new Money(125, 75);
            Money bab2 = new Money(24, 75);

            Console.WriteLine($"Счёт: {bab.ToString()}");
            Console.WriteLine($"Счёт: {bab2.ToString()}");

            var sum = bab + bab2;
            var dif = bab - bab2;
            var mul = bab * 3;
            var div = bab2 / 7;
            Console.WriteLine($"Сумма: {sum.ToString()}");
            Console.WriteLine($"Разность: {dif.ToString()}");
            Console.WriteLine($"Произведение: {mul.ToString()}");
            Console.WriteLine($"Деление: {dif.ToString()}");
            Console.WriteLine($"Проверка >: {bab > bab2}");
            Console.WriteLine($"Проверка <: {bab < bab2}");
            Console.WriteLine($"Проверка >=: {bab >= bab2}");
            Console.WriteLine($"Проверка <=: {bab <= bab2}");
            Console.WriteLine($"Проверка ==: {bab == bab2}");
            Console.WriteLine($"Проверка !=: {bab != bab2}");
            Console.ReadLine();
        }
    }
}
