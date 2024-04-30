

//=========Task 01=========

using Microsoft.VisualBasic;

string appPath = @"..\..\..\";
string folderPath = appPath + @"Files\";
string filePath = folderPath + @"names.txt";

if (!Directory.Exists(folderPath))
{
    Directory.CreateDirectory(folderPath);
    Console.WriteLine("Directory created!!!");
}

if (!File.Exists(filePath))
{
    File.Create(filePath).Close();
    Console.WriteLine("File created!!!");
}

//=========Task 02==========

void ReadFile()
{
    using (StreamReader sr = new StreamReader(filePath))
    {
        string firstRead = sr.ReadToEnd();
        if (string.IsNullOrEmpty(firstRead))
        {
            Console.WriteLine("Nuthin here, mate...");
        }
        else
        {
            Console.WriteLine(firstRead);
        }
    }
}


List<string> names = new List<string>();
string choiceInput;
List<string> UserInput()
{
    names.Clear();

    do
    {
        while (true)
        {
            Console.WriteLine("Gimme a name: ");
            string nameInput = Console.ReadLine();

            if (string.IsNullOrEmpty(nameInput))
            {
                Console.WriteLine("Oi, u need to input a name!!");
            }
            else
            {
                names.Add(nameInput);
                break;
            }
        }

        Console.WriteLine("Type \"N\" to finish, anything else to write another name.");
        choiceInput = Console.ReadLine().ToLower();
            
        
    }
    while (choiceInput != "n");

    return names;
}


void Write(List<string> text, string path)
{
    var distinctText = text.Distinct(StringComparer.OrdinalIgnoreCase).ToList();
    foreach (string s in distinctText)
    {
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine(s);
        }
    }
}

ReadFile();
UserInput();
Write(names, filePath);


//============Task 03=================

Console.WriteLine("Names in file: ");
ReadFile();

string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
List<string> charNames = new List<string>();

foreach (char letter in alphabet)
{
    string charFilePath = folderPath + @"namesStartingWith" + $@"{letter}";
    charNames.Clear();

    using(StreamReader sr = new StreamReader(filePath))
    {
        string line;
        while ((line = sr.ReadLine()) != null)
        {
            if (line.StartsWith(letter.ToString(), StringComparison.OrdinalIgnoreCase))
            {
                charNames.Add(line);
            }
        }
    }
    

    Write(charNames, charFilePath);

    if(File.Exists(charFilePath) && charNames.Count == 0)
    {
        File.Delete(charFilePath);
    }
}
