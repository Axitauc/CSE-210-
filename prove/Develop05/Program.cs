using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;     

        while(userSelection != 6) {
            Console.Clear(); 
            Console.WriteLine("> Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine(" 1.Create New Goal");
            Console.WriteLine(" 2.List Goals");
            Console.WriteLine(" 3.Save Goals");
            Console.WriteLine(" 4.Load Goals");
            Console.WriteLine(" 5.Record Event");
            Console.WriteLine(" 6.Quit"); 
            Console.WriteLine(" ");
            Console.Write("> "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (userSelection == 1) {
                Console.Clear();
                Console.WriteLine("CREATING A NEW GOAL");
                Console.WriteLine("The types of goals: ");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                
                Console.Write("Which type of goal would you like to create? ");
                int goalSelection = int.Parse(Console.ReadLine());
                                                                                                                     
                switch(goalSelection) {
                case 1:
                    Console.WriteLine("SIMPLE GOAL");
                    Console.Clear();
                    break;
                case 2: 
                    Console.WriteLine("ETERNAL GOAL");
                    Console.Clear();
                    break;
                case 3:
                    Console.WriteLine("CHECKLIST GOAL");
                    Console.Clear();
                    break; 
               }
        
            }
            else if (userSelection == 2) {
                
            }
            else if (userSelection == 3) {
            
                
            }
                
            else if (userSelection == 4) {
                
            }
            else if (userSelection == 5) {
                
            }
            else if (userSelection == 6) {
                
            }
           
            else {
               
            }

        } 
    }
}