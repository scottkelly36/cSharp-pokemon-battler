using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_Species;

namespace UnitTestProject3
{
    [TestClass]
    public class RattataSpecies
    {
        [TestMethod]
        public void RattataNameTest()
        {
            Rattata rattata1 = new Rattata(10, 50);
            Assert.AreEqual(rattata1.name, "Rattata");
        }

        [TestMethod]
        public void RattataTypeTest()
        {
            Rattata rattata1 = new Rattata(10, 50);
            Assert.AreEqual(rattata1.type, "Normal");
        }

        [TestMethod]
        public void RattataMoveTest()
        {
            Rattata rattata1 = new Rattata(10, 50);
            Assert.AreEqual(rattata1.move, "Tackle");
        }

        [TestMethod]
        public void RattataUseMoveTest()
        {
            Rattata rattata1 = new Rattata(10, 50);
            Assert.AreEqual(rattata1.useMove(), 50);
        }
    }
}
