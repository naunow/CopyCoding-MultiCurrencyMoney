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

        public Franc Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

        // FrancのEqualsメソッドも、Dollarとまったく同じにできたので、削除できる。
        //public bool Equals(Object obj)
        //{
        //    Money money = (Money)obj;
        //    return amount == money.amount;
        //}

    }
}
