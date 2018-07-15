using Microsoft.VisualStudio.TestTools.UnitTesting;
using GuessingGame.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGameTests.fake;

namespace GuessingGame.service.Tests
{
    [TestClass()]
    public class GuessingGameServiceTests
    {
        [TestMethod()]
        public void WhenRegisterTraitSpecializated_NewNodeWithNewTraitMustBeCreatedUnderFirstTrait()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(livesInWater, new Animal("monkey"));
            Node firstChildNode = new Node(null, new Animal("shark"));
            livesInWater.NodeForSpecializatedTrait = firstChildNode;

            IGuessingGameMessages questionMessageBox = new GuessingGameMessagesFish();
            GuessingGameService guessingGameService = new GuessingGameService(questionMessageBox);
            guessingGameService.doQuestion(root);

            Trait livesInAguaDoce = livesInWater.NodeForSpecializatedTrait.Traits[0];

            Assert.AreEqual("lives in agua doce", livesInAguaDoce.Name);
        }

        public void WhenRegisterAnimal_NewNodeWithNewAnimalMustBeCreatedUnderFirstTrait()
        {
            Trait livesInWater = new Trait("lives in water");
            Node root = new Node(livesInWater, new Animal("monkey"));
            Node firstChildNode = new Node(null, new Animal("shark"));
            livesInWater.NodeForSpecializatedTrait = firstChildNode;

            IGuessingGameMessages questionMessageBox = new GuessingGameMessagesFish();
            GuessingGameService guessingGameService = new GuessingGameService(questionMessageBox);
            guessingGameService.doQuestion(root);

            Trait livesInAguaDoce = livesInWater.NodeForSpecializatedTrait.Traits[0];

            Assert.AreEqual("fish", livesInAguaDoce.NodeForSpecializatedTrait.AnimalSuperiorTrait);
        }
    }
}