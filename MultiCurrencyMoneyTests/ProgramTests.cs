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
            five.Times(2);
            Assert.AreEqual(10, five.amount);

            // Dollarオブジェクトを操作すると、Dollarオブジェクトの状態が変化してしまう。
            // 以下のように書けるようにしたいが、テストは通らない。
            five.Times(3);
            Assert.AreEqual(15, five.amount);
        }
    }
}