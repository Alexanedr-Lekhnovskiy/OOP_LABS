using System;

namespace LABA_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //TEST_MONEY
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
            Console.WriteLine($"Деление: {div.ToString()}");
            Console.WriteLine($"Проверка >: {bab > bab2}");
            Console.WriteLine($"Проверка <: {bab < bab2}");
            Console.WriteLine($"Проверка >=: {bab >= bab2}");
            Console.WriteLine($"Проверка <=: {bab <= bab2}");
            Console.WriteLine($"Проверка ==: {bab == bab2}");
            Console.WriteLine($"Проверка !=: {bab != bab2}\n");
            

            //TEST_PERSON
            Person p1 = new Person("Дмитрий", "Богачев", bab);
            Console.WriteLine($"{p1.ToString()}");

            //Пополнение баланса 
            var cash = new Money(150, 38);
            p1.UpBalance(cash);
            Console.WriteLine($"{p1.ToString()}");

            //Уменьшение баланса
            var cash2 = new Money(200, 78);
            p1.DownBalance(cash2);
            Console.WriteLine($"{p1.ToString()}");

            
            Console.WriteLine("\n Checking");
            Person p2 = new Person("Илья", "Игнатьев", 100, 50);
            p2.UpBalance(126, 50);
            Console.WriteLine($"{p2.ToString()}");
            p2.DownBalance(100, 30);
            Console.WriteLine($"{p2.ToString()}");

            Console.WriteLine("\n Checking_2");
            Person p3 = new Person("Алексей", "Павлов", 1250, 78);

            //Обнуление баланса (Баланс = 0)
            p3.ZeroBalance();
            Console.WriteLine($"Zero {p3.ToString()}");

            //Установка значения
            p3.SetBalance(208, 90);
            Console.WriteLine($"Set {p3.ToString()}");

            //Transfer(Перевод)
            Console.WriteLine("\nTransfer");
            Console.WriteLine("До перевода");
            Console.WriteLine($"ОТПРАВИТЕЛЬ# {p3.ToString()}");
            Console.WriteLine($"ПОЛУЧАТЕЛЬ# {p2.ToString()}");
            p3.Transfer(p2, 126, 50);
            Console.WriteLine("\nПосле перевода");
            Console.WriteLine($"ОТПРАВИТЕЛЬ# {p3.ToString()}");
            Console.WriteLine($"ПОЛУЧАТЕЛЬ# {p2.ToString()}");

            Console.ReadLine();
        }
    }
}
