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
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test()
        {
            //comments
            int i = 10, j = 0, x;
            x = i / j;
        }
    }
}
