using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABA_02
{
    public class  Subscriptions
    {
        protected Money Total;

        protected Money Paid = new Money(0, 0);

        protected bool IsKey;

        protected DateTime? DateStart = null;
  
        protected DateTime DateEnd;

        public int period;

      

        public Subscriptions(Money _total)
        {
            Total = _total;
            IsKey = false;
        }


        public Subscriptions(Money _total, char symbol)
        {
            Total = _total;
            if (symbol == '+' ) 
            {
                IsKey = true;
            }
            else if(symbol == '-')
            {
                IsKey = false;
            }
        }

        public Subscriptions(Money _total, char symbol, int _period)
        {
            Total = _total;
            if (symbol == '+')
            {
                IsKey = true;
            }
            else if (symbol == '-')
            {
                IsKey = false;
            }
            period = _period;
        }

        protected void SetStartAndEndDate(DateTime start, DateTime end)
        {
            DateStart = start;
            DateEnd = end;
        }


        public bool GetIsKey()
        {
            return IsKey;
        }

        public virtual Money GetTotal(DateTime currDate)
        {
            return new Money(0, 0);
        }

        public DateTime GetDateStart()
        {
            return (DateTime)DateStart;
        }

        public  virtual DateTime GetDateEnd()
        {
            return (DateTime)DateEnd;
        }
      
    }
}
