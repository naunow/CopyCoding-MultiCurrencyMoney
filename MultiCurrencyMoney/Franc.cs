using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        // 2つのサブクラスの実装を近づけていって、同じものにしてしまいたい。
        // インスタンス変数に通貨名を格納していって、それを返すだけの実装にできそうだ。
        private String currency;
        public Franc(int amount)
        {
            this.amount = amount;
            currency = "CHF";
        }

        public override string Currency()
        {
            return currency;
        }

        public override Money Times(int multiplier)
        {
            return new Franc(amount * multiplier);
        }

    }
}
