using System;

namespace movie
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movie = { "Up", "How2TrainUrDragon", "James bond series", "Interstellar" };
            PickRandomFromArray(movie);
        }
        private static void PickRandomFromArray(string[] someArray)
        {
            Random rnd = new Random();
            int randomIndex = rnd.Next(0, someArray.Length);
            Console.WriteLine($"Computer has chosen {someArray[randomIndex]}");
        }
    }
}
