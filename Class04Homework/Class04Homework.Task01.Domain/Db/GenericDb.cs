using Class04Homework.Task01.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class04Homework.Task01.Domain.Db
{
    public class GenericDb<T> where T : Shape
    {
        private List<T> _shapes;

        public GenericDb()
        {
            _shapes = new List<T>();
        }

        public void AddShape(T shape)
        {
            _shapes.Add(shape);
        }

        public void PrintAreas()
        {
            foreach (var shape in _shapes)
            {
                Console.WriteLine($"Area of shape with Id {shape.Id}: {shape.GetArea()}");
            }
        }

        public void PrintPerimeters()
        {
            foreach (var shape in _shapes)
            {
                Console.WriteLine($"Perimeter of shape with Id {shape.Id}: {shape.GetPerimeter()}");
            }
        }
    }
}
