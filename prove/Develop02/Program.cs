using System;
using System.Collections.Generic;

namespace JournalApp
{
    public class Program
    {
        public static void Main(string[] args)

        //this will come first 

        {
            PromptManager promptManager = new PromptManager();
            Journal journal = new Journal();
            SaveFileManager saveFileManager = new SaveFileManager();
        //Need to have a menu
            while (true)
            {
                Console.WriteLine("Journal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file (best saved with .txt at end)");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
             //which one they choose
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        string prompt = promptManager.GetRandomPrompt();
                        Console.WriteLine(prompt);
                        string response = Console.ReadLine();
                        Entry entry = new Entry(prompt, response);
                        journal.AddEntry(entry);
                        break;
                    case "2":
                        journal.DisplayEntries();
                        break;
                    case "3":
                        Console.WriteLine("Enter the filename to save to:");
                        string saveFilename = Console.ReadLine();
                        saveFileManager.SaveJournal(saveFilename, journal.GetEntries());
                        break;
                    case "4":
                        Console.WriteLine("Enter the filename to load from:");
                        string loadFilename = Console.ReadLine();
                        List<Entry> loadedEntries = saveFileManager.LoadJournal(loadFilename);
                        journal.LoadEntries(loadedEntries);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}
