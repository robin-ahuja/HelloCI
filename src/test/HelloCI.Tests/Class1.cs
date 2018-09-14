using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace HelloCI.Tests
{
    [TestFixture]
    class Class1
    {
        [Test]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Test()
        {
            //comments
            int i = 10, j = 0, x;
            x = i / j;
        }
    }
}
