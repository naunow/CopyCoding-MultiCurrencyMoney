using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Money
    {
        // Dollarクラスのamountフィールドを親クラスのMoneyに引き上げた。
        // 原著では protected だが、C#ではinternalにする必要がある。
        // protectedだと、派生クラスからアクセスするには派生クラスの型を通してアクセスしなければならない。
        internal int amount;

        public bool Equals(Object obj)
        {
            // 一時変数の型をMoneyに変更する。
            Money money = (Money)obj;
            return amount == money.amount;
        }
    }
}
