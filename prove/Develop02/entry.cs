using System;

public class JournalEntry
{
    private string _prompt;
    private string _response;
    private DateTime _date;

    public JournalEntry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now;
    }

    public string GetPrompt()
    {
        return _prompt;
    }

    public string GetResponse()
    {
        return _response;
    }

    public DateTime GetDate()
    {
        return _date;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date.ToShortDateString()}");
        Console.WriteLine($"Prompt: {_prompt}");
        Console.WriteLine($"Response: {_response}");
        Console.WriteLine();
    }
}

public class Journal
{
    private List<JournalEntry> _entries;

    public Journal()
    {
        _entries = new List<JournalEntry>();
    }

    public void AddEntry(string prompt, string response)
    {
        JournalEntry entry = new JournalEntry(prompt, response);
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        Console.WriteLine("Journal Entries:\n");
        foreach (JournalEntry entry in _entries)
        {
            entry.Display();
        }
    }
}