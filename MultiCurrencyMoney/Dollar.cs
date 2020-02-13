using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar : Money
    {
        // テストを変更したことで、amountフィールドをprivateに変更できる。
        private int amount;

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
            Dollar dollar = (Dollar) obj;
            return amount == dollar.amount;
        }
    }
}
