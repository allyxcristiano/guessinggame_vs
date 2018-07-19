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
        private string TheAnimalThatYouThoughtAbout;

        private string TheTraitOfAnimalThatYouThoughtAbout;

        public Response aAnimalAHasButAnimalBDoesNot(string animalA, string animalB)
        {
            this.TheTraitOfAnimalThatYouThoughtAbout = "lives in agua doce";
            return Response.Ok;
        }

        public Response doesTheAnimalThatYouThoughtAbout(string trait)
        {
            return Response.Yes;
        }

        public string getTheAnimalThatYouThoughtAbout()
        {
            return TheAnimalThatYouThoughtAbout;
        }

        public string getTheTraitOfAnimalThatYouThoughtAbout()
        {
            return TheTraitOfAnimalThatYouThoughtAbout;
        }

        public Response isTheAnimalThatYouThoughtAboutA(string animal)
        {
            return Response.No;
        }

        public void iWinAgain()
        {
        }

        public Response thinkAboutAnAnimal()
        {
            return Response.Ok;
        }

        public Response whatWasTheAnimalThatYouThoughtAbout()
        {
            this.TheAnimalThatYouThoughtAbout = "fish";
            return Response.Ok;
        }
    }
}
