using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

          

    
      Journal journal = new Journal();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display the journal");
            Console.WriteLine("3. Save the journal to a file");
            Console.WriteLine("4. Load the journal from a file");
            Console.WriteLine("5. Exit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("Please enter your response:");
                    string response = Console.ReadLine();
                    journal.AddEntry(response);
                    break;
                case "2":
                    journal.DisplayEntries();
                    break;
                case "3":
                    Console.WriteLine("Enter filename to save journal:");
                    string saveFilename = Console.ReadLine();
                    journal.SaveToFile(saveFilename);
                    break;
                case "4":
                    Console.WriteLine("Enter filename to load journal:");
                    string loadFilename = Console.ReadLine();
                    journal.LoadFromFile(loadFilename);
                    break;
                case "5":
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}

public class JournalEntry
{
    public string Date { get; private set; }
    public string Prompt { get; }
    public string Response { get; }

    public JournalEntry(string prompt, string response)
    {
        Date = DateTime.Now.ToString("yyyy-MM-dd");
        Prompt = prompt;
        Response = response;
    }

    public override string ToString()
    {
        return $"{Date} | Prompt: {Prompt} | Response: {Response}";
    }

    public string SaveFormat()
    {
        return $"{Date}~|~{Prompt}~|~{Response}";
    }
}

public class Journal
{
    private List entries;
    private static readonly Random random = new Random();
    private static readonly string[] prompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?"
    };

    public Journal()
    {
        entries = new List<int>(); 
    }

    public void AddEntry(string response)
    {
        string randomPrompt = prompts[random.Next(prompts.Length)];
        JournalEntry entry = new JournalEntry(randomPrompt, response);
        entries.Add(entry);  
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (var entry in entries)
            {
                writer.WriteLine(entry.SaveFormat()); 
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        entries.Clear();
        using (StreamReader reader = new StreamReader(filename))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(new[] { "~|~" }, StringSplitOptions.None);
                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];
                    JournalEntry entry = new JournalEntry(prompt, response)
                    {
                        
                    };
                    
                    entries.Add(entry);
                }
            }
        }
    }
}