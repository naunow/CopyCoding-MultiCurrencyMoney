﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        private String currency;
        public Dollar(int amount)
        {
            this.amount = amount;
            currency = "USD";
        }

        public override string Currency()
        {
            return currency;
        }

        public override Money Times(int multiplier)
        {          
            return new Dollar(amount * multiplier);
        }

    }
}
