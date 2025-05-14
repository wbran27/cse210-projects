namespace ConsoleApp1;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a list of items
        List<string> prompts = new List<string> { "Apple", "Banana", "Orange", "Grape", "Mango" };

        // Create a Random object
        Random random = new Random();

        // Select a random item
        string randomprompt = prompts[random.Next(prompts.Count)];

        // Display the random item
        Console.WriteLine($"Randomly selected item: {randomprompt}");
    }
}