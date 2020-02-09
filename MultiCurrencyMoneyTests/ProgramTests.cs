﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
    }
}