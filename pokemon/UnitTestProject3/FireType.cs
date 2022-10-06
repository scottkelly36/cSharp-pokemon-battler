using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_types;

namespace UnitTestProject3
{
    [TestClass]
    public class TestFireType
    {
        [TestMethod]
        public void FireTypeName()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.AreEqual(fire1.name, "Charmander");
        }

        [TestMethod]
        public void FireTypeType()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.AreEqual(fire1.type, "Fire");
        }

        [TestMethod]
        public void FireTypeEffective()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.IsTrue(fire1.isEffectiveAgainst("Grass"));
        }

        [TestMethod]
        public void FireTypeNotEffective()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.IsFalse(fire1.isEffectiveAgainst("Water"));
            Assert.IsFalse(fire1.isEffectiveAgainst("Normal"));
        }

        [TestMethod]
        public void FireTypeWeak()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.IsTrue(fire1.isWeakTo("Water"));
        }

        [TestMethod]
        public void FireTypeNotWeak()
        {
            FireType fire1 = new FireType("Charmander", 30, 50);
            Assert.IsFalse(fire1.isWeakTo("Normal"));
            Assert.IsFalse(fire1.isWeakTo("Grass"));
        }
    }
}
