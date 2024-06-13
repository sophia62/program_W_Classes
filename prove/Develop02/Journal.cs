using System;
using System.Collections.Generic;

public class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (var entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public List<Entry> GetEntries()
    {
        return entries;
    }

    public void LoadEntries(List<Entry> loadedEntries)
    {
        entries = loadedEntries;
    }
}
