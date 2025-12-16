using System;
using NumberGuess.Models;
using NumberGuess.Utility;

Computer computer = new();
Player player = new();

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine("I'm thinking of a number between 1 and 100\n");






Console.WriteLine("Please select the difficulty level:");

var difficulty_level = Enum.GetValues<DifficultyLevelEnum>();

for (int i = 0; i < difficulty_level.Length; i++)
{

    Console.WriteLine($"{i}.{difficulty_level[i]}");
}

Console.Write("\nEnter your choice: ");
string? playerDifficultyLevel = Console.ReadLine();
var level = 0;

while (!int.TryParse(playerDifficultyLevel, out level) || level > 2)
{
    Console.Write("\nPlease enter a correct number: ");
    playerDifficultyLevel = Console.ReadLine();
}

Console.WriteLine($"Great! You selected {Enum.GetValues<DifficultyLevelEnum>()[level]} level.\n");

computer.DifficultyLevel = difficulty_level[level];
player.Attempts = GameHelper.MaxAttempts(difficulty_level[level]);


Console.WriteLine("Let's start the game!");
computer.GenerateNumber();














