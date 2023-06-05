using System;

class Program
{
    static void Main(string[] args)
    {
        // int magicNumberGuess = 0; 

        // Before starting the do-while loop make sure to declare the loop variable. 
        string start; 

        do 
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 100);

            int guess = -1; 
            int counter = 0;

            while (guess != magicNumber)
            {
                // PART 1
                // Ask for the random number 
                // Console.WriteLine("What is the magic number?");
                // Assign a variable to the response. 
                // int magicNumber = int.Parse(Console.ReadLine()); 

                // PART 2
                Console.WriteLine(" > What is your guess?");
                guess = int.Parse(Console.ReadLine()); 
                Console.WriteLine(" ");

                if (guess > magicNumber) 
                {
                    Console.WriteLine("- Lower");
                    Console.WriteLine(" ");
                }
                else if (guess < magicNumber) 
                {
                    Console.WriteLine("- Higher");
                    Console.WriteLine(" ");
                }
                else
                {
                    Console.WriteLine("- You guessed it!");
                    Console.WriteLine(" ");
                }
                
                counter +=1;
            }

            Console.WriteLine($"- You guessed in {counter} times.");
            Console.WriteLine(" ");

            Console.WriteLine("> Do you want to play again?");
            start = Console.ReadLine();   
        } while (start == "yes" || start == "Yes" || start == "YES"); 
    }
}