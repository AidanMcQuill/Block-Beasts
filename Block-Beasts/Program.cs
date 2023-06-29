using Block_Beasts;
using Block_Beasts_Library;
using System.Reflection;

// I've decided to make my own solution while I only reference the centriq code. This will help me better understand the concepts and learn on my own

namespace Block_Beasts
{
    internal class Program
    {
        static void Main(string[] args)
        //TODO create a random roll system to give the player their starting Beasts.
        //TODO make the player randomly go up against 3 random trainers, and then the Blocker Boss. 
        {
            /*TODO UNCOMMENT THIS WHEN READY, INTRO! */
            Console.WriteLine("Hey...");
            Thread.Sleep(500);
            Console.WriteLine("\nHey Wake Up!");
            Thread.Sleep(1000);
            Console.WriteLine("\nHEY!\n");
            Thread.Sleep(1500);
            Console.WriteLine("Oh, you're finally awake.\nYou were so nervous you passed out!");
            Console.WriteLine("Don't tell me you're too nervous to remember your name?\nTell me, What was it again?\n");
            string TrainerName = Console.ReadLine();
            Console.WriteLine("\nPerfect, and your age?\n");
            int TrainerAge = int.Parse(Console.ReadLine());
            Console.WriteLine($"\nAnd finally, what is your gender?\n");
            string TrainerGender = Console.ReadLine();
            Console.WriteLine("\nTake this BlockBOX, It's a device to tell you all about this world and it's lifeforms, including yourself.\n");

            // New Object to capture your info 
            Trainer player = new Trainer(TrainerName, TrainerAge, TrainerGender);

            Console.WriteLine("BlockBOX: Welcome User. Here is what I've recorded so far:\n\n" + player.ToString()); //TODO make the word "blockBOX" color coded 

           


            
           
















        }
    }
}