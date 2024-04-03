using Class02Homework.Homework02.Domain.Enums;
using Class02Homework.Homework02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework02.Domain.Models
{
    public class Dog : Animal, IDog
    {
        public Size Size { get; set; }

        public Dog(string name, string colour, Size size):
            base(name, colour)
        {
            Size = size;
        }
        public override void PrintAnimal()
        {
            Console.WriteLine($"This is {Name}. {Name} is a {Size} {Colour} dog.");
        }

        public void Bark()
        {
            if(Size == Size.Big)
            {
                Console.WriteLine("ROOOOOOAAAARRRR!!!");
            }
            else if(Size == Size.Medium)
            {
                Console.WriteLine("WOOOOOOFFFF!!!");
            }
            else
            {
                Console.WriteLine("woof");
            }
        }
    }
}
