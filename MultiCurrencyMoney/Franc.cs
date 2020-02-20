using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        //public Franc(int amount, String currency)
        //{
        //    this.amount = amount;
        //    this.currency = currency;
        //}

        public Franc(int amount, String currency) : base(amount, currency)
        {

        }

        public override Money Times(int multiplier)
        {
            return Money.Franc(amount * multiplier);
        }

    }
}
