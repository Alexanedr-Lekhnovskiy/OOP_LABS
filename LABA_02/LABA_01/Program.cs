using System;

namespace LABA_02
{
    class Program
    {
        static void Main(string[] args)
        {

            //TEST_Разовой подписки
            Person person1 = new Person("Аня", "Миронова", new Money(3000, 0));
            Console.WriteLine($"{person1.ToString()}");

            //создаём одноразовую подписку
            OnePayment FastPlay = new OnePayment(new Money(100, 0));

            //опачиваем подписку
            DateTime time = DateTime.Now;
            person1.PayingOne(FastPlay, time);
            Console.WriteLine($"{person1.ToString()}\n");

            Console.WriteLine($"Дата оформления подписки : {FastPlay.GetDateStart()}");
            Console.WriteLine($"Дата окончания подписки : {FastPlay.GetDateEnd()}\n");


            //Создаём подписку на зачисление, также одноразовую
            Person person2 = new Person("Сергей", "Степанов", new Money(1000, 0));
            Console.WriteLine($"{person2.ToString()}");

            OnePayment Bonus = new OnePayment(new Money(350, 0), '+');

            person2.PayingOne(Bonus, time );
            Console.WriteLine($"{person2.ToString()}\n");

            Console.WriteLine($"Дата оформления подписки : {Bonus.GetDateStart()}");
            Console.WriteLine($"Дата окончания подписки : {Bonus.GetDateEnd()}\n");

            //////////////////////////////////////
            /////////////////////////////////////


            //TEST_Ежедневной подписки
            Person person3 = new Person("Владимир", "Уткин", new Money(14000, 0));
            Console.WriteLine($"{person3}\n");

            //создаём ежедневную подписку на столько-то дней
            DaysPayment Donation = new DaysPayment(new Money(300, 0), '-', 15);

            //Условно подписывается нашего клиента
            int index = person3.AddPayingDays(Donation);


            //оплачиваем ежедневную подписку
            DateTime now = DateTime.Now;
            for (int i = 0; i < 20; i++)
            {
                person3.PayingOne(Donation, now);
                now = now.AddDays(1);
                Console.WriteLine($"${now}\n{person3}\n");

                //Выводим даты оформления и окончания подписки
                Console.WriteLine($"Дата оформления подписки : {Donation.GetDateStart()}");
                Console.WriteLine($"Дата окончания подписки : {Donation.GetDateEnd()}\n");
            }


            //Отписываем нащего клиента
            person3.RemovePayingDays(index);


            ////////////////////////////////////////
            ///////////////////////////////////////


            //TEST_Ежемесячной подписки
            Person person4 = new Person("Ольга", "Зайцева", new Money(200, 0));
            Console.WriteLine($"{person4}\n");

            //создаём ежемесячную подписку 
            MonthsPayment Salary = new MonthsPayment(new Money(1000, 0), '+', 14);

            //Условно подписывается нашего клиента
            int indexs = person4.AddPayingMonths(Salary);

            //оплачиваем ежемесячную подписку
            now = DateTime.Now;
            for (int i = 0; i < 18; i++)
            {
                person4.PayingOne(Salary, now);
                now = now.AddDays(30);
                Console.WriteLine($"${now}\n{person4}\n");

                //Выводим даты оформления и окончания подписки
                Console.WriteLine($"Дата оформления подписки : {Salary.GetDateStart()}");
                Console.WriteLine($"Дата окончания подписки : {Salary.GetDateEnd()}\n");
            }

            //Отписываем нащего клиента
            person4.RemovePayingMonths(indexs);

            Console.ReadLine();

           
        }
    }
}
