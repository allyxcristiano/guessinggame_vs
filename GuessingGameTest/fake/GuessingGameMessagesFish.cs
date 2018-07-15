using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GuessingGame;

namespace GuessingGameTests.fake
{
    public class GuessingGameMessagesFish : IGuessingGameMessages
    {
        private string theAnimalThatYouThoughtAbout;

        private string theTraitOfAnimalThatYouThoughtAbout;

        public Response aAnimalAHasButAnimalBDoesNot(string animalA, string animalB)
        {
            this.theTraitOfAnimalThatYouThoughtAbout = "lives in agua doce";
            return Response.Ok;
        }

        public Response doesTheAnimalThatYouThoughtAbout(string trait)
        {
            return Response.Yes;
        }

        public string getTheAnimalThatYouThoughtAbout()
        {
            return theAnimalThatYouThoughtAbout;
        }

        public string getTheTraitOfAnimalThatYouThoughtAbout()
        {
            return theTraitOfAnimalThatYouThoughtAbout;
        }

        public Response isTheAnimalThatYouThoughtAboutA(string animal)
        {
            return Response.No;
        }

        public void iWinAgain()
        {
        }

        public Response ThinkAboutAnAnimal()
        {
            return Response.Ok;
        }

        public Response whatWasTheAnimalThatYouThoughtAbout()
        {
            this.theAnimalThatYouThoughtAbout = "fish";
            return Response.Ok;
        }
    }
}
