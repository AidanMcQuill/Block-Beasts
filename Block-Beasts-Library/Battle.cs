using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            int chance = TrainerBeast.CalcHit() - EnemyBeast.CalcDodge();
            int roll = new Random().Next(1, 101);
            bool hit = roll <= chance;



            Thread.Sleep(200);

            if (hit) // we rolled above the miss chance
            {
                //calculate the damage
                int damage = TrainerBeast.CalcDamage();

                //subtract and assign it to the defender's life
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
                return false;
            }
            else
            {


                TrainerBeast.score++;

                Console.WriteLine("\nYou shake hands with the opposing trainer and move on\n");
                Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine("Your beast has been restored to full health\n");
                //TODO fix the health restore so it doesn't go over the max 
                Console.ResetColor();
                Console.WriteLine($"\nYou won the battle against {EnemyBeast.Name}!\n");
                Console.ResetColor();
                TrainerBeast._Health += 15;
                // Prompt the trainer to roll a new Beast.
                return true;
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
