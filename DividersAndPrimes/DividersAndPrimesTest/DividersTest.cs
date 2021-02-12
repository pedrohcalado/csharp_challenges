using Microsoft.VisualStudio.TestTools.UnitTesting;
using DividersAndPrimesNS;
using System.Collections.Generic;
using System;

namespace DividersAndPrimesTest
{
    [TestClass]
    public class DividersTest
    {
        [TestMethod]
        public void TestGetDividers_ShouldReturnListWithDividers()
        {
            DividersAndPrimes entry = new DividersAndPrimes();
            List<int> expected = new List<int>{1, 3, 5, 9, 15, 45};
            List<int> actual = entry.GetDividers(45);
            Assert.AreEqual(String.Join(" ", expected), String.Join(" ", actual));
        }

        [TestMethod]
        public void TestGetPrimeDividers_ShouldReturnListWithPrimeDividers()
        {
            DividersAndPrimes entry = new DividersAndPrimes();
            List<int> expected = new List<int> { 1, 3, 5 };
            List<int> actual = entry.GetPrimeDividers(45);
            Assert.AreEqual(String.Join(" ", expected), String.Join(" ", actual));
        }
    }
}
