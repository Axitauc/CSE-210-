using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0; 
        while(userSelection != 4) {
            Console.Clear(); 
            Console.WriteLine("- Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine(" 1.Breathing Activity");
            Console.WriteLine(" 2.Reflecting Activity");
            Console.WriteLine(" 3.Listing Activity");
            Console.WriteLine(" 4.Quit"); 
            Console.WriteLine();
            Console.Write("     > "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userSelection == 1) {
                Console.Clear();
                Breath BreathActivity = new Breath();
                Console.Write("Welcome to "); 
                BreathActivity.GetActivityName(); 
                Console.WriteLine();
                BreathActivity.GetActivityDescription(); 
                Console.WriteLine();
                switch(BreathActivity.RequestTime()) {
                case "a":
                    Console.Clear();
                    Console.WriteLine("Get Ready...");
                    BreathActivity.Spinner();
                    Console.WriteLine();
                    BreathActivity.BreathingInstructions();
                    Console.WriteLine();
                    break;
                case "b": 
                    Console.Clear();
                    Console.WriteLine("Get Ready...");
                    BreathActivity.Spinner();
                    Console.WriteLine();
                    BreathActivity.BreathingInstructions(2);
                    Console.WriteLine();
                    break;
                case "c":
                    Console.Clear();
                    Console.WriteLine("Get Ready...");
                    BreathActivity.Spinner();
                    Console.WriteLine();
                    BreathActivity.BreathingInstructions(3);
                    Console.WriteLine();
                    break; 
                case "d": 
                    Console.Clear();
                    Console.WriteLine("Get Ready...");
                    BreathActivity.Spinner();
                    Console.WriteLine();
                    BreathActivity.BreathingInstructions(4);
                    Console.WriteLine();
                    break;
               }
        
            }
            else if (userSelection == 2) {
                Console.Clear();
                Reflect ReflectingActivity = new Reflect();
                Console.Write("Welcome to "); 
                ReflectingActivity.GetActivityName(); 
                Console.WriteLine();
                ReflectingActivity.GetActivityDescription();
                Console.WriteLine(); 
                ReflectingActivity.ReflectActivityTimer();
                Thread.Sleep(3000);
                
                
            }
            else if (userSelection == 3) {
                Console.Clear();
                List ListingActivity = new List();
                Console.Write("Welcome to "); 
                ListingActivity.GetActivityName(); 
                Console.WriteLine();
                ListingActivity.GetActivityDescription(); 
                Console.WriteLine();
                ListingActivity.ListActivityTimer();
                Thread.Sleep(3000);
                
            }
            else if (userSelection == 4) {
                Console.Clear();
                Console.WriteLine("- I will be waiting for you!");
                break;
            }
            else {
                Console.Clear();
                Console.WriteLine("- Please entry a valid option.");
                Console.WriteLine(" ");
            }

        } 
    }
}