using System;

namespace IntroToClasses.FavoriteThings
{
    class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string FavoriteFood { get; set; }
        private bool _isHungry = true;

        public Pet(string name, string type, string favoriteFood)
        {
            Name = name;
            Type = type;
            FavoriteFood = favoriteFood;
        }

        public void Eat(string typeOfFood)
        {
            if (_isHungry)
            {
                if (typeOfFood == FavoriteFood)
                {
                    Console.WriteLine($"You feed {Name} {typeOfFood}. {Name} is filled with determination.");
                    _isHungry = false;
                }
                else
                {
                    Console.WriteLine($"You attempt to feed {Name}. He gives you a disgusted look. This isn't {Name}'s favorite food.");
                }
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry");
            }
        }

        public void Play(string toy)
        {
            Console.WriteLine($"{Name} sprints around the room in excitement. It's time to play with the {toy}.");
        }
    }
}
