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
            // Dollarを返すFactoryメソッドをMoneyに定義する。
            // そのメソッドはこうやって使う。
            Money five = Money.Dollar(5);

            Assert.IsTrue(Money.Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Dollar(15).Equals(five.Times(3)));

        }

        [TestMethod()]
        public void TestEquality()
        {
            Assert.IsTrue(Money.Dollar(5).Equals(Money.Dollar(5)));
            Assert.IsFalse(Money.Dollar(5).Equals(Money.Dollar(6)));

            Assert.IsTrue(Money.Franc(5).Equals(Money.Franc(5)));
            Assert.IsFalse(Money.Franc(5).Equals(Money.Franc(6)));

            // DollarとFrancを比較したらどうなるのか、テストに書いてみよう。
            Assert.IsFalse(Money.Franc(5).Equals(Money.Dollar(5)));

        }

        [TestMethod()]
        public void TestFrancMultiplication()
        {
            Money five = Money.Franc(5);
            Assert.IsTrue(Money.Franc(10).Equals(five.Times(2)));
            Assert.IsTrue(Money.Franc(15).Equals(five.Times(3)));
        }

        public void TestCurrency()
        {
            Assert.AreEqual("USD", Money.Dollar(1).Currency());
            Assert.AreEqual("CHF", Money.Franc(1).Currency());
        }
    }
}