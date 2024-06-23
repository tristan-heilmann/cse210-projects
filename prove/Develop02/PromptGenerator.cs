using System.Diagnostics.Contracts;

public class PromptGenerator

{
    public List<string> _prompts = new List<string>

    {
        "What is the weirdest thing I saw today?",
        "What was the best food I ate today?",
        "Was today a good day?",
        "Would I repeat this day if given the chance?",
        "Did I see the Lord's hand in my life tody, and if so, how?"
    };

    public string GetRandomPrompt()

    {
        Random rnd = new Random();

        int index = rnd.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }
}