using Microsoft.VisualStudio.TestTools.UnitTesting;
using MultiCurrencyMoney;
using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCurrencyMoney.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void TestMultiplication()
        {
            // 概念的には、DollarのTimesメソッドは、自身の金額とmultiplier引数をかけた値を保持するDollarを返すべきだ。
            // だが、ここまで書いてきたテストからは、Dollarを返すことは伝わりにくい。
            // 最初のアサーションを修正して、Dollar同士を直接比較しよう。

            // これで一時変数productは用をなさなくなったので、インライン化(P.258)してしまえる。
            Dollar five = new Dollar(5);
            //Dollar product = five.Times(2);
            Assert.AreEqual(new Dollar(10), /*product*/ five.Times(2));
            //product = five.Times(3);
            Assert.AreEqual(new Dollar(15), /*product*/ five.Times(3));
        }

        [TestMethod()]
        public void TestEquality()
        {
            // 三角測量を行うためには、実例は2つ必要になる。
            // すると、等価性比較を一般化する必要が生まれる。
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

            // 実は、Timesメソッドの一般化にも三角測量を使える。
            // $5 * 2 = $10 と、$5 * 3 = $15 が出てきたら、もうベタ書きの値を返すことはできないからだ。

        }
    }
}