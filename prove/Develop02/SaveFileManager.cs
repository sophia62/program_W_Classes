using System;
using System.Collections.Generic;
using System.IO;

namespace JournalApp
{
    public class SaveFileManager
    {
        public void SaveJournal(string filename, List<Entry> entries)
        {
            using (StreamWriter writer = new StreamWriter(filename))
            {
                foreach (var entry in entries)
                {
                    writer.WriteLine($"{entry.Prompt}|{entry.Response}");
                }
            }
        }

        public List<Entry> LoadJournal(string filename)
        {
            List<Entry> entries = new List<Entry>();

            if (File.Exists(filename))
            {
                string[] lines = File.ReadAllLines(filename);

                foreach (var line in lines)
                {
                    string[] parts = line.Split('|');
                    string prompt = parts[0];
                    string response = parts[1];

                    entries.Add(new Entry(prompt, response));
                }
            }

            return entries;
        }
    }
}

