using Class02Homework.Homework02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework02.Domain.Models
{
    public class Cat : Animal, ICat
    {
        public Cat(string name, string colour):
            base(name, colour)
        { 

        }

        public void Eat(string food)
        {
            if (string.IsNullOrEmpty(food))
            {
                throw new ArgumentNullException("Hey you!! Quit foolin around. Get me the food!!!");
            }
            Console.WriteLine($"Meet {Name}, the cat. {Name}'s fav food is {food}");
        }

        public override void PrintAnimal()
        {
            Console.WriteLine($"This is the {Colour} cat {Name}");
        }
    }
}
