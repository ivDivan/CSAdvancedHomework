using Class03Homework.Task01.Domain.Database;


Dictionary<int, string> options = new Dictionary<int, string>()
{
    {1, "Id" },
    {2, "Name" },
    {3, "Age" }
};


int choiceInt;

while (true)
{
    Console.WriteLine("Search users by: ");
    foreach (var option in options)
    {
        Console.WriteLine($"{option.Key}) {option.Value}");
    }

    string input = Console.ReadLine();

    bool inputParsed = int.TryParse(input, out choiceInt);

    if (inputParsed)
    {
        if (choiceInt > 3 || choiceInt < 1)
        {
            Console.WriteLine("No dice!! Choices are 1 - 3!!!");
        }
        else
        {
            break;
        }
    }
    else
    {
        Console.WriteLine("Ai caramba!! You need to gimme a number...");
    }
}

switch (choiceInt)
{
    case 1:
        IdSearch();
        break;
    case 2:
        NameSearch();
        break;
    case 3:
        AgeSearch();
        break;
}

void IdSearch()
{
    
    while (true)
    {
        Console.WriteLine("Enter Id for user search: ");
        string idInput = Console.ReadLine();
        int id;
        bool idParsed = int.TryParse(idInput, out id);
        if (idParsed)
        {
            UserDb.SearchById(id);
            break;
        }
        else
        {
            Console.WriteLine("Ai caramba!! You need to gimme a number...");
        }
    }
}

void AgeSearch()
{    
    while (true)
    {
        Console.WriteLine("Enter age for user search: ");
        string ageInput = Console.ReadLine();
        int age;
        bool ageParsed = int.TryParse(ageInput, out age);
        if (ageParsed)
        {
            UserDb.SearchByAge(age);
            break;
        }
        else
        {
            Console.WriteLine("Ai caramba!! You need to gimme a number...");
        }
    }
}

void NameSearch()
{
    Console.WriteLine("Enter name for user search: ");
    string name = Console.ReadLine();
    UserDb.SearchByName(name);
}