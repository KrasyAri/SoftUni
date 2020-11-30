using Raiding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RidingV2
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroesCount = int.Parse(Console.ReadLine());

            List<BaseHero> raidGroup = new List<BaseHero>();

            int heroesCreated = 0;

            while (heroesCreated < heroesCount)
            {
                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                if (CheckIfHeroTypeIsValid(heroType))
                {
                    heroesCreated++;
                    BaseHero hero;

                    switch (heroType)
                    {
                        case "Druid":
                            hero = new Druid(heroName);
                            raidGroup.Add(hero);
                            break;
                        case "Paladin":
                            hero = new Paladin(heroName);
                            raidGroup.Add(hero);
                            break;
                        case "Rogue":
                            hero = new Rogue(heroName);
                            raidGroup.Add(hero);
                            break;
                        case "Warrior":
                            hero = new Warrior(heroName);
                            raidGroup.Add(hero);
                            break;
                    }
                }

                else
                {
                    Console.WriteLine("Invalid hero!");
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            int raidGroupPower = FindRaidGroupPower(raidGroup);

            if (raidGroupPower >= bossPower)
            {
                Console.WriteLine("Victory!");
            }

            else
            {
                Console.WriteLine("Defeat...");
            }
        }

        public static bool CheckIfHeroTypeIsValid(string heroType)
        {
            string[] validHeroTypes = new string[] { "Druid", "Paladin", "Rogue", "Warrior" };

            if (validHeroTypes.Any(h => h == heroType))
            {
                return true;
            }

            return false;
        }

        public static int FindRaidGroupPower(List<BaseHero> raidGroup)
        {
            raidGroup.ForEach(m => Console.WriteLine(m.CastAbility()));

            return raidGroup.Sum(m => m.Power);
        }
    }
}