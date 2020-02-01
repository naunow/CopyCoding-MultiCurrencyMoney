using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney
{
    public class Dollar
    {
        // テストを通すための最小限の変更は、このようになる。
        public int amount = 10;
        public Dollar(int amount)
        {
            // コンパイルエラーを通すことが主眼なので、中身は空で良い。
        }

        public void Times(int multiplier)
        {
            // コンパイルエラーを通すことが主眼なので、中身は空で良い。
        }
    }
}
