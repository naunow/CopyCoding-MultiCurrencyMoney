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
            Dollar five = new Dollar(5);
            Assert.IsTrue(new Dollar(10).Equals(five.Times(2)));
            Assert.IsTrue(new Dollar(15).Equals(five.Times(3)));

        }

        [TestMethod()]
        public void TestEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));

            // Francの等価性比較のテストを書いていなかった。気づいたときに、テストは追加しよう。
            Assert.IsTrue(new Franc(5).Equals(new Franc(5)));
            Assert.IsFalse(new Franc(5).Equals(new Franc(6)));

        }

        [TestMethod()]
        public void TestFrancMultiplication()
        {
            Franc five = new Franc(5);
            Assert.IsTrue(new Franc(10).Equals(five.Times(2)));
            Assert.IsTrue(new Franc(15).Equals(five.Times(3)));
        }
    }
}