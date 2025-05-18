
using System;
using System.Collections.Generic;

public class Prompts 
{
    private List<string> items; // Encapsulated list

    // Constructor to initialize the list
    public Prompts()
    {
        items = new List<string>
        {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?"
        };
    }

    // Method to get a random item
    public string GetRandomItem()
    {
        Random random = new Random();
        return items[random.Next(items.Count)];
    }

}
