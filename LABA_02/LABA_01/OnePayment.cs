using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_02
{
    public class OnePayment :  Subscriptions
    {

        public OnePayment(Money _total) : base( _total)
        {
            new Subscriptions(_total);
        }

        public OnePayment(Money _total, char symbol) : base(_total, symbol)
        {
            new Subscriptions( _total,  symbol);
        }


        public override Money GetTotal(DateTime currDate)
        {
            if (Total == Paid) return new Money(0, 0);
            SetStartAndEndDate(DateTime.Now, DateTime.Now);
            Paid = Total;
            return Total;
        }


    }
}
