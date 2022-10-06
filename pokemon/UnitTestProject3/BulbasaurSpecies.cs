using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_Species;

namespace UnitTestProject3
{
    [TestClass]
    public class BulbasaurSpecies
    {
        [TestMethod]
        public void BulbasaurNameTest()
        {
            Bulbasaur bulbasaur1 = new Bulbasaur(20, 70);
            Assert.AreEqual(bulbasaur1.name, "Bulbasaur");
        }

        [TestMethod]
        public void BulbasaurTypeTest()
        {
            Bulbasaur bulbasaur1 = new Bulbasaur(20, 70);
            Assert.AreEqual(bulbasaur1.type, "Grass");
        }

        [TestMethod]
        public void BulbasaurMoveTest()
        {
            Bulbasaur bulbasaur1 = new Bulbasaur(20, 70);
            Assert.AreEqual(bulbasaur1.move, "Vine whip");
        }

        [TestMethod]
        public void BulbasaurUseMoveTest()
        {
            Bulbasaur bulbasaur1 = new Bulbasaur(20, 70);
            Assert.AreEqual(bulbasaur1.useMove(), 70);
        }
    }
}
