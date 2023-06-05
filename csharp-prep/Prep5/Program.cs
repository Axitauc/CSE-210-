using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();
        Console.WriteLine(" "); 

        string name = PromptName(); 
        Console.WriteLine(" "); 
        int number = PromptNumber(); 
        Console.WriteLine(" "); 
        int squaredNumber = SquaredNumber(number);
        DisplayResult(name, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptName()
    {
        Console.Write("> Please, enter your name: ");
        string nameValue = Console.ReadLine(); 

        return nameValue;
    }
    static int PromptNumber()
    {
        Console.Write("> Please, enter your favorite number: ");
        int numberValue = int.Parse(Console.ReadLine());

        return numberValue; 
    }

    static int SquaredNumber(int numberValue)
    {
        int squaredValue = numberValue * numberValue; 
        return squaredValue;
    }

    static void DisplayResult(string nameValue, int squareValue)
    {
        Console.WriteLine($"--> {nameValue}, the square of your number is {squareValue}.");
    }
}