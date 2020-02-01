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

        public void Times(int multiplier)
        {
            // 金額の設定を、コンストラクタからTimesメソッドの中に移動する。
            //amount = 5 * 2;

            // 5はどこから来ているかというと、コンストラクタに渡された引数から来ている。
            // ならば、コンストラクタの中でamountフィールドに代入したらどうだろう。
            //amount *= 2;

            // 2はTimesメソッドの引数なので、コードにベタ書きしている値を書き換えられる。
            amount *= multiplier;
        }
    }
}
