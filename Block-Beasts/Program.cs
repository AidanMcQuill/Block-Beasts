using Block_Beasts;
using Block_Beasts_Library;
using System;
using System.Reflection;
using System.Threading;

// I've decided to make my own solution while I only reference the centriq code. This will help me better understand the concepts and learn on my own
// TODO create 5 unit tests for my app.

namespace Block_Beasts
{
    internal class Program
    {

        static void Main(string[] args)
        //TODO make the player randomly go up against 3 random trainers 
        //TODO general coloring and stylization
        {
            #region Intro 
            Console.WriteLine("Hey...\n");

            Console.WriteLine("Hey wake up...\n");

            Console.WriteLine("HEY!\n");

            Console.WriteLine("Oh, you're finally awake.\nYou were so nervous you passed out!");
            // Key press to continue
            Console.WriteLine("You can't remember where you're at? can't you hear the cheers and see all the lights?");
            Console.WriteLine("You're a competitor in the BLOCK BEAST BATTLE-THON!\n");

            Console.WriteLine("Press space to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Don't tell me you're too nervous to remember your name?\nTell me, What was it again?\n");
            // laying out the fields to make the props for "player" object
            string TrainerName = Console.ReadLine();
            Console.WriteLine("\nPerfect, and your age?\n");
            int TrainerAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nAnd finally, what is your gender?\n");
            string TrainerGender = Console.ReadLine();
            Console.WriteLine("\n\nTake this BlockBOX, It's a device to tell you all about this world and it's lifeforms, including yourself.\n");

            // New Object to capture your info 
            Trainer player = new Trainer(TrainerName, TrainerAge, TrainerGender);

            Console.WriteLine("\nBlockBOX: Welcome User. Here is what I've recorded so far:\n\n" + player.ToString());

            Console.WriteLine("\nPress space to continue\n");
            Console.ReadKey();
            Console.Clear();

            #endregion 

            #region Beast Rolls 
            //// 6-29 : My first step will be to make my BlockBeast egg hatching mechanic.
            //// I will call to my class library for characteristics for each beast.

            //// Below is the mechanic used to create a beast.   

            //Console.WriteLine("You think to yourself about how nervous ypu are thinking about entering the BLOCK BEAST BATTLE-THON,\n" +
            //    "but you think back to the first time you met your loyal beasts...");

            //Console.WriteLine("\n... flashback into your childhood home ...");
            //Console.WriteLine("\n\nYou have 3 shaking eggs Infront of you, They are the size of your body! They are huge!");
            //Console.WriteLine("\nYou grab the egg on the left. It is colored red with a flame pattern, It's a fire Beast!\n");

            ////Random rngTalent = new Random();
            ////Array talents = Enum.GetValues(typeof(Talents.Talent));
            ////List<Talents.Talent> threeRandomTalents = new List<Talents.Talent>(3);
            ////for (int i = 0; i < threeRandomTalents.Count(); i++)
            ////{
            ////    threeRandomTalents[i] = (Talents.Talent)talents.GetValue(rngTalent.Next(talents.Length));
            ////}



            #region Manual Talent 
            //Beast Flambug2 = new Beast( // Most numbers are placeholders numbers that will be overwritten
            //    "Flambug", //Name 
            //    15, // Health 
            //    15, // Max Health
            //    30, // crit hit chance
            //        //Talent 
            //    1,// damage 
            //    20, // dodge
            //    1, // miss 
            //    "It's eyebrows look like red error lines!", // description 
            //    true // Manual Talent
            //    );
            //Flambug2.HiddenTalent = Talents.Talent.strong;

            #endregion

            #region Select Beasts

             //Console.WriteLine("\nPlease select your starting beast: (you can switch beasts after each fight) \n");
            //bool advance = true;
            //do
            //{

            //    Console.WriteLine("1) Flambug\n" +
            //                        "2) Aquagit\n" +
            //                         "3) TermaSnake\n");

            //    char beastSelection = Console.ReadKey(true).KeyChar;
            //    switch (beastSelection)
            //    {
            //        case '1':
            //            Console.WriteLine("You Chose Flambug!");

            //            advance = true;
            //            break;
            //        case '2':
            //            Console.WriteLine("You Chose Aquagit!");

            //            advance = true;
            //            break;
            //        case '3':
            //            Console.WriteLine("You Chose TermaSnake!");

            //            advance = true;
            //            break;
            //        default:
            //            Console.WriteLine("Please enter a number input.");
            //            advance = false;
            //            break;
            //    }

            //} while (advance = false); // after a proper selection is made the player will move forward. 

            #endregion




            #endregion

                //Generate a Trainer Beast
                Beast TrainerBeast = Beast.GetTrainerBeast();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("=====  The Beast entering the event with you is: " + TrainerBeast.Name + ".  =====");
                Console.WriteLine(TrainerBeast.ToString());
                Console.ResetColor();

            bool Quit = false;
            do
            {
                #region Beast and Arena generation


                //Generates Arena
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + GetArena());
                Console.ResetColor();
                //Generate a Enemy Beast  
                Beast EnemyBeast = Beast.GetEnemyBeast();
                Console.WriteLine("=====  In this arena you are fighting a " + EnemyBeast.Name + "! Stay Alert Trainer!  =====");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(EnemyBeast.ToString());
                Console.ResetColor();


                #endregion

                #region Menu Loop 
 

                TrainerBeast.score = 0;


                //Gameplay Loop after everything is setup
                bool reload = false;
                do
                {
                    Console.WriteLine("\nTime to act " + TrainerName + ":\n" +
                        "1) Attack\n" +
                        "2) BeastBOX\n" +
                        "3) Exit");

                    char action = Console.ReadKey(true).KeyChar;
                    Console.Clear();
                    switch (action)
                    {
                        case '1':
                            Console.WriteLine("Attack!");
                            reload = Battle.BeastBattle(TrainerBeast, EnemyBeast);
                            break;
                        #region BlockBOX 
                        // TODO add a score option
                        case '2':
                            Console.WriteLine("BeastBOX:\n");
                            Console.WriteLine("Player info:\n ");
                            //print player details to the screen
                            Console.WriteLine(player);
                            Console.WriteLine("\nHello " + TrainerName + "! please select an option:\n" +
                        "1) Beast Info\n" +
                        "2) Enemy info\n" +
                        "3) Exit back to battle\n");

                            char BoxChoice = Console.ReadKey(true).KeyChar;
                            switch (BoxChoice)
                            {
                                case '1':
                                    Console.WriteLine("Trainer Beast Info:\n");
                                    Console.WriteLine(TrainerBeast.ToString() + "\n");

                                    break;
                                case '2':
                                    Console.WriteLine("Enemy Beast Info:\n");
                                    Console.WriteLine(EnemyBeast.ToString() + "\n");
                                    break;
                                case '3':
                                    // Exits BlockBOX
                                    break;
                                default:

                                    break;
                            }
                            break;
                            reload = true;
                            break;
                        #endregion
                        case '3':
                            Console.WriteLine("Exiting App... ");
                            //print player details to the screen
                            Quit = true;
                            break;

                        default:
                            Console.WriteLine("Now isn't the time for that trainer, select an option! ");
                            break;
                    }//end switch

                    //HEALTH CHECK
                    if (TrainerBeast.Health <= 0)
                    {
                        Console.WriteLine("You have lost the battle...");
                        Quit = true;
                    }


                } while (!reload && !Quit);


            } while (!Quit); // While quit is not true the user will stay in the game.
            #endregion

            #region Run Results 

            Console.WriteLine("You won " + TrainerBeast.score +
              " battle" + (TrainerBeast.score == 1 ? "." : "s."));

            #endregion

        } // end of main program

        #region Methods 
        private static string GetArena()
        {
            string[] Arenas =
            {
                "This is a fire based arena! The scorched ground is surrounded by flames, you start to sweat.",
                "This is a water based arena! water jets are spraying a beautiful pattern above your head while your heart beats loudly.",
                "This is a grass based arena! surrounded by wildlife the sounds of the wild jungle hype you up for battle!",

            };

            Random rand = new Random();
            int index = rand.Next(Arenas.Length);
            string Arena = Arenas[index];
            return Arena;

            #endregion

        }
    }
}




