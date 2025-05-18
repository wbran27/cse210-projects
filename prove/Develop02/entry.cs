using System;
using System.IO;

public class JournalEntry
{
    private string _prompt;
    private string _response;
    private DateTime _date;

    public JournalEntry(string prompt, string response, DateTime date)
    {
        _prompt = prompt;
        _response = response;
        _date = date;
    }

    // new entries
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

    public string GetSaveFormat()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static JournalEntry FromSaveFormat(string line)
    {
        string[] parts = line.Split('|');
        DateTime date = DateTime.Parse(parts[0]);
        return new JournalEntry(parts[1], parts[2], date);
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


    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (JournalEntry entry in _entries)
            {
                writer.WriteLine(entry.GetSaveFormat());
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            _entries.Clear();
            string[] lines = File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                JournalEntry entry = JournalEntry.FromSaveFormat(line);
                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }


}