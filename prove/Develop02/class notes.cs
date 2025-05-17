namespace ConsoleApp1;
using System;
using System.Collections.Generic;

public class Prompts 
{
    private List<string> items; // Encapsulated list

    // Constructor to initialize the list
    public Prompts()
    {
        items = new List<string> { "Apple", "Banana", "Orange", "Grape", "Mango" };
    }

    // Method to get a random item
    public string GetRandomItem()
    {
        Random random = new Random();
        return items[random.Next(items.Count)];
    }

}