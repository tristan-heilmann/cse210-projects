using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;

public class Word

{
    private string _text;
    private bool _isHidden;

    public Word(string text)

    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()

    {
        _isHidden = true;
        _text = "_____";
    }

    public bool IsHidden()

    {
        return _isHidden;
    }

    public string GetText()

    {
        return _text;
    }
}