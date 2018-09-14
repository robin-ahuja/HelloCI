using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HelloCI.Tests
{
    [TestClass]
    class Class1
    {
        [TestMethod]       
        public void Test()
        {
            //comments added
            Assert.AreEqual("1","1");
        }
    }
}
