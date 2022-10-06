using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using pokemon.Pokemon_types;

namespace UnitTestProject3
{
    [TestClass]
    public class TestPokemonVariable
    {
        [TestMethod]
        public void TestPokemonName()
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Assert.AreEqual(pokemon1.name, "Charmander");           
        }

        [TestMethod]
        public void TestPokemonType()
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Assert.AreEqual(pokemon1.type, "Normal");
        }

        [TestMethod]
        public void TestPokemonHitpoints()
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Assert.AreEqual(pokemon1.hitpoints, 10);
        }

        [TestMethod]
        public void TestPokemonAttackDamage()
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Assert.AreEqual(pokemon1.attackDamage, 10);
        }

        [TestMethod]
        public void TestPokemonMove()
        {
            Pokemon pokemon1 = new Pokemon("Charmander", 10, 10);
            Assert.AreEqual(pokemon1.move, "Tackle");
        }

        [TestMethod]
        public void TestPokemonisEffectiveAgainst()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 12, 10);
            Assert.IsFalse(pokemon1.isEffectiveAgainst());
        }

        [TestMethod]
        public void TestPokemonIsWeakTo()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 12, 10);
            Assert.IsFalse(pokemon1.isWeakTo());
        }

        [TestMethod]
        public void TestPokemonTakeDamage()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 12, 10);
            pokemon1.takeDamage(2);
            Assert.AreEqual(pokemon1.hitpoints, 10);
        }

        [TestMethod]
        public void TestPokemonUseMove()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 12, 10);
            Assert.AreEqual(pokemon1.useMove(), 10);
        }

        [TestMethod]
        public void TestPokemonHasFainted()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 0, 10);
            Assert.AreEqual(pokemon1.hasFainted(), true);
        }

        [TestMethod]
        public void TestPokemonHasNotFainted()
        {
            Pokemon pokemon1 = new Pokemon("Bulbasaur", 12, 10);
            Assert.AreEqual(pokemon1.hasFainted(), false);
        }
    }
}
