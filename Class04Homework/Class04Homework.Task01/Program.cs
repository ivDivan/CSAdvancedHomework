using Class04Homework.Task01.Domain.Db;
using Class04Homework.Task01.Domain.Models;

Circle circle1 = new Circle { Id = 1, Radius = 2 };
Circle circle2 = new Circle { Id = 2, Radius = 10 };

Rectangle rectangle1 = new Rectangle { Id = 3, SideA = 3, SideB = 4 };
Rectangle rectangle2 = new Rectangle { Id = 4, SideA = 10, SideB = 20 };

GenericDb<Circle> circleDb = new GenericDb<Circle>();
GenericDb<Rectangle> rectangleDb = new GenericDb<Rectangle>();

circleDb.AddShape(circle1);
circleDb.AddShape(circle2);
rectangleDb.AddShape(rectangle1);
rectangleDb.AddShape(rectangle2);

Console.WriteLine("Circle areas:");
circleDb.PrintAreas();
Console.WriteLine("Circle perimeters:");
circleDb.PrintPerimeters();
Console.WriteLine("");
Console.WriteLine("Rectangle areas:");
rectangleDb.PrintAreas();
Console.WriteLine("Rectangle perimeters:");
rectangleDb.PrintPerimeters();
Console.WriteLine("");
Console.WriteLine("Shape info:");
circle1.PrintInfo();
circle2.PrintInfo();
rectangle1.PrintInfo();
rectangle2.PrintInfo();
