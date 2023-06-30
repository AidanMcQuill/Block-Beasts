using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Block_Beasts_Library
{
    internal class Beast // This is my base class for every class / I won't have a monster/weapon class because the characters are the weapons/monsters
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



        // CTOR - Collect
        public Beast (string name, int health, int maxHealth, string type, int criticalHitChance, string hiddenTalent, decimal damage, int dodge, int miss)
        {
            Name = name;
            Health = health;
            MaxHealth = maxHealth;
            Type = type;
            CriticalHitChance = criticalHitChance;
            HiddenTalent = hiddenTalent;
            Damage = damage;
            Dodge = dodge;
            Miss = miss;
        }

        // METHODS - Monkeys

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
