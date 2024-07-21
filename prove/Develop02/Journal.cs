using System;
using System.Collections.Generic;

public class Journal
{
    //new list for the entries. makes it easier to find
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
    //this will all be part of the program.cs when displaying the menu

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    //we need this to know what journals to load. Without the LoadEntries, it will not know which one to 
    //display. Tried and tested, this is nessesary. 

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void LoadEntries(List<Entry> loadedEntries)
    {
        entries = loadedEntries;
    }
}
