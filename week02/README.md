# Journal Program - CSE 210 W02 Assignment

A simple yet powerful C# console application that helps you maintain a journal by providing daily prompts and managing your entries.

## How to Run

1. **Navigate to the journal folder:**
   ```bash
   cd journal
   ```

2. **Run the program:**
   ```bash
   dotnet run
   ```

   Or compile and run:
   ```bash
   dotnet build
   dotnet bin/Debug/net6.0/journal.dll
   ```

## Features

- **Write New Entry** - Get a random prompt and write your response for the day
- **Display Journal** - View all your previous entries with dates
- **Save to File** - Save all entries to a text file for backup
- **Load from File** - Load previously saved journal entries
- **Interactive Menu** - Easy-to-use menu system

## File Format

When saving, entries are stored in a simple text format with entries separated by `~|~`:

```
1/15/2025~|~What was the best part of my day?~|~Spending time with friends at the park
1/16/2025~|~Who was the most interesting person I interacted with today?~|~My professor who shared amazing research insights
```

This format is easy to parse and unlikely to conflict with normal text.

## Class Structure

- **Entry.cs** - Represents a single journal entry (prompt, response, date)
- **Journal.cs** - Manages the collection of entries (add, display, save, load)
- **PromptGenerator.cs** - Provides random journaling prompts
- **Program.cs** - Main program with menu system

## Design Principles

This program demonstrates:
- **Abstraction** - Complex operations hidden behind simple method names
- **Encapsulation** - Private member variables with getter methods
- **Separation of Concerns** - Each class has a single, clear responsibility
- **Reusability** - Classes can be easily used in other programs

## Tips for Success

1. **Use meaningful filenames** when saving: `my_journal.txt` or `january_entries.txt`
2. **Don't overwrite files** - Save to different files to keep backups
3. **Type thoughtfully** - These entries are for you, be honest and reflective
4. **Regular practice** - Consistency is key to journaling success!

## Future Enhancements

Ideas to extend this program:
- Add word count statistics
- Filter entries by date range
- Search entries by keyword
- Export to CSV or JSON format
- Add mood tracking alongside entries
