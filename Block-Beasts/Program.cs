using Block_Beasts;
using Block_Beasts_Library;
using System;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using System.Threading.Channels;

// I've decided to make my own solution while I only reference the centriq code. This will help me better understand the concepts and learn on my own
// TODO create 5 unit tests for my app.

namespace Block_Beasts
{
    internal class Program
    {

        static void Main(string[] args)
        //TODO Add fonts if I have time 
        {
            #region Intro 
            // TITLE SCREEN 


            // ASKI art 

            Console.WriteLine(@"
______ _            _     ______                _       
| ___ \ |          | |    | ___ \              | |      
| |_/ / | ___   ___| | __ | |_/ / ___  __ _ ___| |_ ___ 
| ___ \ |/ _ \ / __| |/ / | ___ \/ _ \/ _` / __| __/ __|
| |_/ / | (_) | (__|   <  | |_/ /  __/ (_| \__ \ |_\__ \
\____/|_|\___/ \___|_|\_\ \____/ \___|\__,_|___/\__|___/
                                                        
                                                        
");

            Console.WriteLine("Test your luck and bond with your best beast!   Keep playing to see every beast combination!\n");

            //END OF TITLE SCREEN 
            Console.Write("Press space to continue\n");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("Hey...\n");

            Console.WriteLine("Hey wake up...\n");

            Console.WriteLine("HEY!\n");

            Console.WriteLine("Oh, you're finally awake... You were so nervous you passed out!\n");
            // Key press to continue
            Console.WriteLine("You can't remember where you're at? You're a competitor in the BLOCK BEAST BATTLE-THON!\n");
            Console.WriteLine("I'm the referee at this event, let me get you started.");
            //SPLITER 
            Console.WriteLine("\n====================================================================================== \n");
            Console.WriteLine("Don't tell me you're too nervous to remember your name?\nTell me, What was it again?\n");
            // laying out the fields to make the props for "player" object
            Console.Write("NAME: ");
            string TrainerName = Console.ReadLine();
            Console.WriteLine("\nWhat a cool name, Hope you're prepared " + TrainerName + "!\n");
            Console.Clear();
            Console.WriteLine("====================================================================================== \n");
            Console.Write("Take this ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("BeastBOX, ");
            Console.ResetColor();
            Console.Write("It's a device that records data all about this world and it's lifeforms, including yourself.\n");
            Trainer player = new Trainer(TrainerName, 0); // other fields added too much dialogue for no reason. 

            Console.WriteLine("\nBlockBOX: Welcome User. Here is what I've recorded so far:\n" + "NAME: " + player.Name);

            Console.Write("\nPress space to continue\n");
            Console.ReadKey();
            Console.Clear();

            #endregion
            // All below code is commented out. 
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
            #region Trainer Beast
            //Generate a Trainer Beast
            Console.WriteLine("Generating Your Beast: "); ShowSimplePercentage();
            Beast TrainerBeast = Beast.GetTrainerBeast();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n=====  The Beast entering the event with you is: " + TrainerBeast.Name + ".  =====");
            Console.WriteLine(TrainerBeast.ToString());
            Console.ResetColor();
            #endregion
            #region Beast and Arena generation
            bool Quit = false;
            int Score = -1;
            do
            {

               

                //Generates Arena
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("\n" + GetArena());
                Console.ResetColor();
                //Generate a Enemy Beast  
                Console.WriteLine("Generating Enemy Beast: "); ShowSimplePercentage();
                Beast EnemyBeast = Beast.GetEnemyBeast();
                Console.WriteLine("\n=====  In this arena you are fighting a " + EnemyBeast.Name + "! Stay Alert Trainer!  =====");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine(EnemyBeast.ToString());
                Console.ResetColor();


                #endregion

                #region Menu Loop 



                Score += 1;// This happens every time a new beast is generated (meaning you won a battle).


                //Gameplay Loop after everything is setup
                bool BlockBoot = false;
                bool reload = false;
                do
                {

                    Console.WriteLine("\nTime to act " + player.Name + ":\n" +
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
                        //TODONE (It works but not fully how I'd like it to) study and make a proper BlockBOX loop for this menu. 
                        case '2':
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write("BeastBOX:\n");
                            Console.ResetColor();
                            Console.WriteLine("Player info:\n ");
                            //print player details to the screen
                            Console.WriteLine("Name: " + player.Name);
                            Console.WriteLine("Current Beast: " + TrainerBeast.Name);
                            bool BoxLoop = true;
                            while (BoxLoop)
                            {

                                Console.WriteLine("\nHello " + player.Name + "! please select an option:\n" +
                            "1) Beast Info\n" +
                            "2) Enemy info\n" +
                            "3) Score\n" +
                            "4) Exit back to battle\n");

                                char BoxChoice = Console.ReadKey(true).KeyChar;
                                switch (BoxChoice)
                                {
                                    case '1':
                                        Console.WriteLine("Trainer Beast Info:\n");
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine(TrainerBeast.ToString() + "\n");
                                        Console.ResetColor();
                                        

                                        break;
                                    case '2':
                                        Console.WriteLine("Enemy Beast Info:\n");
                                        Console.ForegroundColor = ConsoleColor.DarkRed;
                                        Console.WriteLine(EnemyBeast.ToString() + "\n");
                                        Console.ResetColor();
                                       
                                        break;
                                    case '3':
                                        Console.WriteLine("\nBattles Won: " + Score); ;
                                       
                                        break;
                                    case '4':
                                        // Exits BlockBOX
                                        
                                        break;
                                    default:
                                        Console.WriteLine("Choose a proper input trainer!");
                                        
                                        break;

                                }
                                break;
                            }
                            break;



                        #endregion // end of block box 
                        case '3':
                            Console.WriteLine("Exiting App... ");
                            //print player details to the screen
                            Quit = true;
                            break;


                        default:
                            Console.WriteLine("Now isn't the time for that trainer, select an option! ");
                            break;

                    }//end switch

                    // Perma Text for menu 
                    




                    // WIN CONDITION

                    if (Score >= 5)
                    {
                        Console.WriteLine("You Are The Champion " + TrainerName + " Congratulations!!! \n" + @"                    
                    *****************
               ******               ******
           ****                           ****
        ****                                 ***
      ***                                       ***
     **           ***               ***           **
   **           *******           *******          ***
  **            *******           *******            **
 **             *******           *******             **
 **               ***               ***               **
**                                                     **
**       *                                     *       **
**      **                                     **      **
 **   ****                                     ****   **
 **      **                                   **      **
  **       ***                             ***       **
   ***       ****                       ****       ***
     **         ******             ******         **
      ***            ***************            ***
        ****                                 ****
           ****                           ****
               ******               ******
                    ***************** 
");
                        Quit = true;
                    }

                    //HEALTH CHECK

                    if (TrainerBeast.Health <= 0)
                    {
                        Console.WriteLine("\nYou have lost the battle...");
                        Console.WriteLine("reload and keep playing to see every beast combination!");
                        Quit = true;
                    }



                } while (!reload && !Quit);


            } while (!Quit); // While quit is not true the user will stay in the game.
            #endregion

            #region Run Results 

            Console.WriteLine("You won " + TrainerBeast.Score +
              " battle" + (TrainerBeast.Score == 1 ? "." : "s."));

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


        }
        static void ShowSimplePercentage()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.Write($"\rProgress: {i}%   ");
                Thread.Sleep(25);
            }

            Console.Write("\rDone!          ");
        }



    }
    #endregion



}





