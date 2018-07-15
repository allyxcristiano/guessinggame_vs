using System;

namespace GuessingGame
{
    public class Trait
    {
        public string Name { get; }

        public Node NodeForSpecializatedTrait { get; set; }

        public Trait(string name)
        {
            this.Name = name;
        }
    }
}