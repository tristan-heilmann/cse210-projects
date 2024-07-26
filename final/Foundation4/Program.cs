using System;

class Program

{
    static void Main(string[] args)

    {
        // activity list
        List<Activity> activitiesList = new List<Activity>();

        // summoning and adding running to the list
        Running running = new Running(5, 30);
        activitiesList.Add(running);
        
        // summoning and adding cycling to the list
        Cycling cycling = new Cycling(7, 45);
        activitiesList.Add(cycling);

        // summoning and adding swimming to the list
        Swimming swimming = new Swimming(28, 60);
        activitiesList.Add(swimming);


        //display activity summaries
        foreach (Activity activity in activitiesList)
        {
            Console.WriteLine(activity.GetSummary());
            Console.WriteLine();
        }
    }
}