using System.Runtime.CompilerServices;
using System.Security.AccessControl;

public class GoalManager

{
    // now these are special
    // these allow navigation to the three goal types
    SimpleGoal simple = new SimpleGoal("","",0);
    EternalGoal eternal = new EternalGoal("","",0);
    ChecklistGoal checklist = new ChecklistGoal("","",0);
    
    
    // member variables
    private List<Goal> _goals;
    private int _score;

    // constructor
    public GoalManager()

    {
        _goals = new List<Goal>();
        _score = 0;
    }

    // main menu
    public void Start()

    {
        // some special member variables for the menu
        int input = 0;
        string file = "";

        do

        {

            // ya points
            Console.WriteLine();
            DisplayPlayerInfo();
            Console.WriteLine();
    
            // menu options
            Console.WriteLine("Menu options:");
    
            Console.WriteLine("    1. Create new goal");
            Console.WriteLine("    2. List Goals");
            Console.WriteLine("    3. Save goals");
            Console.WriteLine("    4. Load goals");
            Console.WriteLine("    5. Record Event");
            Console.WriteLine("    6. Quit");
    
            Console.WriteLine("Select a choice from the menu");
            Console.Write("> ");
            input = int.Parse(Console.ReadLine());
    
            if (input == 1)
    
            {
                CreateGoal();
            }
    
            else if (input == 2)
    
            {
                
            }
    
            else if (input == 3)
    
            {
                Console.Write("What is the file name? ");
                file = Console.ReadLine();
    
                SaveGoals(file);
            }
    
            else if (input == 4)
    
            {
                Console.Write("What is the file name? ");
                file = Console.ReadLine();
                
                LoadGoals(file);
            }
    
            else if (input == 5)
    
            {
                RecordEvent();
            }
    
            else
    
            {
                Console.WriteLine("Farewell, friend.");
                Environment.Exit(0);
            }

        } while (input == 6);
    }

    public void DisplayPlayerInfo()

    {
        Console.WriteLine($"You have {_score} points");
    }

    public void ListGoalNames()

    {
        
    }

    public void ListGoalDetails()

    {

    }

    public void CreateGoal()

    {
        int goal = 0;
        Console.WriteLine("The types of Goals are: ");

        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create?");
        Console.Write("> ");
        goal = int.Parse(Console.ReadLine());
        
        if (goal == 1)

        {
            simple.CreateSimpleGoal();
        }

        else if (goal == 2)

        {
            eternal.CreateEternalGoal();
        }

        else if (goal == 3)

        {
            checklist.CreateChecklistGoal();
        }
    }

    public void RecordEvent()

    {
        
    }

    public void SaveGoals(string file)

    {
        string filename = file;
 
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Goal goal in _goals)

            {
                outputFile.WriteLine($"");
            }
        }  
    }

    public void LoadGoals(string file)

    {
        string filename = file;

        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split("-");
        
            string _shortName = parts[0];
            string _description = parts[1];

            Console.WriteLine(line);
        }
    }
}