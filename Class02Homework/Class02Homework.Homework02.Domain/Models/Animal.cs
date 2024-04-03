using Class02Homework.Homework02.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02Homework.Homework02.Domain.Models
{
    public abstract class Animal : IAnimal
    {
        public string Name { get; set; }
        public string Colour { get; set; }

        public Animal(string name, string colour)
        {
            if(string.IsNullOrEmpty(name) || string.IsNullOrEmpty(colour))
            {
                throw new ArgumentNullException("U gotta gimme a name and a color...");
            }
            Name = name; 
            Colour = colour;
        }
        public abstract void PrintAnimal();
       
    }
}
