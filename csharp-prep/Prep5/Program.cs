using System;

class Program

//Mostly copied from example but I understand it now
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string userName = DisplayName();
        int userNumber = FavoriteNumber();
        int numberSquared = NumberSquared(userNumber);

        DisplayResult(userName, numberSquared);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string DisplayName()
    {
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();
        return userName;
    }

    static int FavoriteNumber()
    {
        Console.WriteLine("Enter your favorite number:");
        int number = int.Parse(Console.ReadLine());
        return number;
    }

    static int NumberSquared(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}
