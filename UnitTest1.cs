using Microsoft.VisualStudio.TestTools.UnitTesting;
using unitTest;
using System;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("jlarreygue@sciodev.com", true)]
        [DataRow("jlarreygue@sciodev", true)]
        [DataRow("jlarreygue@s@ciodev.com", false)]
        [DataRow("@sciodev.com", false)]
        [DataRow("jlarreygue@sciodev.com.com", true)]
        [DataRow("jlarreyguesciodev.com", false)]
        [DataRow("jlarreygue@", false)]
        [DataRow("jlarrey_gue@sciodev.com", true)]
        [DataRow("jlarreygue@scio_dev.com", true)]
        public void TestMethod1(String a, bool b)
        {
            Class1 obj = new Class1();

            Assert.AreEqual(b,obj.email(a));
        }
    }
}
