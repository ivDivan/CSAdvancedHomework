using Class02Homework.Homework01.Domain.Models;

Programmer prog = new Programmer("Borislav", "Licanin", 50, 800);
prog.CalculateSalary();
prog.DisplayInfo();

Manager man = new Manager("Masinka", "Lukic", 40, 500);
man.CalculateSalary();
man.DisplayInfo();
