using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Money
    {
        internal int amount;

        public bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}
