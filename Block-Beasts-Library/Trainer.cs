using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Beasts_Library
{
    // This class is for the player. The character parent class will be for the Beasts (weapons). This class is strictly just for the storyline of my app.
    public class Trainer
    {

        // FIELDS - Funny
        // I am not using any business rules 

        // PROPS - People
        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }


        // CTOR - Collect
        public Trainer (string name, int age, string gender) // Params must be closer case so we can assign the props to the params
        {
            Name = Name;
            Age = Age;
            Gender = Gender; 
        }

        // METHODS - Monkeys

        public override string ToString()
        {
            return $" {Name} - {Age} - {Gender}" ;
        }


    }
}      