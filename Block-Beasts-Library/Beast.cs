using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static Block_Beasts_Library.Talents;

namespace Block_Beasts_Library
{
    public class Beast // This is my base class for every class / I won't have a monster/weapon class because the characters are the weapons/monsters
    {
        // FIELDS - Funny
        // I have no business rules 

        // PROPS - People
        public int _Health { get; set; }
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health
        {
            get { return _Health; }
            set { _Health = value <= MaxHealth ? value : MaxHealth; }
        }
        public string Type { get; set; }

        public Talent HiddenTalent { get; set; }
        public int Damage { get; set; }
        public int Dodge { get; set; }
        public int Miss { get; set; }

        public string Description { get; set; }

        public int Score { get; set; }



        // CTOR - Collect
        public Beast(string name, int health, int maxHealth, int criticalHitChance, int damage, int dodge, int miss, string description, bool manualTalent)
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
            MaxHealth = this.GetHealth();
            Health = MaxHealth;
            //Type = type; // no context yet
             
            Damage = this.CalcDamage(); // Base damage 3-5
            Dodge = this.CalcDodge(); // 20% base stat (Unless talented)
            Miss = this.CalcHit(); // 20% base stat (Unless talented)
            if (!manualTalent)
            {
                HiddenTalent = this.RandomTalent(); // Rolled from the talent enums and each one has an effect
            }
            Description = description;
        }



        // METHODS - Monkeys

        public override string ToString()
        {
            return
                $"\nName: {Name}" +
                $"\nDescription: {Description}" +
                //$"\nHidden Talent: {HiddenTalent} " +
                $"{(this.HiddenTalent == Talent.Weak ? "\nYour beast is Weak!\nYour frail beast won't do as much damage to others." : "")}" +
                $"{(this.HiddenTalent == Talent.strong ? "\nYour beast is Strong!\nIncreased damage buff, oh yeah! " : "")}" +
                $"{(this.HiddenTalent == Talent.boring ? "\nYour beast is Boring!\nYour beast has no change, boo hoo. " : "")}" +
                $"{(this.HiddenTalent == Talent.Clumsy ? "\nYour beast is Clumsy!\nIncreased Miss chance when in combat :( " : "")}" +
                $"{(this.HiddenTalent == Talent.Timid ? "\nYour beast is Timid!\nIt has a better chance at dodging. " : "")}" +
                $"{(this.HiddenTalent == Talent.Scared ? "\nYour beast is Scared!\nIt will dodge more likely but it's also more likely to miss. " : "")}" +
                $"{(this.HiddenTalent == Talent.Loyal ? "\nYour beast is Loyal!\nDue to the loyalty of your beast it has increased health!" : "")}" +
                $"{(this.HiddenTalent == Talent.PATHETIC ? "\nYour beast is pathetic!\nThis Beast has no battle spirit, major decrease to stats" : "")}" +
                $"{(this.HiddenTalent == Talent.GODLY ? "\nYour beast is Godly!\nThis is the dream beast, Major increase to stats!" : "")}" +
                $"{(this.HiddenTalent == Talent.Enraged ? "\nYour beast is Enraged!\nYour beast is blinded with rage, more damage, but more likely to miss" : "")}" +

                $"\nLife: {Health} / {MaxHealth}" +
                $"\nDamage Output: {Damage}" +
                $"\nDodge Chance: {Dodge}%" +
                $"\nHit Chance: {Miss}%";
        }

        public int GetHealth()
        {
            Random MaxHealth = new Random();
            int healthAmount = MaxHealth.Next(18, 22);
            return healthAmount;
        }
        public int CalcDamage()
        {


            Random Damage = new Random();
            int damageAmount = Damage.Next(3, 5);



            return damageAmount;

        } // Damage

        public int CalcDodge() // DODGE = BLOCK
        {
            int dodgeChance = 20;

            return dodgeChance;
        }
        public int CalcHit() // 20% MISS CHANCE
        {
            int HitChance = 80;

            return HitChance;
        }
        public Talent RandomTalent()
        {



            Talent selectedTalent = Talent.boring;

            Array talents = Enum.GetValues(typeof(Talent));
            //Random rngTalent = new Random();
            //Talent randomTalent = (Talent)talents.GetValue(rngTalent.Next(talents.Length));




            Random WeighedTalent = new Random();
            int TalentPercent = WeighedTalent.Next(1, 101);

            if (TalentPercent < 11)
            {
                selectedTalent = Talent.Timid;
                this.Dodge += 10;
            }
            else if (TalentPercent < 21)
            {
                selectedTalent = Talent.strong;
                this.Damage += 1;
            }
            else if (TalentPercent < 31)
            {
                selectedTalent = Talent.Clumsy;
                this.Miss -= 10;
            }
            else if (TalentPercent < 41)
            {
                selectedTalent = Talent.Weak;

                this.Damage -= 1;
            }
            else if (TalentPercent < 61)
            {
                selectedTalent = Talent.boring;

            }
            else if (TalentPercent < 71)
            {
                selectedTalent = Talent.Scared;
                this.Miss -= 10;
                this.Dodge += 10;

            }
            else if (TalentPercent < 81)
            {
                selectedTalent = Talent.Loyal;
                this.MaxHealth += 7;
                Health = MaxHealth;


            }
            else if (TalentPercent < 86)
            {
                selectedTalent = Talent.PATHETIC;
                this.Dodge -= 15;
                this.Miss -= 15;
                this.Damage -= 2;
                this.MaxHealth -= 5;
                Health = MaxHealth;


            }
            else if (TalentPercent < 91)
            {
                selectedTalent = Talent.GODLY;
                this.Dodge += 15;
                this.Miss -= 15;
                this.Damage += 3;
                this.MaxHealth += 8;
                Health = MaxHealth;


            }
            else if (TalentPercent < 101) // Numbers 41..100 ( C -> 40 % )
            {
                selectedTalent = Talent.Enraged;
                this.Miss -= 20;
                this.Damage += 4;



            }




            return selectedTalent;





        }// Talent


        //TODO use verbatims strings with art for the beasts 
        public static Beast GetEnemyBeast()
        {
            #region EnemyBeasts
            Beast Csharpo = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "Csharpo", //Name 
                1, // Health 
                1, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's a purple colored dragon that's very angry!", // description 
                false
                // Random Talent
                );

            Beast SQLizard = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "SQLizard", //Name 
                1, // Health 
                15, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's a large reptile with many eggs like a database", // description 
                false
                // Random Talent
                );

            Beast DeBugRio = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "DeBugRio", //Name 
                1, // Health 
                15, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's a fiery red dragonfly that is very annoying to the user", // description 
                false
                // Random Talent
                );
            #endregion
            List<Beast> Beasts = new()
            {
                DeBugRio,
                SQLizard,
                DeBugRio,
            };

            Random rand = new Random();
            int index = rand.Next(Beasts.Count);
            Beast EnemyBeast = Beasts[index];
            return EnemyBeast;

        }
        public static Beast GetTrainerBeast()
        {
            Beast Flambug = new Beast( // Most numbers are placeholders numbers that will be overwritten
               "Flambug", //Name 
               1, // Health 
               20, // Max Health
               30, // crit hit chance
                   //Talent 
               1,// damage 
               20, // dodge
               1, // miss 
               "It's eyebrows look like red error lines!", // description 
               false
               // Random Talent
               );



            //Console.WriteLine(Flambug.ToString());
            //Console.ReadKey();
            //Console.WriteLine("\n\n\nYou grab the egg in the middle. It is colored blue with a water pattern, It's a water Beast!\n");



            Beast Auqagit = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "Auqagit", //Name 
                1, // Health 
                20, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's cat-like, And it keeps talking about a repository?", // description 
                false
                // Random Talent
                );

            //Console.WriteLine(Auqagit.ToString());
            //Console.ReadKey();
            //Console.WriteLine("\n\n\nYou grab the final egg on the right. It is colored green with a leaf pattern, It's a grass Beast!\n");

            // Template beast below 
            Beast TermaSnake = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "TermaSnake", //Name 
                1, // Health 
                20, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It's a has a black scaley body with little white spots that almost look like terminal text!", // description 
                false
                // Random Talent
                );

            Beast BuildBoo = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "BuildBoo", //Name 
                1, // Health 
                20, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "It looks like an adorable teddy bear!, but it has so many build errors", // description 
                false
                // Random Talent
                );

            Beast Dynamico = new Beast( // Most numbers are placeholders numbers that will be overwritten
                "BuildBoo", //Name 
                1, // Health 
                20, // Max Health
                30, // crit hit chance
                    //Talent 
                1,// damage 
                20, // dodge
                1, // miss 
                "All it's moves link together in a library!", // description 
                false
                // Random Talent
                );




            List<Beast> Beasts = new()
            {
                 Flambug,
                Auqagit,
                TermaSnake,
                BuildBoo,
                Dynamico,
            };

            Random rand = new Random();
            int index = rand.Next(Beasts.Count);
            Beast TrainerBeast = Beasts[index];
            return TrainerBeast;

        }

        



    }
}
