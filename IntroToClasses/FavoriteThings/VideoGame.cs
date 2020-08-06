using System;

namespace IntroToClasses.FavoriteThings
{
    class VideoGame
    {
        public string Name { get; set; }
        public GameConsoles Platform { get; set; }

        public VideoGame(string name)
        {
            Name = name;
        }

        public void Play()
        {
            Console.WriteLine($"I'm turning on my {Platform} so I can play {Name} after I'm done coding.");
        }

        public void Buy(string newGame)
        {
            Console.WriteLine($"I just bought {newGame}, but I play too much {Name} and I can't stop.");
        }

    }
    enum GameConsoles
    {
        Switch,
        Xbox,
        Playstation
    }
}
