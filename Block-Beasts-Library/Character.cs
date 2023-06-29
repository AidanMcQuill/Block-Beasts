using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Beasts_Library
{
    internal class Character // This is my base class for every class / I won't have a monster/weapon class because the characters are the weapons/monsters
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



        // CTOR - Collect
        public Character (string name, int health, int maxHealth, string type, int criticalHitChance, string hiddenTalent)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Type = type;
            CriticalHitChance = criticalHitChance;
            HiddenTalent = hiddenTalent;

        }

        // METHODS - Monkeys

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
