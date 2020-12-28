using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_02
{
    public class DaysPayment : Subscriptions
    {

        public DaysPayment(Money _total, char symbol, int _days) : base(_total, symbol, _days)
        {
            new Subscriptions(_total, symbol, _days);
        }

        public override Money GetTotal(DateTime currDate)
        {

            if (DateStart == null)
            {
                SetStartAndEndDate(currDate, currDate.AddDays(period));
            }

            Money Sum = new Money(0, 0);

            for (int i = 0; i < ((TimeSpan)(currDate - DateStart)).TotalDays && i < period; i++)
            {
                Sum += Total; 
            }

            Sum -= Paid;
            Paid += Sum;

            return Sum;
        }

    }
}
