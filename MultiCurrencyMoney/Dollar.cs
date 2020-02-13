using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        //private int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {          
            return new Dollar(amount * multiplier);
        }

        public bool Equals(Object obj)
        {
            // 一時変数の型をMoneyに変更する。
            Money money = (Money) obj;
            return amount == money.amount;
        }
    }
}
