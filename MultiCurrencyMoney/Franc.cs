using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        //private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

    }
}
