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
    public class AnimalTests
    {
        [TestMethod()]
        public void NamePassedOnConstructorOfNewAnimal_MustMatchWithNewAnimalName()
        {
            Animal monkey = new Animal("monkey");
            Assert.AreEqual("monkey", monkey.Name);
        }
    }
}