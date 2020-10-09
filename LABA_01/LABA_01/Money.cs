﻿using System;

namespace LABA_01
{
    public class Money
    {
        public Int64 Rubles { get; private set; }
        public byte Penny { get; private set; }

        public Money(Int64 rubles, byte penny)
        {
            if (rubles < 0 )
            {
                throw new ArgumentException("Деньги не могут быть отрицательными");
            }
            if (penny > 100)
            {
                throw new ArgumentException("Количество копееек не должно превышать 1 рубль");
            }
            Rubles = rubles;
            Penny = penny;
        }

        public Money()
        {
            Rubles = 0;
            Penny = 0;
        }

        public static Money operator +(Money  coin1, Money coin2)
        {
            var sum_penny = coin1.Penny + coin2.Penny;
            Int64 sum_rubles = coin1.Rubles + coin2.Rubles;
            Money result = new Money((sum_rubles + sum_penny / 100), ((byte)(sum_penny % 100)));

            return result;
        }

        public static Money operator -(Money coin1, Money coin2)
        {
            if (coin1.Penny >= coin2.Penny)
            {
                Money result = new Money((coin1.Rubles - coin2.Rubles), (byte)(coin1.Penny - coin2.Penny));
                return result;
            }
            else 
            {
                Money result = new Money((coin1.Rubles - coin2.Rubles - 1), (byte)(coin1.Penny - coin2.Penny + 100));
                return result;
            }
        }

        public static Money operator *(Money coin, Int64 multiplier)
        {
            if (multiplier < 0)
            {
                throw new ArgumentException("Деньги не могут быть отрицательными");
            }
            Int64 mul_penny = coin.Penny * multiplier;

            Money result = new Money((coin.Rubles * multiplier + mul_penny / 100), ((byte)(mul_penny % 100)));
            return result;
        }

        public static Money operator /(Money coin, Int64 divider)
        {
            if (divider == 0)
            {
                throw new DivideByZeroException("На ноль делить нельзя");
            }
            if (divider < 0)
            {
                throw new ArgumentException("Деньги не могут быть отрицательными");
            }

            Int64 kopeck = ((coin.Rubles % divider) * 100 / divider) + (coin.Penny / divider);
            Money result = new Money((coin.Rubles / divider + kopeck / 100), (byte)(kopeck % 100));
            return result;
        }

        public static bool operator >(Money coin1, Money coin2)
        {
            if(coin1.Rubles > coin2.Rubles)
            {
                return true;
            }
            else if (coin1.Rubles == coin2.Rubles && coin1.Penny > coin2.Penny)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public static bool operator <(Money coin1, Money coin2)
        {
            if (coin1.Rubles < coin2.Rubles)
            {
                return true;
            }
            else if (coin1.Rubles == coin2.Rubles && coin1.Penny < coin2.Penny)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator >=(Money coin1, Money coin2)
        {
            return !(coin1 < coin2);
        }

        public static bool operator <=(Money coin1, Money coin2)
        {
            return !(coin1 > coin2);
        }


        public static bool operator ==(Money coin1, Money coin2)
        {
            return (coin1.Rubles == coin2.Rubles && coin1.Penny == coin2.Penny);
        }

        public static bool operator !=(Money coin1, Money coin2)
        {
            return !(coin1 == coin2);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{Rubles},{Penny}";
        }


    }
}
