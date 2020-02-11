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
            // Timesメソッドから新しいオブジェクトが返るように実装するには、テストも書き換えないといけない。
            // 正しいインターフェースをひらめくのは、正しい実装をひらめくのと同じくらい難しい。
            Dollar five = new Dollar(5);
            Dollar product = five.Times(2);
            Assert.AreEqual(10, product.amount);
            product = five.Times(3);
            Assert.AreEqual(15, product.amount);
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