using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        public Franc(int amount)
        {
            this.amount = amount;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

    }
}
