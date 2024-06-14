using System;

class Program

{
    static void Main(string[] args)

    {
        List<int> numbers = new List<int>();

        int user_number = -1;
        while (user_number != 0)
        
        {
            Console.Write("Enter a number. Type 0 when finished. ");

            string user_response = Console.ReadLine();
            user_number = int.Parse(user_response);

            if (user_number != 0)

            {
                numbers.Add(user_number);
            }
        }

         int sum = 0;

        foreach (int number in numbers)

        {
            sum += number;
        }

        Console.WriteLine($"The sum is: {sum}");

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is: {average}");
        
        int max = numbers[0];

        foreach (int number in numbers)

        {
            if (number > max)

            {
                max = number;
            }
        }

        Console.WriteLine($"The max is: {max}");

    }
}