using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_Species;

namespace UnitTestProject3
{
    [TestClass]
    public class CharmanderSpecies
    {
        [TestMethod]
        public void CharmanderNameTest()
        {
            Charmander charmander1 = new Charmander( 10, 10);
            Assert.AreEqual(charmander1.name, "Charmander");
        }

        [TestMethod]
        public void CharmanderMoveTest()
        {
            Charmander charmander1 = new Charmander(10, 10);
            Assert.AreEqual(charmander1.move, "Ember");
        }

        [TestMethod]
        public void CharmanderUseMoveTest()
        {
            Charmander charmander1 = new Charmander(10, 10);
            Assert.AreEqual(charmander1.type, "Fire");
        }
    }
}
