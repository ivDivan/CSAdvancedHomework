

namespace Class04Homework.Task01.Domain.Models
{
    public class Circle : Shape
    {
        public double Radius { get; set; }
       
        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return Math.PI * Radius * 2;
        }
    }
}
