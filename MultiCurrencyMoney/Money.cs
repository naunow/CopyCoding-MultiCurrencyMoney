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
            // 型が一致するかどうかの判定を行う。
            return amount == money.amount 
                && GetType().Equals(money.GetType());
        }
    }
}
