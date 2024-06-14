using System;

class Program

{
    static void Main(string[] args)

    {
        display_welcome_message();

        string user_name = request_user_name();

        int user_number = request_user_number();

        int squared_number = square_number(user_number);

        display_result(user_name, squared_number);
    }

    static void display_welcome_message()

    {
        Console.WriteLine("Welcome to the program!");
    }

    static string request_user_name()

    {
        Console.Write("Please enter your name: ");

        string name = Console.ReadLine();

        return name;
    }

    static int request_user_number()

    {
        Console.Write("Please enter your favorite number: ");

        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int square_number(int number)

    {
        int square = number * number;

        return square;
    }

    static void display_result(string name, int square)

    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}