using Block_Beasts_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Block_Beasts_Library;
using System.Threading;
using System.Numerics;

namespace Block_Beasts // I'm using this area to test out certain methods and ideas I have for my app.
{
    public class TestHarness
    {
        static void Main(string[] args)
        {
            #region Beast Rolls 
            // 6-29 : My first step will be to make my BlockBeast egg hatching mechanic.
            // I will call to my class library for characteristics for each beast.

            // Below is the mechanic used to create a beast. 
             

            Console.WriteLine("\n\nYou think to yourself about how nervous ypu are thinking about entering the BLOCK BEAST BATTLE-THON,\n" +
                "but you think back to the first time you met your loyal beasts...");

            Console.WriteLine("\n... flashback into your childhood home ...");
            Console.WriteLine("\n\nYou have 3 shaking eggs Infront of you, They are the size of your body! They are huge!");
            Console.WriteLine("You grab the egg on the left. It is colored red with a flame pattern, It's a fire Beast!\n");

            //Random rngTalent = new Random();
            //Array talents = Enum.GetValues(typeof(Talents.Talent));
            //List<Talents.Talent> threeRandomTalents = new List<Talents.Talent>(3);
            //for (int i = 0; i < threeRandomTalents.Count(); i++)
            //{
            //    threeRandomTalents[i] = (Talents.Talent)talents.GetValue(rngTalent.Next(talents.Length));
            //}



            // Template beast below 
            Beast Flambug = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "Flambug", //Name 
                25, // Health 
                25, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's eyebrows look like red error lines!", // description 
                false // Random Talent
                );



            Console.WriteLine(Flambug.ToString());
            Console.ReadKey();
            Console.WriteLine("\n\n\nYou grab the egg in the middle. It is colored blue with a water pattern, It's a water Beast!\n");


            // Template beast below 
            Beast Auqagit = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "Auqagit", //Name 
                25, // Health 
                25, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's cat-like, And it keeps talking about a repository?", // description 
                false // Random Talent
                );

            Console.WriteLine(Auqagit.ToString());
            Console.ReadKey();
            Console.WriteLine("\n\n\nYou grab the final egg on the right. It is colored green with a leaf pattern, It's a grass Beast!\n");

            // Template beast below 
            Beast TermaSnake = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "TermaSnake", //Name 
                25, // Health 
                25, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's a has a black scaley body with little white spots that almost look like terminal text!", // description 
                false // Random Talent
                );

            Console.WriteLine(TermaSnake.ToString());

            #region Manual Talent 
            //Beast Flambug2 = new Beast( // Most numbers are placeholders numbers that will be overwritten
            //    "Flambug", //Name 
            //    25, // Health 
            //    25, // Max Health
            //    30, // crit hit chance
            //        //Talent 
            //    1,// damage 
            //    20, // dodge
            //    1, // miss 
            //    "It's eyebrows look like red error lines!", // description 
            //    true // Manual Talent
            //    );
            //Flambug2.HiddenTalent = Talents.Talent.strong;


            Console.WriteLine("\nPlease select your starting beast: (you can switch beasts after each fight) \n");
            bool retry = true;
            do
            {

                Console.WriteLine("1) Flambug\n" +
                                    "2) Aquagit\n" +
                                     "3) TermaSnake\n");

                char beastSelection = Console.ReadKey(true).KeyChar;
                switch (beastSelection)
                {
                    case '1':
                        Console.WriteLine("You Chose Flambug!");

                         
                        break;
                    case '2':
                        Console.WriteLine("You Chose Aquagit!");

                         
                        break;
                    case '3':
                        Console.WriteLine("You Chose TermaSnake!");

                         
                        break;
                    default:
                        Console.WriteLine("Please enter a number input.");
                        retry = true;
                        break;
                }

            } while (retry = false); // after a proper selection is made the player will move forward. 




            #endregion



            #endregion

            #region Menu Loop
            Beast TrainerBeast = Flambug;
            Beast EnemyBeast = Auqagit;


            //Gameplay Loop after everything is setup
            bool Quit = false;
            do
            {
                bool reload = false;
                do
                {
                    Console.WriteLine("\nTime to act " + "Aidan" + ":\n" +
                        "1) Attack\n" +
                        "2) BeastBOX\n" +
                        "3) Equipment\n" +
                        "4) Exit");

                    char action = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    switch (action)
                    {
                        case '1':
                            Console.WriteLine("Attack!");
                            //reload = Battle.BeastBattle(TrainerBeast, EnemyBeast);
                            break;
                        case '2':
                            Console.WriteLine("BeastBOX:\n");
                            Console.WriteLine("Player info: ");
                            //print player details to the screen
                            Console.WriteLine();
                            break;
                            reload = true;
                            break;
                        case '3':
                            Console.WriteLine("Equipment: ");
                            //print player details to the screen
                            Console.WriteLine();
                            break;

                        case '4':
                            Console.WriteLine("Exiting... ");
                            //print monster details to the screen
                            //Console.WriteLine(monster);
                            break;

                        case '5':
                            //quit the whole game. "reload = true;" gives us a new room and monster, "quit = true" quits the game, leaving both the inner AND outer loops.
                            Console.WriteLine("No one likes a quitter!");
                            //  quit = true;
                            break;

                        default:
                            Console.WriteLine("Do you think this is a game?? Quit playing around!");
                            break;
                    }//end switch


                } while (reload);


            } while (!Quit); // While quit is not true the user will stay in the game.
            #endregion




        }
    }
}
