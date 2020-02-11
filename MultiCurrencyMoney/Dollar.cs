using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar Times(int multiplier)
        {          
            // 新しい金額のDollarオブジェクトを返すように変更。
            // Value Objectパターン(P.238)と呼ばれる。
            return new Dollar(amount * multiplier);
        }

        public bool Equals(Object obj)
        {
            // テストを通すために、trueを返すだけの仮実装を行う。
            //return true;

            Dollar dollar = (Dollar) obj;
            return amount == dollar.amount;
        }
    }
}
