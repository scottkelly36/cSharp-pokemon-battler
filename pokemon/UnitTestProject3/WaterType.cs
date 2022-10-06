using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_types;

namespace UnitTestProject3
{
    [TestClass]
    public class TestWaterType
    {
        [TestMethod]
        public void WaterTypeName()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.AreEqual(water1.name, "Squirtle");
        }

        [TestMethod]
        public void WaterTypeType()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.AreEqual(water1.type, "Water");
        }

        [TestMethod]
        public void WaterTypeEffective()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.IsTrue(water1.isEffectiveAgainst("Fire"));
        }

        [TestMethod]
        public void WaterTypeNotEffective()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.IsFalse(water1.isEffectiveAgainst("Normal"));
            Assert.IsFalse(water1.isEffectiveAgainst("Grass"));
        }

        [TestMethod]
        public void WaterTypeWeak()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.IsTrue(water1.isWeakTo("Grass"));
        }

        [TestMethod]
        public void WaterTypeNotWeak()
        {
            WaterType water1 = new WaterType("Squirtle", 30, 50);
            Assert.IsFalse(water1.isWeakTo("Normal"));
            Assert.IsFalse(water1.isWeakTo("Fire"));
        }


    }
}