using System;

namespace LABA_01
{
    public class Person 
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Money Balance { get; private set; }

        public Person (string firstName, string lastName, Money balance)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))  
            {
                throw new ArgumentNullException("Имя не может быть пустым");  
            }
            FirstName = firstName;
            LastName = lastName;
            Balance = balance;
        }

        public Person(string firstName, string lastName, Int64 rubles, byte penny)
        {
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName))
            {
                throw new ArgumentNullException("Имя не может быть пустым");
            }
            FirstName = firstName;
            LastName = lastName;
            var balance = new Money(rubles, penny);
            Balance = balance;
        }

        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

        public void UpBalance(Money cash)
        {
            Balance = Balance + cash;
        }

        public void UpBalance(Int64 rubles, byte penny)
        {
            var cash = new Money(rubles, penny);
            Balance = Balance + cash;
        }

        public void DownBalance(Money cash)
        {
            Balance = Balance - cash;
        }

        public void DownBalance(Int64 rubles, byte penny)
        {
            var cash = new Money(rubles, penny);
            Balance = Balance - cash;
        }

        public void ZeroBalance()
        {
            var zero = new Money(0, 0);
            Balance = zero;
        }

        public void SetBalance(Int64 rubles, byte penny)
        {
            var balance = new Money(rubles, penny);
            Balance = balance;
        }

        public void Transfer(Person recipient, Int64 rubles, byte penny)
        {
            var transfer = new Money(rubles, penny);
            if (transfer > Balance)
            {
                throw new ArgumentException("Сумма перевода не может превышать ваш баланс");
            }
            Balance = Balance - transfer;
            recipient.Balance = recipient.Balance + transfer;
        }

        public override string ToString()
        {
            return $"Клиент: {FullName}. Имеет текущий балансовый счёт: {Balance} рублей.";
        }
    }
}
