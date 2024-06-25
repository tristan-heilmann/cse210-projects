public class Entry

{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void DisplayEntryDetails()

    {
        string filename = "Journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))

        outputFile.WriteLine($"Today's date: {_date}. Today's prompt: {_promptText} Today's entry: {_entryText}");
    }
}