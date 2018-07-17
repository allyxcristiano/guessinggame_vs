using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame.service
{
    public class GuessingGameService
    {
        private IGuessingGameMessages GuessingGameMessages;

        public GuessingGameService(IGuessingGameMessages guessingGameMessages)
        {
            this.GuessingGameMessages = guessingGameMessages;
        }

        public Boolean startGame()
        {
            Response response = this.GuessingGameMessages.ThinkAboutAnAnimal();
            return response == Response.Ok;
        }

        public void doQuestion(Node node)
        {
            Response awnser;
            int index = 0;

            while (hasTraitsToCheck(node, index))
            {
                Trait currentTrait = node.Traits[index];

                awnser = this.GuessingGameMessages.doesTheAnimalThatYouThoughtAbout(currentTrait.Name);
                if (awnser == Response.Yes && currentTrait.NodeForSpecializatedTrait != null)
                {
                    this.doQuestion(currentTrait.NodeForSpecializatedTrait);
                    return;
                }

                index++;
            }

            awnser = this.GuessingGameMessages.isTheAnimalThatYouThoughtAboutA(node.AnimalSuperiorTrait.Name);
            if (awnser == Response.No)
            {
                awnser = this.GuessingGameMessages.whatWasTheAnimalThatYouThoughtAbout();

                if (awnser == Response.Cancel)
                    return;

                string animal = this.GuessingGameMessages.getTheAnimalThatYouThoughtAbout();

                awnser = this.GuessingGameMessages.aAnimalAHasButAnimalBDoesNot(animal, node.AnimalSuperiorTrait.Name);

                if (awnser == Response.Cancel)
                    return;

                string trait = this.GuessingGameMessages.getTheTraitOfAnimalThatYouThoughtAbout();

                Trait newSpecializatedTrait = new Trait(trait);
                Animal newAnimal = new Animal(animal);
                Node newNode = new Node(null, newAnimal);
                newSpecializatedTrait.NodeForSpecializatedTrait = newNode;
                node.addTrait(newSpecializatedTrait);
            }
            else
            {
                this.GuessingGameMessages.iWinAgain();
            }
        }

        private static bool hasTraitsToCheck(Node node, int index)
        {
            return node.Traits != null && index < node.Traits.Count;
        }
    }
}