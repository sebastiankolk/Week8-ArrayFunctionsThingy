using System;

namespace EpicFight
{
    class Program
    {
        static void Main(string[] args)
        {
            string hero, villan;
            hero = randomhero();
            Console.WriteLine($"Random hero: {hero}");
            villan = RandomVillan();
            Console.WriteLine($"Random hero: {villan}");
            string heroWeapon = PickWeapon();
            string villainWeapon = PickWeapon2();
            Console.WriteLine($"{hero} picked {heroWeapon}, {villan} picked {villainWeapon}");
        }
        private static int RandomIndex(string[] somearray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, somearray.Length);
            return randomIndex;
        }
        private static string randomhero()
        {
            string[] heros = { "Batman", "Superman", "Hulk", "Joosep the snusman", "Spiderman", "Robin hood", "Hitler" };
            return heros[RandomIndex(heros)];
        }
        private static string RandomVillan()
        {
            string[] villans = { "Bane", "Darth vader", "Child predator", "Loki",};
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, villans.Length);
            string RandomVillans = villans[randomIndex];
            return RandomVillans;
        }
        private static string PickWeapon()
        {
            string[] weapon = { "Spoon", "Shovel", "Hoe" };
            return weapon[RandomIndex(weapon)];
        }
        private static string PickWeapon2()
        {
            string[] weapon = { "Spoon", "Shovel", "Hoe" };
            return weapon[RandomIndex(weapon)];
        }
    }
}
