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

        myJournal._entries.Add(entry);

        myJournal.SaveEntry();
    }

    public void SaveEntry()
    
    {
        string filename = "Journal.txt";
 
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Entry entry in _entries)

            {
                outputFile.WriteLine($"Today's date: {entry._date}. Today's prompt: {entry._promptText}. Today's entry: {entry._entryText}");
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
        Console.WriteLine("In truth this option is a redundancy only kept because I am required to do so. The entry is saved to the text file automatically.");
    }
}