using System.Threading.Tasks.Dataflow;
using System.Collections.Generic;

public class Scripture

{
    private Reference _reference = new Reference("Proverbs", 3, 5, 6);
    private List<Word> _words = new List<Word>();
    private string _text = "Trust in the LORD with all your heart and lean not on your own understanding; in all your ways acknowledge him, and he will make your paths straight.";

    public void WriteLineSplitter()

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
        for (int i = 0; i < numberToHide; i++)

        {
            Random random = new Random();

            int index = random.Next(_words.Count);

            Word randomWord = _words[index];

            randomWord.Hide();
        }
    }

    public string GetDisplayText()

    {
        string displayText = _reference.GetReference() + "\n";

        foreach (Word newWord in _words)

        {
            displayText += newWord.GetText() + " ";
        }

        return displayText;
    }

    public bool IsCompletelyHidden()

    {
        bool _isCompletelyHidden = true;

        foreach (Word word in _words)

        {
            if (!word.IsHidden())

            {
                _isCompletelyHidden = false;
            }
        }

        return _isCompletelyHidden;
    }
}