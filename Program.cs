
using Command_Practice;
using Command_Practice.Categories;
using System;

var questionBank = new QuestionBank();
var currentDirectory = Directory.GetCurrentDirectory();
var relativePath = Path.Combine("SaveFile", "file.txt");
var filePath = Path.Combine(currentDirectory, relativePath);
var questions = new List<Problem>();

Dictionary<string, string> categories = new Dictionary<string, string>
{
    {"0",  "Azure Command Line"},
    {"1",  "Azure PowerShell"},
    {"2",  "Docker"},
    {"3",  "Git"},
    {"4",  "Linux"},
    {"5",  "CSharp"},
    
};

LoadDataFromFile(filePath,questionBank);

Console.WriteLine("Welcome to the the Command Training Ground. Select your Training :\n\n");

printCategories();
var trainingSelectionInput = Console.ReadLine();

while(!categories.ContainsKey(trainingSelectionInput))
{
    Console.WriteLine("Your selection is not a required input. Please Try again.");
    trainingSelectionInput = Console.ReadLine();
}

var category = questionBank.categories[int.Parse(trainingSelectionInput)];
var categoryProblemCount = category.problems.Count;
int amount;

Console.WriteLine("Would you like to Load a Previous Save? Y or N ?\n");
var loadPreviousSave = Console.ReadLine().ToUpper();

while (loadPreviousSave != "Y" && loadPreviousSave != "N")
{
    Console.WriteLine("Your selection is not a required input. Please Try again. You only need to put Y for yes or N for no.\n");
    loadPreviousSave = Console.ReadLine().ToUpper();
}

if (loadPreviousSave == "Y")
{
    questions = category.savedProblems;
}
else
{
    Console.WriteLine("Thank You! Now How many problems do you want to work on?\n");


    while (true)
    {
        var amountInput = Console.ReadLine();

        if (!(int.TryParse(amountInput, out amount)))
        {
            Console.WriteLine("HEY! That is not a number. Please Try again.\n");
        }
        else if (int.TryParse(amountInput, out amount) && amount > categoryProblemCount)
        {
            Console.WriteLine($"The number you have selected is higher than the problem bank ({categoryProblemCount}) please select another number\n");
        }
        else if (int.TryParse(amountInput, out amount) && amount == 0)
        {
            Console.WriteLine($"Really?? zero? Try again.\n");
        }
        else if (int.TryParse(amountInput, out amount) && amount < 0)
        {
            Console.WriteLine($"Really?? NO NEGATIVE NUMBERS? Try again.\n");
        }
        else
        {
            break;
        }
    }

    Console.WriteLine("Thank You! Would you like to work on Random Problems? (Type either Y or N)\n");

    var randomProblemsSelction = Console.ReadLine().ToUpper();
    bool randomProblems;

    while (randomProblemsSelction != "Y" && randomProblemsSelction != "N")
    {
        Console.WriteLine("Your selection is not a required input. Please Try again. You only need to put Y for yes or N for no.\n");
        randomProblemsSelction = Console.ReadLine().ToUpper();
    }

    if (randomProblemsSelction != "Y") 
    { 
        randomProblems = true; 
    } 
    else 
    { 
        randomProblems = false; 
    }

    questions = problemSelection(category, amount, randomProblems);
}

while (true)
{
    foreach (var question in questions)
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(question.Question);
        var answer = Console.ReadLine();
        Console.WriteLine("Here is the Answer:\n");
        Console.WriteLine();
        Console.WriteLine(question.Answer);
        Console.WriteLine();
        Console.WriteLine("Would you like an explanation? Y/N");
        var explanation = Console.ReadLine().ToUpper();

        while (explanation != "Y" && explanation != "N")
        {
            Console.WriteLine("Your selection is not a required input. Please Try again. You only need to put Y for yes or N for no.\n");
            explanation = Console.ReadLine().ToUpper();
        }

        if (explanation == "Y")
        {
            Console.WriteLine();
            Console.WriteLine(question.Explanation);
            Console.WriteLine();
        }

        Console.WriteLine("Would you like to save this problem for later?");

        var saveFile = Console.ReadLine().ToUpper();

        while (saveFile != "Y" && saveFile != "N")
        {
            Console.WriteLine("Your selection is not a required input. Please Try again. You only need to put Y for yes or N for no.\n");
            saveFile = Console.ReadLine().ToUpper();
        }

        if (saveFile == "Y")
        {
            SaveDataToFile(filePath, category.type, question.problemNumber);
        }
    }

    Console.WriteLine("Would you like to end this training session or keep going?");
    var end = Console.ReadLine().ToUpper();

    while (end != "Y" && end != "N")
    {
        Console.WriteLine("Your selection is not a required input. Please Try again. You only need to put Y for yes or N for no.\n");
        end = Console.ReadLine().ToUpper();
    }

    if (end == "Y")
    {
        break;
    }
}


List<Problem> problemSelection(dynamic category, int amount , bool randomProblems = true)
{
    var problems = new List<Problem>();

    if (randomProblems)
    {
        var random = new Random();
        var problemCount = category.problems.Count;

        for (int i = 0; i < amount; i++)
        {
            problems.Add(category.problems[random.Next(0, problemCount)]);
        }
    }
    else
    {
        for (int i = 0; i < amount; i++)
        {
            problems.Add(category.problems[i]);
        }
    }

    
    return problems;
}

void printCategories()
{
    foreach (var category in categories)
    {
        Console.WriteLine($"{category.Key} : {category.Value}");
    }
}

void SaveDataToFile(string filePath, string myString, double myNumber)
{
    try
    {
        string dataToWrite = $"{myString},{myNumber}\n";

        File.AppendAllText(filePath, dataToWrite);
        Console.WriteLine("This problem has been saved!");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error saving data to file: {ex.Message}");
    }
}

void LoadDataFromFile(string filePath, QuestionBank questionbank)
{
    List<(string, double)> loadedData = new List<(string, double)>();

    try
    {
        if (File.Exists(filePath))
        {
            // Read all lines from the file
            string[] lines = File.ReadAllLines(filePath);

            foreach (string line in lines)
            {
                // Split each line into string and number
                string[] parts = line.Split(',');
                if (parts.Length == 2 && int.TryParse(parts[1], out int loadedNumber))
                {
                    foreach (var category in questionBank.categories) 
                    { 
                        if (category.type == parts[0])
                        {
                            category.savedProblems.Add(category.problems[loadedNumber -1]);
                        }
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File does not exist.");
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error loading data from file: {ex.Message}");
    }
}