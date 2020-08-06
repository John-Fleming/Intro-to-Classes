using IntroToClasses.FavoriteThings;
using System;

namespace IntroToClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi I'm John! These are some of my favorite things.");

            var Bentley = new Pet("Bentley", "Dog", "cheese");
            var Lewis = new Pet("Lewis", "Cat", "literally anything");

            Console.WriteLine($"{Bentley.Name} and {Lewis.Name} are my pets.");

            Bentley.Eat("kibbles");
            Lewis.Eat("literally anything");
            Bentley.Play("tennis ball");
            Lewis.Play("laser");

            var botw = new VideoGame("Breath of the Wild");
            var hk = new VideoGame("Hollow Knight");

            Console.WriteLine($"My favorite video games recently are {botw.Name} and {hk.Name}.");

            botw.Buy("Animal Crossing");
            hk.Play();
        }
    }
}
