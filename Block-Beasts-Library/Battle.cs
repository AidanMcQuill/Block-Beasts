using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Block_Beasts_Library.Talents;

namespace Block_Beasts_Library
{
    public class Battle
    {

        public static void BattleAction(Beast TrainerBeast, Beast EnemyBeast)
        {
            // Registering if the hit lands  
            int chance = TrainerBeast.Miss - EnemyBeast.Dodge;
            int roll = new Random().Next(1, 101);
            bool hit = roll <= chance;



            Thread.Sleep(200);

            if (hit) // we rolled above the miss chance
            {
                //calculating damage
                int damage = TrainerBeast.Damage;


                EnemyBeast.Health -= damage;

                //output the result
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{TrainerBeast.Name} hit {EnemyBeast.Name} for {damage} damage!");
                //reset the color
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"{TrainerBeast.Name} ");
                Console.ResetColor();
                Console.WriteLine("missed!");

            }



        }//end of main battle mechanic()

        public static bool BeastBattle(Beast TrainerBeast, Beast EnemyBeast)
        {
            BattleAction(TrainerBeast, EnemyBeast);
            if (EnemyBeast.Health > 0)
            {
                BattleAction(EnemyBeast, TrainerBeast);

                Console.WriteLine("====================================================================================== \n");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(TrainerBeast.Name);
                Console.ResetColor();
                Console.Write(" HP: " + TrainerBeast.Health+"\n");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(EnemyBeast.Name);
                Console.ResetColor();
                Console.Write(" HP: " + EnemyBeast.Health + "\n");

                return false;

            }
            else
            {


                Console.WriteLine($"\nYou won the battle against {EnemyBeast.Name}!\n");
                Console.WriteLine("\nYou shake hands with the opposing trainer and move on\n");
                Console.WriteLine("\n====================================================================================== \n");
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Your beast has been restored to full health\n");

                //TODO-ISH fix the health restore so it doesn't go over the max 
                // ^ This was so simple, I didn't get the loop but I did it for the loop. I spent 3 hours on this. Relief Relief Relief.

                TrainerBeast.MaxHealth += 0;
                TrainerBeast.Health = TrainerBeast.MaxHealth;
                Console.WriteLine($"\nLife: " + TrainerBeast.Health + "/" + TrainerBeast.MaxHealth);
                Console.ResetColor();


                Console.WriteLine("\n====================================================================================== \n");



                //Switch statement


                Console.WriteLine("Would you like to acquire a new beast?\n");
                Console.WriteLine("1) YES | 2) NO\n");
                char action = Console.ReadKey(true).KeyChar;
                Console.Clear();
                bool reload = false;




                //TODO make the default case loop back so that the user doesn't miss the chance to make a proper choice. 
                switch (action)
                {
                    case '1':
                        Console.Clear();
                        Beast NewBeast = Beast.GetTrainerBeast();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        TrainerBeast = NewBeast;
                        Console.WriteLine("Generating Beast: "); ShowSimplePercentage();
                        Console.WriteLine("=====  The new beast joining your side is: " + TrainerBeast.Name + ".  =====");
                        Console.WriteLine(TrainerBeast.ToString());
                        Console.ResetColor();
                        break;


                    default:
                        Console.Clear();
                        Console.WriteLine("Your beast acknowledges your loyalty!");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("stats increased!");
                        Console.ResetColor();
                        Console.WriteLine("\n====================================================================================== \n");
                        TrainerBeast.MaxHealth += 2;
                        TrainerBeast.Health = TrainerBeast.MaxHealth;
                        TrainerBeast.Damage += 1;
                        TrainerBeast.Miss += 5;
                        TrainerBeast.Dodge += 5;

                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                        Console.WriteLine(TrainerBeast.ToString());
                        TrainerBeast.Score += 1;
                        Console.ResetColor();
                        break;




                }


            }
            return true;

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
    }

}














//keep track of average blows it takes to take down a beast
//    static int DodgeChance(Beast TrainerBeast) // These are the numbers for a beast with normal odds on dodge 
//    {
//        Random DodgeRoll = new Random();
//        int Dodge = DodgeRoll.Next(1, 101);

//        if (Dodge < TrainerBeast.Dodge + 1)
//        {
//            // Add the dodge


//            Console.WriteLine("You dodged the attack!");
//        }
//        else if (Dodge < 101)
//        {
//            //Attacks lands, nothing is displayed to the user as the attack lands as normal. 

//        }
//        return Dodge;


//    }

//    static int MissChance(Beast TrainerBeast) // These are the numbers for a beast with normal odds on dodge 
//    {
//        Random MissRoll = new Random();
//        int Miss = MissRoll.Next(1, 101);

//        if (Miss < TrainerBeast.Miss + 1)
//        {
//            // Add the Miss


//            Console.WriteLine("You miss you're attack!");
//        }
//        else if (Miss < 101)
//        {
//            //Attacks lands, nothing is displayed to the user as the attack lands as normal. 

//        }
//        return Miss;


//    }


//}
//}
