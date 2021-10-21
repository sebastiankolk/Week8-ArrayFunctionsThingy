using System;

namespace FunctionsWithReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] food = { "burger", "chicken wings", "salad", "nuggets" };
            string[] drinks = { "coca-cola", "fanta", "sprite", "still water" };
            //DisplayRandomFromArray(food);
            //DisplayRandomFromArray(drinks);
            string randomsnack = PickRandomFromArray(food);
            string randomdrink = PickRandomFromArray(drinks);
            Console.WriteLine($"Computer has picked {randomsnack} and {randomdrink}");
        }
        private static string PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            string randomElement = someArray[randomIndex];
            return randomElement;
        }
        private static void DisplayRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomIndex]}");
        }
    }
}
