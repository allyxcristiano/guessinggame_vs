using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessingGame;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame.Tests
{
    [TestClass()]
    public class NodeTests
    {
        [TestMethod()]
        public void WhenInstaceANewNodeWithNotNullTrait_NodeForSpecializatedTraitOfTraitMustBeNotNull()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(livesInWater, new Animal("monkey"));
            Assert.AreNotEqual(null, livesInWater.NodeForSpecializatedTrait);
        }

        [TestMethod()]
        public void WhenInstaceANewNodeWithNotNullTrait_NodeForSpecializatedTraitOfTraitMustBeNodeInstanciated()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(livesInWater, new Animal("monkey"));
            Assert.AreEqual(root, livesInWater.NodeForSpecializatedTrait);
        }

        [TestMethod()]
        public void WhenInstaceANewNodeWithoutTrait_ListOfTraitsOfNodeMustBeNull()
        {
            Node root = new Node(null, null);
            Assert.AreEqual(null, root.Traits);
        }

        [TestMethod()]
        public void WhenInstaceANewNodeWithAnimalNotNull_AnimalSuperiorTraitMustBeTheSame()
        {
            Animal monkey = new Animal("monkey");
            Node root = new Node(null, monkey);
            Assert.AreEqual(monkey, root.AnimalSuperiorTrait);
        }

        [TestMethod()]
        public void WhenInstaceANewNodeWithoutAnAnimal_AnimalSuperiorTraitMustBeNull()
        {
            Node root = new Node(null, null);
            Assert.AreEqual(null, root.AnimalSuperiorTrait);
        }

        [TestMethod()]
        public void WhenAddTraitOnNodeInternalListMustContaisTrait()
        {
            Node root = new Node(null, null);
            Trait livesInWater = new Trait("lives in water");
            root.addTrait(livesInWater);
            Assert.IsTrue(root.Traits.Contains(livesInWater));
        }
    }
}