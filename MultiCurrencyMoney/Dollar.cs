using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        public Dollar(int amount, String currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public override Money Times(int multiplier)
        {          
            return Money.Dollar(amount * multiplier);
        }

    }
}
