using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string HiddenTalent { get; set; }
        public decimal Damage { get; set; }
        public int Dodge { get; set; }
        public int Miss { get; set; }

        public string Description { get; set; }



        // CTOR - Collect
        public Beast(string name, int health, int maxHealth, int criticalHitChance, string hiddenTalent, decimal damage, int dodge, int miss, string description)
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
            HiddenTalent = hiddenTalent; // Rolled from the talent enums and each one has an effect 
            Damage = damage; // Base damage 3-5
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
                //$"\nElemental Type: {Type}" +
                $"\nHidden Talent: {HiddenTalent}" +
                $"\nMax Health: {MaxHealth}/25" +
                $"\nDamage Output: {Damage}" +
                $"\nCritical Hit Chance: {CriticalHitChance}" +
                $"\nDodge Chance: {Dodge}" +
                $"\nMiss Chance: {Miss}";
        }

    }
}
