using System.Runtime.CompilerServices;
using System.Security;
using System.Security.AccessControl;

public class GoalManager

{
    
    private static string _newName;
    private static string _newDescription;
    private static int _newPoints;
    private static int _newTarget;
    private static int _newBonus;

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
                Console.WriteLine("The goals are:");

                foreach (Goal goal in _goals)

                {
                    Console.WriteLine(goal.GetDetailsString());
                }
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

        } while (input != 6);
    }

    // displaying ya points
    public void DisplayPlayerInfo()

    {
        Console.WriteLine($"You have {_score} points");
    }

    // making a goal
    public void CreateGoal()

    {
        int newGoal = 0;
        Console.WriteLine("The types of Goals are: ");

        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");

        Console.WriteLine("Which type of goal would you like to create?");
        Console.Write("> ");

        newGoal = int.Parse(Console.ReadLine());
        
        if (newGoal == 1)

        {
            Console.WriteLine("What is your goal named?");
            Console.Write("> ");
            _newName = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            Console.Write("> ");
            _newDescription = Console.ReadLine();

            Console.WriteLine("How many points would you like to associate with this goal?");
            Console.Write("> ");
            _newPoints = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(_newName, _newDescription, _newPoints);

            _goals.Add(simpleGoal);
        }
        

        else if (newGoal == 2)

        {
            Console.WriteLine("What is your goal named?");
            Console.Write("> ");
            _newName = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            Console.Write("> ");
            _newDescription = Console.ReadLine();

            Console.WriteLine("How many points would you like to associate with this goal?");
            Console.Write("> ");
            _newPoints = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal(_newName, _newDescription, _newPoints);

            _goals.Add(eternalGoal);
        }

        else if (newGoal == 3)

        {
            Console.WriteLine("What is your goal named?");
            Console.Write("> ");
            _newName = Console.ReadLine();

            Console.WriteLine("What is a short description of it?");
            Console.Write("> ");
            _newDescription = Console.ReadLine();

            Console.WriteLine("How many points would you like to associate with this goal?");
            Console.Write("> ");
            _newPoints = int.Parse(Console.ReadLine());

            Console.WriteLine("How many times does this goal have to be accomplished to get a bonus?");
            Console.Write("> ");
            _newTarget = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the bonus for completing it that many times?");
            Console.Write("> ");
            _newBonus = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(_newName, _newDescription, _newPoints, _newTarget, _newBonus);

            _goals.Add(checklistGoal);
        }
    }

    // marking stuff done
    public void RecordEvent()

    {
        int _completed = 0;
        Console.WriteLine("Which goal type was the one you completed?");

        Console.WriteLine("    1. Simple Goal");
        Console.WriteLine("    2. Eternal Goal");
        Console.WriteLine("    3. Checklist Goal");

        Console.Write("> ");
        _completed = int.Parse(Console.ReadLine());

        if (_completed == 1)

        {
            
        }

        if (_completed == 2)

        {
            
        }

        if (_completed == 3)

        {
            
        }
    }

    public void SaveGoals(string file)

    {
        string filename = file;
 
        using (StreamWriter outputFile = new StreamWriter(filename))

        {
            foreach (Goal goal in _goals)

            {
                outputFile.WriteLine(goal.GetStringRepresentation());
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
        
            _newName = parts[0];
            _newDescription = parts[1];
            _newPoints = int.Parse(parts[2]);
            _newTarget = int.Parse(parts[3]);
            _newBonus = int.Parse(parts[4]);

            Console.WriteLine(line);
        }
    }
}