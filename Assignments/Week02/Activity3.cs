using System; 

class Program {

    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicnumber = randomGenerator.Next(1, 50);
        int magicnumberguess = 0; 
        
        while (guess = true)
        {
            Console.WriteLine("What is the magic number?");
            magicnumber = Console.ReadLine(); 

            Console.WriteLine("What is your guess?");
            magicnumberguess = Console.ReadLine(); 

            if (magicnumberguess > magicnumber) 
            {
            Console.WriteLine("Higher");
            }

            if (magicnumberguess < magicnumber) 
            {
            Console.WriteLine("Lower");
            }

            else
            {
            Console.WriteLine("You guessed it!");
            guess = false;
            }
        }
    

    }

    
}