using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc
    {
        private int amount;

        public Franc(int amount)
        {
            this.amount = amount;
        }

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        public bool Equals(Object obj)
        {
            Franc franc = (Franc)obj;
            return amount == franc.amount;
        }

    }
}
