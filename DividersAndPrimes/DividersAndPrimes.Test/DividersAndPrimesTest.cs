using Microsoft.VisualStudio.TestTools.UnitTesting;
using DividersAndPrimes.Service;
using System.Collections.Generic;
using System;

namespace DividersAndPrimesTest
{
    [TestClass]
    public class DividersAndPrimesTest
    {
        [TestMethod]
        public void TestGetDividers_ShouldReturnListWithDividers()
        {
            List<int> expected = new List<int> { 1, 3, 5, 9, 15, 45 };
            List<int> actual = MainClass.GetDividers(45);
            Assert.AreEqual(String.Join(" ", expected), String.Join(" ", actual));
        }

        [TestMethod]
        public void TestGetPrimeDividers_ShouldReturnListWithPrimeDividers()
        {
            List<int> expected = new List<int> { 3, 5 };
            List<int> actual = MainClass.GetPrimeDividers(45);
            Assert.AreEqual(String.Join(" ", expected), String.Join(" ", actual));
        }
    }
}
