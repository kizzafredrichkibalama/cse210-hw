using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    // Member variable - stores a list of all entries
    private List<Entry> _entries;

    // Constructor - initializes an empty journal
    public Journal()
    {
        _entries = new List<Entry>();
    }

    // AddEntry - adds a new entry to the journal
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    // DisplayAll - shows all entries in the journal to the console
    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("\nNo entries in your journal yet.\n");
            return;
        }

        Console.WriteLine("\n========== YOUR JOURNAL ==========\n");
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.ToString());
            Console.WriteLine("----------------------------------");
        }
    }

    // SaveToFile - saves all entries to a file
    public void SaveToFile(string filename)
    {
        try
        {
            using (StreamWriter outputFile = new StreamWriter(filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine(entry.SaveToString());
                }
            }
            Console.WriteLine($"\nYour journal has been saved to {filename}\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError saving file: {e.Message}\n");
        }
    }

    // LoadFromFile - loads entries from a file and replaces current journal
    public void LoadFromFile(string filename)
    {
        try
        {
            // First, clear any existing entries
            _entries.Clear();

            // Read all lines from the file
            string[] lines = System.IO.File.ReadAllLines(filename);

            // Parse each line and create an Entry object
            foreach (string line in lines)
            {
                // Split the line using our separator ~|~
                string[] parts = line.Split("~|~");

                if (parts.Length == 3)
                {
                    string date = parts[0];
                    string prompt = parts[1];
                    string response = parts[2];

                    Entry loadedEntry = new Entry(prompt, response, date);
                    _entries.Add(loadedEntry);
                }
            }

            Console.WriteLine($"\nLoaded {_entries.Count} entries from {filename}\n");
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"\nFile '{filename}' not found.\n");
        }
        catch (Exception e)
        {
            Console.WriteLine($"\nError loading file: {e.Message}\n");
        }
    }

    // GetEntryCount - returns how many entries are in the journal
    public int GetEntryCount()
    {
        return _entries.Count;
    }
}
