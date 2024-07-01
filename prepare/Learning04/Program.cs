using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!");

        Console.WriteLine();

        Assignment summary = new Assignment("Tristan Heilmann", "History");
        MathAssignment homeworkList = new MathAssignment("Tristan Heilmann", "History", "Section 7.3", "Problems 8-19");
        WritingAssignment writingInformation = new WritingAssignment("Tristan Heilmann", "History", "The Causes of World War II by Mary Waters");

        Console.WriteLine(summary.GetSummary());
        Console.WriteLine(homeworkList.GetHomeworkList());
        Console.WriteLine(writingInformation.GetWritingInformation());
    }
}