using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Block_Beasts_Library.Talents;

namespace Block_Beasts_Library
{
    public class Battle
    {
        //keep track of average blows it takes to take down a beast
        static int DodgeChance()
        {
            Random DodgeRoll = new Random();
            int Dodge = DodgeRoll.Next(1, 101);

            if (Dodge < 51)  
            {
                // Add the dodge
                Console.WriteLine("You dodged the attack!");
            }
            else if (Dodge < 101)  
            {
                 //Add the dodge
                Console.WriteLine("Your beast is Strong!\nIncreased damage buff, oh yeah!");
            }
            return Dodge;
        }
    }
}
