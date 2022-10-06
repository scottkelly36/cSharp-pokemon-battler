using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_types;

namespace UnitTestProject3
{
    [TestClass]
    public class GrassTypeTest
    {
        [TestMethod]
        public void GrassTypeName()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.AreEqual(grass1.name, "Bulbasaur");
        }

        [TestMethod]
        public void GrassTypeType()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.AreEqual(grass1.type, "Grass");
        }

        [TestMethod]
        public void GrassTypeEffective()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.IsTrue(grass1.isEffectiveAgainst("Water"));
        }

        [TestMethod]
        public void GrassTypeNotEffective()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.IsFalse(grass1.isEffectiveAgainst("Fire"));
            Assert.IsFalse(grass1.isEffectiveAgainst("Normal"));
        }

        [TestMethod]
        public void GrassTypeWeak()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.IsTrue(grass1.isWeakTo("Fire"));
        }

        [TestMethod]
        public void GrassTypeNotWeak()
        {
            GrassType grass1 = new GrassType("Bulbasaur", 30, 50);
            Assert.IsFalse(grass1.isWeakTo("Water"));
            Assert.IsFalse(grass1.isWeakTo("Normal"));
        }
    }
}
