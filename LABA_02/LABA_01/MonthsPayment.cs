using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_02
{
     public class MonthsPayment : Subscriptions
    {

        private static Money Prize = new Money(5500, 70);

        public MonthsPayment(Money _total, char symbol, int _months) : base(_total, symbol, _months)
        {
            new Subscriptions(_total, symbol, _months);
        }


        public override Money GetTotal(DateTime currDate)
        {
            if (DateStart == null)
            {
                SetStartAndEndDate(currDate, currDate.AddMonths(period));
            }

            Money Sum = new Money(0, 0);
            for (int i = 0; i < ((TimeSpan)(currDate - DateStart)).TotalDays / 30 && i < period; i++)
            {
                if ((i + 1) % 12 == 0)
                {
                    Sum += Prize;
                }
                Sum += Total;
            }

            Sum -= Paid;
            Paid += Sum;

            return Sum;

        }

    }
}
