using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

public class Scripture

{
    private Reference _reference = new Reference("Proverbs", 3, 5, 6);
    private List<Word> _words = new List<Word>();
    private string _text = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";

    private string completeScripture;
    private bool _isCompletelyHidden = false;

    private void WriteLineSplitter()

    {
        string [] scripture = _text.Split(" ");

        foreach (string word in scripture)

        {
            Word newWord = new Word(word);

            _words.Add(newWord);
        }
    }
    
    public void HideRandomWords(int numberToHide)

    {
        numberToHide = 3;


    }

    public string GetDisplayText()

    {
        string rejoinedScripture = _text.Join(" ");

        completeScripture = $"{_reference} {rejoinedScripture}";
        return completeScripture;
    }

    public bool IsCompletelyHidden()

    {
        
        return _isCompletelyHidden;
    }
}