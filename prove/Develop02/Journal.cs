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

        entry._promptText = "prompt";
        Console.WriteLine($"Your prompt is {prompt}");

        Console.Write("Type in your entry: ");
        entry._entryText = Console.ReadLine();

        myJournal._entries.Add(entry);

        myJournal.SaveEntry();
    }

    public void SaveEntry()

    {
        Console.WriteLine("Saving to file...");

        {
            foreach (Entry entry in _entries)

            {
                entry.DisplayEntryDetails();
            }
        }
    }

    public void DisplayAll()

    {
        
    }

    public void LoadFromFile()

    {

    }

public void SaveToFile()

    {
        
    }
}