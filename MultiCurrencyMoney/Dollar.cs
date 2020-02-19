using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {          
            return new Dollar(amount * multiplier);
        }

    }
}
