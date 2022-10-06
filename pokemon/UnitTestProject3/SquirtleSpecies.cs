using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_Species;

namespace UnitTestProject3
{
    [TestClass]
    public class SquirtleSpecies
    {
        [TestMethod]
        public void SquirtleNameTest()
        {
            Squirtle squirtle1 = new Squirtle(10, 10);
            Assert.AreEqual(squirtle1.name, "Squirtle");
        }

        [TestMethod]
        public void SquirtleTypeTest()
        {
            Squirtle squirtle1 = new Squirtle(10, 10);
            Assert.AreEqual(squirtle1.type, "Water");
        }

        [TestMethod]
        public void SquirtleMoveTest()
        {
            Squirtle squirtle1 = new Squirtle(10, 10);
            Assert.AreEqual(squirtle1.move, "Water gun");
        }

        [TestMethod]
        public void SquirtleUseMoveTest()
        {
            Squirtle squirtle1 = new Squirtle(10, 10);
            Assert.AreEqual(squirtle1.useMove(), 10);
        }
    }
}
