using System.Security.Cryptography.X509Certificates;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    DateTime theCurrentTime = DateTime.Now;

    public void AddEntry()

    {
        string dateText = theCurrentTime.ToShortDateString();
        
        Entry entry = new Entry();
        PromptGenerator prompt = new PromptGenerator();
        Journal myJournal = new Journal();

        

        entry._date = dateText;
        entry._promptText = prompt.GetRandomPrompt();

        Console.WriteLine($"Your prompt is {entry._promptText}");

        Console.Write("Type in your entry: ");
        entry._entryText = Console.ReadLine();

        _entries.Add(entry);

        
    }

    public void DisplayAll()

    {
        
    }

    public void LoadFromFile(string file)

    {
        string filename = file;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
        
            string firstName = parts[0];
            string lastName = parts[1];
        }
    }

public void SaveToFile(string file)

    {
        string filename = file;
 
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)

            {
                outputFile.WriteLine($"Today's date: {entry._date}. Today's prompt: {entry._promptText} Today's entry: {entry._entryText}");
            }
        }  
    }
}