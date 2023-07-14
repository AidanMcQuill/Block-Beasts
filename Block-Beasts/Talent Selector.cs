using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Block_Beasts
{
    public class Talent_Selector
    {
        static void Main(string[] args)
        {
            


            //var chosenTalent = Enum.GetValues<Talent>();

            Array talents = Enum.GetValues(typeof(Talent));
            Random rngTalent = new Random();
            Talent randomTalent = (Talent)talents.GetValue(rngTalent.Next(talents.Length));
            

            switch (randomTalent)
            {
                case Talent.Timid:
                    Console.WriteLine("Your beast is Timid!\nIt has a better chance at dodging.");
                    // Add buff / nerf to the respective attribute 
                    break;
                case Talent.strong:
                    Console.WriteLine("Your beast is Strong!\nIncreased damage buff, oh yeah!");
                    // Add buff / nerf to the respective attribute 
                    break;
                case Talent.boring:
                    Console.WriteLine("Your beast is Boring!\nYour beast has no change, boo hoo");
                    // Add buff / nerf to the respective attribute 
                    break;
                case Talent.Clumsy:
                    Console.WriteLine("Your beast is Clumsy!\nIncreased Miss chance when in combat :( ");
                    // Add buff / nerf to the respective attribute 
                    break;
                case Talent.Weak:
                    Console.WriteLine("Your beast is Weak!\nYour frail beast won't do as much damage to others.");
                    // Add buff / nerf to the respective attribute 
                    break;
                default:
                    break;

            }

            Console.WriteLine(randomTalent);
        }



        public enum Talent { // Numbered to make things easier when randomizing the selection for rolling 
            Timid = 0, // dodge ability increased (12.5%)
            strong = 1, // extra attack power (12.5%)
            boring = 2, // No buff/Nerf applied to mon (50%) 
            Clumsy = 3, // A more likely chance to miss your attacks (12.5%)
            Weak = 4, // less attack power (12.5%

        }
    }
}

