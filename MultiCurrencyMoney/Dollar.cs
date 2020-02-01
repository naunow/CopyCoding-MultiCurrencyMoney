using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        public int amount;
        //public int amount = 5 * 2;
        //public int amount = 10;

        public Dollar(int amount)
        {

        }

        public void Times(int multiplier)
        {
            // 金額の設定を、コンストラクタからTimesメソッドの中に移動する。
            amount = 5 * 2;
        }
    }
}
