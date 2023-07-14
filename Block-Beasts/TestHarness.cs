using Block_Beasts_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Block_Beasts_Library;
using System.Threading;

namespace Block_Beasts // I'm using this area to test out certain methods and ideas I have for my app.
{
    public class TestHarness
    {
        static void Main(string[] args)
        {
            // 6-29 : My first step will be to make my BlockBeast egg hatching mechanic.
            // I will call to my class library for characteristics for each beast.

            // Below is the mechanic used to create a beast. 
            //TODO make a number system to balance out the chances and attributes

            Console.WriteLine("You think to yourself about how nervous ypu are thinking about entering the BLOCK BEAST BATTLE-THON,\n" +
                "but you think back to the first time you met your loyal beasts...");

            Console.WriteLine("\n... flashback into your childhood home ...");
            Console.WriteLine("\n\nYou have 3 shaking eggs Infront of you, They are the size of your body! They are huge!");
            Console.WriteLine("You grab the egg on the left. It is colored red with a flame pattern, It's a fire Beast!\n");

            Random rngTalent = new Random();
            Array talents = Enum.GetValues(typeof(Talents.Talent));
            List<Talents.Talent> threeRandomTalents = new List<Talents.Talent>(3);
            for (int i = 0; i < threeRandomTalents.Count(); i++)
            {
                threeRandomTalents[i] = (Talents.Talent)talents.GetValue(rngTalent.Next(talents.Length));
            }


            //List<Monster> monsters = new()
            //{
            //    m1, m1,
            //    m2, m2, m2, m2,
            //    m3, m3, m3,
            //    m4
            //};


            // Template beast below 
            Beast Flambug = new Beast(
                "Flambug", //Name 
                25, // Health 
                25, // Max Health
                //"Fire",
                3, // crit hit chance
                //Talent 
                1, // damage 
                3, // dodge
                3, // miss 
                "It's eyebrows look like red error lines!" // description 
                );

            Console.WriteLine(Flambug.ToString());





        }
    }
}
