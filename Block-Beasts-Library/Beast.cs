using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Block_Beasts_Library.Talents;

namespace Block_Beasts_Library
{
    public class Beast // This is my base class for every class / I won't have a monster/weapon class because the characters are the weapons/monsters
    {
        // FIELDS - Funny
        // I have no business rules 

        // PROPS - People
        public string Name { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public string Type { get; set; }
        public int CriticalHitChance { get; set; }
        public Talent HiddenTalent { get; set; }
        public int Damage { get; set; }
        public int Dodge { get; set; }
        public int Miss { get; set; }

        public string Description { get; set; }



        // CTOR - Collect
        public Beast(string name, int health, int maxHealth, int criticalHitChance, int damage, int dodge, int miss, string description)
        {
            /*
            --------TALENTS----------
            Timid = 0, // dodge ability increased (12.5% to roll) dodge chances increase to 35% 
            strong = 1, // extra attack power (12.5% to roll) Damage range increases to 5-7
            boring = 2, // No buff/Nerf applied to mon (50% to roll) 
            Clumsy = 3, // A more likely chance to miss your attacks (12.5% to roll) Miss chances increase to 35%
            Weak = 4, // less attack power (12.5% to roll) Damage range decrease to 3-4
            */

            // Listing the attributes for each parameter 
            Name = name;
            MaxHealth = maxHealth; // out of 25
            health = maxHealth;
            //Type = type; // no context yet
            CriticalHitChance = criticalHitChance; // 10 - 20%
            Damage = this.CalcDamage(); // Base damage 3-5
            HiddenTalent = this.RandomTalent(); // Rolled from the talent enums and each one has an effect
            Dodge = dodge; // 10-20% base stat
            Miss = miss; // 10-20% base stat 
            Description = description;
        }

        // METHODS - Monkeys
        //TODO make a fancy display tostring to show the user what kind of beast they just got  
        public override string ToString()
        {
            return $"---Check out these stats!---" +
                $"\nName: {Name}" +
                $"\nDescription: {Description}" +
                $"\nHidden Talent: {HiddenTalent} " +
                $"{(this.HiddenTalent == Talent.Weak ? "\nYour beast is Weak!\nYour frail beast won't do as much damage to others." : "")}" +
                $"\nMax Health: {MaxHealth}/25" +
                $"\nDamage Output: {Damage}" +
                $"\nCritical Hit Chance: {CriticalHitChance}" +
                $"\nDodge Chance: {Dodge}" +
                $"\nMiss Chance: {Miss}";
        }

        public int CalcDamage()
        {
             

            Random Damage = new Random();
            int damageAmount = Damage.Next(3, 5);

            
            
            return damageAmount; 
            
        } // Damage
        public int CalcMiss()
        { 


            Random Damage = new Random();
            int damageAmount = Damage.Next(1, 11);


            return damageAmount;

        } // Miss
        public int CalcDodge()
        {


            Random Damage = new Random();
            int damageAmount = Damage.Next(1, 11);


            return damageAmount;

        } // Dodge
        public int CalcCritical()
        {


            Random Damage = new Random();
            int damageAmount = Damage.Next(1, 11);


            return damageAmount;

        } // Critical 
        public Talent RandomTalent()
        {

            

            Talent selectedTalent = Talent.boring;

            Array talents = Enum.GetValues(typeof(Talent));
            //Random rngTalent = new Random();
            //Talent randomTalent = (Talent)talents.GetValue(rngTalent.Next(talents.Length));




            Random WeighedTalent = new Random();
            int TalentPercent = WeighedTalent.Next(1, 101);

            if (TalentPercent < 16) // Numbers 1..10 ( A -> 15% )
            {
                selectedTalent = Talent.Timid;
                Console.WriteLine("Your beast is Timid!\nIt has a better chance at dodging.");
            }
            else if (TalentPercent < 31) // Numbers 11..40 ( B -> 15 % )
            {
                selectedTalent = Talent.strong;
                Console.WriteLine("Your beast is Strong!\nIncreased damage buff, oh yeah!");
            }
            else if (TalentPercent < 46) // Numbers 41..100 ( C -> 15 % ) 
            {
                selectedTalent = Talent.Clumsy;
                Console.WriteLine("Your beast is Clumsy!\nIncreased Miss chance when in combat :( ");
            }
            else if (TalentPercent < 61) // Numbers 41..100 ( C -> 15 % ) 
            {
                selectedTalent = Talent.Weak;

                this.Damage -= 1 ;
            }
            else if (TalentPercent < 101) // Numbers 41..100 ( C -> 40 % ) 
            {
                selectedTalent = Talent.boring;
                Console.WriteLine("Your beast is Boring!\nYour beast has no change, boo hoo");
            }

             


            return selectedTalent;





        }// Talent

       // public void StatChanges()
        



    }
}
