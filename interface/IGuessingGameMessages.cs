using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    public enum Response { No, Yes, OK, Cancel};

    public interface IGuessingGameMessages
    {
        Response ThinkAboutAnAnimal();

        Response doesTheAnimalThatYouThoughtAbout(string trait);

        Response isTheAnimalThatYouThoughtAboutA(string animal);

        Response whatWasTheAnimalThatYouThoughtAbout();

        Response aAnimalAHasButAnimalBDoesNot(string animalA, string animalB);

        string getTheAnimalThatYouThoughtAbout();

        string getTheTraitOfAnimalThatYouThoughtAbout();

        void iWinAgain();
    }
}
