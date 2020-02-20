using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Franc : Money
    {
        // 2つのサブクラスの実装を近づけていって、同じものにしてしまいたい。
        // インスタンス変数に通貨名を格納していって、それを返すだけの実装にできそうだ。
        public Franc(int amount, String currency)
        {
            this.amount = amount;
            this.currency = "CHF";
        }

        public override Money Times(int multiplier)
        {
            // MoneyのFactory Methodを呼び出すべきなので、修正した。
            return Money.Franc(amount * multiplier);
        }

    }
}
