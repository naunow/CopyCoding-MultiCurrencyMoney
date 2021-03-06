﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public abstract class Money
    {
        internal int amount;
        protected String currency;
        public abstract Money Times(int amount);

        public Money(int amount, String currency)
        {
            this.amount = amount;
            this.currency = currency;
        }

        public String Currency()
        {
            return currency;
        }

        public bool Equals(Object obj)
        {
            Money money = (Money)obj;
            return amount == money.amount 
                && GetType().Equals(money.GetType());
        }

        public static Money Dollar(int amount)
        {
            return new Dollar(amount, "USD");
        }

        public static Money Franc(int amount)
        {
            return new Franc(amount, "CHF");
        }

    }
}
