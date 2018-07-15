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
    public class TraitTests
    {
        [TestMethod()]
        public void NamePassedOnConstructorOfNewTrait_MustMatchWithNewTraitName()
        {
            Trait livesInWater = new Trait("lives in water");
            Assert.AreEqual("lives in water", livesInWater.Name);
        }

        [TestMethod()]
        public void TraitWithNodeForSpecializatedTrait_MustHaveGetterReturningThisNode()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(null, null);
            livesInWater.NodeForSpecializatedTrait = root;
            Assert.AreEqual(root, livesInWater.NodeForSpecializatedTrait);
        }
    }
}