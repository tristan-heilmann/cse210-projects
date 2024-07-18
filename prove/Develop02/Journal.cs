using System.Security.Cryptography.X509Certificates;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)

    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()

    {
        foreach (Entry entry in _entries)

        {
            entry.DisplayEntryDetails();
        }
    }

    public void LoadFromFile(string file)

    {
        string filename = file;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
        
            string _date = parts[0];
            string _promptText = parts[1];
            string _entryText = parts[2];

            Console.WriteLine(line);
        }
    }

    public void SaveToFile(string file)

    {
        string filename = file;
 
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)

            {
                outputFile.WriteLine($"Date: {entry._date} - Prompt: {entry._promptText} - Entry: {entry._entryText}");
            }
        }  
    }
}