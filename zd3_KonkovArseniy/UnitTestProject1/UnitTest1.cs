using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Reflection.Emit;
using Cables;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CableQualityCalculation_ShouldReturnCorrectValue()
        {
            var cable = new Cable("Test", 4, 8.0, "TestMan", 10.0);
            double quality = cable.CalculateQuality();
            Assert.AreEqual(2.0, quality);
        }

        [TestMethod]
        public void EnhancedCableQuality_WithBraiding_ShouldDoubleQuality()
        {
            var enhancedCable = new EnhancedCable("Test", 4, 8.0, "TestMan", 10.0, true, "Black");
            double quality = enhancedCable.CalculateQuality();
            Assert.AreEqual(4.0, quality);
        }

        [TestMethod]
        public void EnhancedCableQuality_WithoutBraiding_ShouldReduceQuality()
        {
            var enhancedCable = new EnhancedCable("Test", 4, 8.0, "TestMan", 10.0, false, "White");
            double quality = enhancedCable.CalculateQuality();
            Assert.AreEqual(1.4, quality);
        }

        [TestMethod]
        public void AddCable_ShouldIncreaseListCount()
        {
            var cables = new List<Cable>();
            Cable.AddCable(cables, new Cable("Test", 2, 3.0, "TestMan", 5.0));
            Assert.AreEqual(1, cables.Count);
        }

        [TestMethod]
        public void RemoveCable_ByObject_ShouldDecreaseListCount()
        {
            var cables = new List<Cable>();
            var cable = new Cable("Test", 2, 3.0, "TestMan", 5.0);
            cables.Add(cable);
            bool result = Cable.RemoveCable(cables, cable);
            Assert.IsTrue(result);
            Assert.AreEqual(0, cables.Count);
        }

        [TestMethod]
        public void RemoveCable_ByName_ShouldDecreaseListCount()
        {
            var cables = new List<Cable>();
            cables.Add(new Cable("Test", 2, 3.0, "TestMan", 5.0));
            bool result = Cable.RemoveCable(cables, "Test");
            Assert.IsTrue(result);
            Assert.AreEqual(0, cables.Count);
        }
    }
}
