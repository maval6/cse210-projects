public class Journal
{
    private List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry.Date}~|~{entry.PromptText}~|~{entry.EntryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("~|~");
            Entry loadedEntry = new Entry
            {
                Date = parts[0],
                PromptText = parts[1],
                EntryText = parts[2]
            };
            _entries.Add(loadedEntry);
        }
    }
}