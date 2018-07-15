using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame.service
{
    class GuessingGameService
    {
        private IGuessingGameMessages guessingGameMessages;

        public GuessingGameService(IGuessingGameMessages guessingGameMessages)
        {
            this.guessingGameMessages = guessingGameMessages;
        }

        public Boolean startGame()
        {
            Response response = this.guessingGameMessages.ThinkAboutAnAnimal();
            return response == Response.OK;
        }

        public void doQuestion(Node node)
        {
            Response awnser;
            int index = 0;

            while (hasTraitsToCheck(node, index))
            {
                Trait currentTrait = node.Traits[index];

                awnser = this.guessingGameMessages.doesTheAnimalThatYouThoughtAbout(currentTrait.Name);
                if (awnser == Response.Yes && currentTrait.NodeForSpecializatedTrait != null)
                {
                    this.doQuestion(currentTrait.NodeForSpecializatedTrait);
                    return;
                }

                index++;
            }

            awnser = this.guessingGameMessages.isTheAnimalThatYouThoughtAboutA(node.AnimalSuperiorTrait.Name);
            if (awnser == Response.No)
            {
                awnser = this.guessingGameMessages.whatWasTheAnimalThatYouThoughtAbout();

                if (awnser == Response.Cancel)
                    return;

                string animal = this.guessingGameMessages.getTheAnimalThatYouThoughtAbout();

                awnser = this.guessingGameMessages.aAnimalAHasButAnimalBDoesNot(animal, node.AnimalSuperiorTrait.Name);

                if (awnser == Response.Cancel)
                    return;

                string trait = this.guessingGameMessages.getTheTraitOfAnimalThatYouThoughtAbout();

                Trait newSpecializatedTrait = new Trait(trait);
                Animal newAnimal = new Animal(animal);
                Node newNode = new Node(null, newAnimal);
                newSpecializatedTrait.NodeForSpecializatedTrait = newNode;
                node.addTrait(newSpecializatedTrait);
            }
            else
            {
                this.guessingGameMessages.iWinAgain();
            }
        }

        private static bool hasTraitsToCheck(Node node, int index)
        {
            return node.Traits != null && index < node.Traits.Count;
        }
    }
}