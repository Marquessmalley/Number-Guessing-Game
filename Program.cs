using System;
using NumberGuess.Models;
using NumberGuess.Utility;

Computer computer = new();
Player player = new();

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100\n");

Console.WriteLine("Please select the difficulty level:");

// Creates array of difficulty levels
var difficulty_level = Enum.GetValues<DifficultyLevelEnum>();


// Loops over difficulty array
for (int i = 0; i < difficulty_level.Length; i++)
{

    Console.WriteLine($"{i}.{difficulty_level[i]}");
}


Console.Write("\nEnter your choice: ");
string? playerDifficultyLevel = Console.ReadLine();
var level = 0;

// Runs if invalid difficulty level
while (!int.TryParse(playerDifficultyLevel, out level) || level > 2)
{
    Console.Write("\nPlease enter a above number: ");
    playerDifficultyLevel = Console.ReadLine();
}

Console.WriteLine($"Great! You selected {Enum.GetValues<DifficultyLevelEnum>()[level]} level.\n");

// Sets difficulty level & player max attempts 
computer.DifficultyLevel = difficulty_level[level];
player.MaxAttempts = GameHelper.MaxAttempts(difficulty_level[level]);


Console.WriteLine("Let's start the game!");

// Generates computer number
int computerGenNum = computer.GenerateNumber();
Console.Write("\nEnter your guess: ");

int playerGuessNum = 0;
string? playerGuess = Console.ReadLine();

// Runs if invalid player guess
while (!int.TryParse(playerGuess, out playerGuessNum))
{
    Console.Write("\nPlease enter a valid number: ");
    playerGuess = Console.ReadLine();
}

// Validates player guess
bool validGuess = GameHelper.ValidatePlayerGuess(player, computerGenNum, playerGuessNum);


// Loops until player guesses correctly or runs out of attempts
while (!validGuess)
{
    Console.Write("\nEnter your guess: ");
    playerGuess = Console.ReadLine();
    if (int.TryParse(playerGuess, out playerGuessNum))
    {

        validGuess = GameHelper.ValidatePlayerGuess(player, computerGenNum, playerGuessNum);
    }
    else
    {
        Console.WriteLine("Please enter a valid number");
        continue;
    }
}

if (validGuess)
{
    GameHelper.CongratulatePlayer(player);
}













