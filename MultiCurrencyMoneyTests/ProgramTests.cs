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

            Dollar five = new Dollar(5);
            //Assert.AreEqual(new Dollar(10), five.Times(2));
            //Assert.AreEqual(new Dollar(15), five.Times(3));

            //『テスト駆動開発』ではJavaで書かれていて上記のテストが通るが、C#だとテストが通らない。
            // C#のAreEqualメソッドは同じインスタンス同士かまで比較してしまうので、
            // 以下のように書き換える必要がある。(EqualsメソッドはDollarクラスに自作)
            Assert.IsTrue(new Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(new Dollar(15).Equals(five.Times(3)));

        }

        [TestMethod()]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }
}