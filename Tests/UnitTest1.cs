using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Modele.Entities;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Employe e = new Employe();
            Assert.IsNull(e.Biographie);
        }
    }
}
