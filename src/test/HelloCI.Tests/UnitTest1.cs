﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HelloCI.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {

            Assert.AreEqual("1", "1");
        }
    }
}
