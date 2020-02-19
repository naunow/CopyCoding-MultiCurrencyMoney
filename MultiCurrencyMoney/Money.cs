﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        internal int amount;
        public abstract Money Times(int amount);

        public bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount 
                && GetType().Equals(money.GetType());
        }

        public static Dollar Dollar(int amount)
        {
            return new Dollar(amount);
        }
    }
}
