using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuessingGame.implementation
{
    public class GuessingGameMessagesDialog : IGuessingGameMessages
    {
        private string TheAnimalThatYouThoughtAbout;

        private string TheTraitOfAnimalThatYouThoughtAbout;

        public GuessingGameMessagesDialog()
        {
        }

        public Response aAnimalAHasButAnimalBDoesNot(string animalA, string animalB)
        {
            WhatTheAnimalTrait whatTheAnimalTrait = new WhatTheAnimalTrait(animalA, animalB);
            DialogResult result = whatTheAnimalTrait.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.TheTraitOfAnimalThatYouThoughtAbout = whatTheAnimalTrait.AnimalTrait;
            }

            return (result == System.Windows.Forms.DialogResult.OK) ? Response.Ok : Response.Cancel;
        }

        public Response doesTheAnimalThatYouThoughtAbout(string trait)
        {
            string message = String.Format("Does the animal that you thought about {0}?", trait);
            DialogResult result = MessageBox.Show(message, "Guessing Game", MessageBoxButtons.YesNo);
            return (result == System.Windows.Forms.DialogResult.Yes) ? Response.Yes : Response.No;
        }

        public string getTheAnimalThatYouThoughtAbout()
        {
            return this.TheAnimalThatYouThoughtAbout;
        }

        public string getTheTraitOfAnimalThatYouThoughtAbout()
        {
            return this.TheTraitOfAnimalThatYouThoughtAbout;
        }

        public Response isTheAnimalThatYouThoughtAboutA(string animal)
        {
            string message = String.Format("Is the animal that you thought about a {0}?", animal);
            DialogResult result = MessageBox.Show(message, "Guessing Game", MessageBoxButtons.YesNo);
            return (result == System.Windows.Forms.DialogResult.Yes) ? Response.Yes : Response.No;
        }

        public void iWinAgain()
        {
            MessageBox.Show("I win again!", "Guessing Game", MessageBoxButtons.OK);
        }

        public Response ThinkAboutAnAnimal()
        {
            DialogResult result = MessageBox.Show("Think about an animal...", "Guessing Game", MessageBoxButtons.OKCancel);
            return (result == System.Windows.Forms.DialogResult.OK) ? Response.Ok : Response.Cancel;
        }

        public Response whatWasTheAnimalThatYouThoughtAbout()
        {
            WhatTheAnimal whatTheAnimal = new WhatTheAnimal();
            DialogResult result = whatTheAnimal.ShowDialog();

            if (result == DialogResult.OK)
            {
                this.TheAnimalThatYouThoughtAbout = whatTheAnimal.AnimalName;
            }

            return (result == System.Windows.Forms.DialogResult.OK) ? Response.Ok : Response.Cancel;
        }
    }
}