using Block_Beasts;
using Block_Beasts_Library;

// I've decided to make my own solution while I only reference the centriq code. This will help me better understand the concepts and learn on my own

namespace Block_Beasts
{
    internal class Program
    {
        static void Main (string[] args)
        {

            Console.WriteLine("...");
            Thread.Sleep(500);
            Console.WriteLine("\n... ...\n");
            Thread.Sleep(1000);
            Console.WriteLine("\n... ... ...\n");
            Thread.Sleep(1500);
            Console.WriteLine("Oh, you're finally awake.\nYou were so nervous you passed out!");


        Trainer player = new Trainer("Name",18,"Male");

            Console.WriteLine(player);





        }
    }
}