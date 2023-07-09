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
        //TODO make BlockBOX look more appealing 
        {


            //string consoleText = "Hey...";
            //Console.WriteLine(consoleText);
            //Thread.Sleep(500);
            //Console.Clear();
            //consoleText += "Hey Wake Up";
            Console.WriteLine("Hey...");
            Thread.Sleep(1250);
            Console.WriteLine("Hey wake up...");
            Thread.Sleep(1250);
            Console.WriteLine("HEY!\n");
            Thread.Sleep(1250);
            Console.WriteLine("Oh, you're finally awake.\nYou were so nervous you passed out!");
            // Key press to continue
            Console.WriteLine("You can't remember where you're at? can't you hear the cheers and see all the lights?");
            Console.WriteLine( "You're a competitor in the BLOCK BEAST BATTLE-THON!\n");
            Thread.Sleep(6500);
            Console.WriteLine("Don't tell me you're too nervous to remember your name?\nTell me, What was it again?\n");
            // laying out the fields to make the props for "player" object
            string TrainerName = Console.ReadLine();
            Console.WriteLine("\nPerfect, and your age?\n");
            int TrainerAge = int.Parse(Console.ReadLine()); //TODO make a else if statement that makes the user input a number or try again if it isn't.
            Console.WriteLine($"\nAnd finally, what is your gender?\n");
            string TrainerGender = Console.ReadLine();
            Console.WriteLine("\nTake this BlockBOX, It's a device to tell you all about this world and it's lifeforms, including yourself.\n");

            // New Object to capture your info 
            Trainer player = new Trainer(TrainerName, TrainerAge, TrainerGender);

            Console.WriteLine("BlockBOX: Welcome User. Here is what I've recorded so far:\n\n" + player.ToString()); //TODO make the word "blockBOX" color coded 

           


            
           
















        }
    }
}