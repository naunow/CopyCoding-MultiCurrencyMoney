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
            return new Dollar(amount * multiplier);
        }
    }
}
