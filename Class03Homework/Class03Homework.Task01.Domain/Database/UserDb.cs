

using Class03Homework.Task01.Domain.Models;
using System.Reflection.Metadata;

namespace Class03Homework.Task01.Domain.Database
{
    public static class UserDb
    {
        public static List<User> Users { get; set; }

        static UserDb()
        {
            Users = new List<User>()
            {
                new User(1, "Mile", 69),
                new User(2, "File", 73),
                new User(3, "Zile", 99),
                new User(4, "Bile", 101),
                new User(5, "Lile", 123)
            };
        }

        public static void SearchById(int id)
        {
            List<User> usersId = Users.Where(u => u.Id == id).ToList();
            if(usersId.Count == 0)
            {
                Console.WriteLine($"No user with id: {id} has been found ");
            }
            else { 
                Console.WriteLine($"Users with id: {id}");
                foreach (User user in usersId)
                {
                    Console.WriteLine($"Name: {user.Name}, Age: {user.Age}");
                }
            }
        }

        public static void SearchByName(string name)
        {
            List<User> usersId = Users.Where(u => u.Name == name).ToList();
            if (usersId.Count == 0)
            {
                Console.WriteLine($"No user with name: {name} has been found ");
            }
            else
            {
                Console.WriteLine($"Users with name: {name}");
                foreach (User user in usersId)
                {
                    Console.WriteLine($"Id: {user.Id}, Age: {user.Age}");
                }
            }
        }

        public static void SearchByAge(int age)
        {
            List<User> usersId = Users.Where(u => u.Age == age).ToList();
            if (usersId.Count == 0)
            {
                Console.WriteLine($"No user with age: {age} has been found ");
            }
            else
            {            
                Console.WriteLine($"Users with age: {age}");
                foreach (User user in usersId)
                {
                    Console.WriteLine($"Id: {user.Id}, Name: {user.Name}");
                }
            }
        }
    }
}
