using System.Collections.Generic;

namespace GuessingGame
{
    public class Node
    {
        public string Name { get; }
        public List<Trait> Traits { get; set; }
        public Animal AnimalSuperiorTrait { get; }

        public Node(Trait initialTrait, Animal animalSuperiorTrait)
        {
            if (initialTrait != null)
            {
                this.addTrait(initialTrait);
                initialTrait.NodeForSpecializatedTrait = this;
            }

            this.AnimalSuperiorTrait = animalSuperiorTrait;
        }

        public void addTrait(Trait trait)
        {
            if (Traits == null)
                Traits = new List<Trait>();

            Traits.Add(trait);
        }
    }
}