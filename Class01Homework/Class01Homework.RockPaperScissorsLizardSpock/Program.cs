using System.Security.Cryptography;

int computerChoiceInt;
int userChoiceInt;
int userWins = 0;
int computerWins = 0;
int gamesPlayed = 0;

Dictionary<int, string> gameOptions = new Dictionary<int, string>()
{
    {1, "Rock"},
    {2, "Paper" },
    {3, "Scissors" },
    {4, "Lizard" },
    {5, "Spock" },
};

Dictionary<int, string> options = new Dictionary<int, string>()
{
    {1, "Play" },
    {2, "Show Results" },
    {3, "Exit" }
};

while (true)
{
    Console.WriteLine("Rock, Paper, Scissors, Lizard, Spock Game");
    Console.WriteLine("Chose your path, Sir Kight:");
    foreach (var option in options)
    {
        Console.WriteLine($"{option.Key}) {option.Value}");
    }

    int choiceInt;

    while (true)
    {
        string input = Console.ReadLine();
        
        bool inputParsed = int.TryParse(input, out choiceInt);

        if (inputParsed)
        {
            if (choiceInt > 3 || choiceInt < 1)
            {
                Console.WriteLine("Are you confused Sir Knight?? Choices are 1 - 3!!!");
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
            PlayGame();
            break;
        case 2:
            ShowResults();
            break;
        case 3:
            Console.WriteLine("None shall pass!!!");
            Environment.Exit(0);
            break;
    }
}
void GameResult(int user, int computer)
{
    if(user == computer)
    {
        Console.WriteLine("'Tis but a scratch. No winner!!!");
        gamesPlayed++;
    }
    else if((user == 1 && computer == 3) || 
        (user == 1 && computer == 4) || 
        (user == 2 && computer == 1) || 
        (user == 2 && computer == 5) ||
        (user == 3 && computer == 2) ||
        (user == 3 && computer == 4) ||
        (user == 4 && computer == 2) ||
        (user == 4 && computer == 5) ||
        (user == 5 && computer == 1) ||
        (user == 5 && computer == 3))
    {
        Console.WriteLine("U chose wisely, Sir Knight.");
        gamesPlayed++;
        userWins++;
    }
    else
    {
        Console.WriteLine("U chose poorly, Sir Knight.");
        gamesPlayed++;
        computerWins++;
    }
}

void GameMessage(int user, int computer)
{
    if ((user == 1 && computer == 2) || (user == 2 && computer == 1))
    {
        Console.WriteLine("Paper covers Rock.");
    }
    else if((user == 1 && computer == 3) || (user == 3 && computer == 1))
    {
        Console.WriteLine("As always, Rock smashes Scissors.");
    }
    else if ((user == 1 && computer == 4) || (user == 4 && computer == 1))
    {
        Console.WriteLine("Rock crushes Lizard.");
    }
    else if ((user == 1 && computer == 5) || (user == 5 && computer == 1))
    {
        Console.WriteLine("Spock vaporizes Rock.");
    }
    else if ((user == 2 && computer == 3) || (user == 3 && computer == 2))
    {
        Console.WriteLine("Scissors cut Paper.");
    }
    else if ((user == 2 && computer == 4) || (user == 4 && computer == 2))
    {
        Console.WriteLine("Lizard eats Paper.");
    }
    else if ((user == 2 && computer == 5) || (user == 5 && computer == 2))
    {
        Console.WriteLine("Paper disproves Spock.");
    }
    else if ((user == 3 && computer == 4) || (user == 4 && computer == 3))
    {
        Console.WriteLine("Scissors decapitates Lizard.");
    }
    else if ((user == 3 && computer == 5) || (user == 5 && computer == 3))
    {
        Console.WriteLine("Spock smashes Scissors.");
    }
    else if ((user == 4 && computer == 5) || (user == 5 && computer == 4))
    {
        Console.WriteLine("Lizard poisons Spock.");
    }
}



void PlayGame()
{
    Console.WriteLine("Enter choice, 1 - 5:");

    foreach (var gameOption in gameOptions)
    {
        Console.WriteLine($"{gameOption.Key}) {gameOption.Value}");
    }

    string userChoice;

    while (true)
    {
        string userInput = Console.ReadLine();
        bool userInputParsed = int.TryParse(userInput, out userChoiceInt);

        if (userInputParsed)
        {
            if (userChoiceInt > 5 || userChoiceInt < 1)
            {
                Console.WriteLine("U pullin my leg?? Choices are 1 - 6!!!");
            }
            else
            {
                userChoice = gameOptions[userChoiceInt];
                break;
            }
        }
        else
        {
            Console.WriteLine("Ai caramba!! You need to gimme a number...");
        }
    }

    Console.WriteLine($"Sir Knight choose {userChoice}");

    Random rand = new Random();
    computerChoiceInt = rand.Next(1, 6);
    string computerChoice = gameOptions[computerChoiceInt];
    Console.WriteLine($"The computer chooses {computerChoice}");

    GameResult(userChoiceInt, computerChoiceInt);
    GameMessage(userChoiceInt, computerChoiceInt);

    Console.WriteLine("Hit Enter to continue your quest...");
    Console.ReadLine();
}
void ShowResults()
{
    if (gamesPlayed == 0)
    {
        Console.WriteLine("No duels have been fought yet, good Sir Knight...");
        Console.WriteLine("Hit Enter to continue your quest...");
        Console.ReadLine();
    }
    else
    {
        Console.WriteLine($"Duels fought: {gamesPlayed}");
        Console.WriteLine($"Sir Knight wins: {userWins}");
        Console.WriteLine($"Computer wins: {computerWins}");
        double userPercentage = (double)userWins / gamesPlayed * 100;
        Console.WriteLine("Percent of Sir Knight's wins: {0:0.00}%", userPercentage);
        double computerPercentage = (double)computerWins / gamesPlayed * 100;
        Console.WriteLine("Percent of computer wins: {0:0.00}%", computerPercentage);
        Console.WriteLine("Hit Enter to continue your quest...");
        Console.ReadLine();
    }
}











