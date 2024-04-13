using Class07Homework.CarApp.Domain.Database;
using Class07Homework.CarApp.Domain.Models;


//All cars from Europe
Console.WriteLine("European cars:");
Console.WriteLine("\n");
List<Car> europeanCars = CarsData.Cars.Where(c => c.Origin == "Europe").OrderBy(c => c.Model).ToList();
PrintHelper.PrintCars(europeanCars);
Console.WriteLine("\n");

//Cars > 6 cylinders + cars 4 cylinders & > 110HP
Console.WriteLine("==================================");
Console.WriteLine("Cars that go vroom:");
Console.WriteLine("\n");
List<Car> vroomCars = CarsData.Cars.Where(c => c.Cylinders > 6 || c.Cylinders == 4 && c.HorsePower > 110).OrderBy(c => c.Model).ToList();
PrintHelper.PrintCars(vroomCars);
Console.WriteLine("\n");

//counted cars based on origin
Console.WriteLine("==================================");
Console.WriteLine("Number of cars by origin:");
Console.WriteLine("\n");
List<string> origins = CarsData.Cars.Select(c => c.Origin).Distinct().ToList();
foreach (string s in origins)
{
    int carsOrigin = CarsData.Cars.Where(c => c.Origin == s).Count();
    Console.WriteLine($"Models from {s}: {carsOrigin}");
}
Console.WriteLine("\n");


//highest, lowest and average mpg for cars > 200 HP
Console.WriteLine("==================================");
List<Car> vroomiestCars = CarsData.Cars.Where(c => c.HorsePower > 200).ToList();
Car maxMPGModel = vroomiestCars.MaxBy(c => c.MilesPerGalon);
Console.WriteLine($"Max mpg for cars over 200HP: {maxMPGModel.Model} - {maxMPGModel.MilesPerGalon} MPG");
Car minMPGModel = vroomiestCars.MinBy(c => c.MilesPerGalon);
Console.WriteLine($"Min mpg for cars over 200HP: {minMPGModel.Model} - {minMPGModel.MilesPerGalon} MPG");
double averageMPG = vroomiestCars.Average(c => c.MilesPerGalon);
Console.WriteLine($"Average mpg for cars over 200HP: {averageMPG} MPG");



