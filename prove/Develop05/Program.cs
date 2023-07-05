using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        string goalType;

        int userSelection = 0;   
        

        while(userSelection != 6) {
            Console.Clear(); 
            Console.Write("Total Points: ");
            Console.WriteLine(Generales.totalScore);
            Console.WriteLine();
            Console.WriteLine("--> Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine("     1.Create New Goal");
            Console.WriteLine("     2.List Goals");
            Console.WriteLine("     3.Save Goals");
            Console.WriteLine("     4.Load Goals");
            Console.WriteLine("     5.Record Event");
            Console.WriteLine("     6.Quit"); 
            Console.WriteLine(" ");
            Console.Write("     - "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (userSelection == 1) {
                Console.Clear();
                Console.WriteLine("CREATING A NEW GOAL");
                Console.WriteLine();
                Console.WriteLine("-> The types of goals: ");
                Console.WriteLine("     1. Simple Goal");
                Console.WriteLine("     2. Eternal Goal");
                Console.WriteLine("     3. Checklist Goal");
                Console.WriteLine();
                Console.WriteLine("-> Which type of goal would you like to create? ");
                Console.Write("     - ");
                int goalSelection = int.Parse(Console.ReadLine());
                                                                                                                     
                switch(goalSelection) {
                case 1:
                    Console.Clear();
                    Console.WriteLine("SIMPLE GOAL");
                    goalType = "SimpleGoal"; 
                    Console.WriteLine();
                    Generales.CreateGoal(goalType);
                    break;
                case 2: 
                    Console.Clear();
                    Console.WriteLine("ETERNAL GOAL");
                    goalType = "EternalGoal";
                    Console.WriteLine();
                    Generales.CreateGoal(goalType);
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("CHECKLIST GOAL");
                    goalType = "ChecklistGoal";
                    Console.WriteLine();
                    Generales.CreateGoal(goalType);
                    break; 
               }
        
            }
            else if (userSelection == 2) {
                Console.Clear();
                Console.WriteLine("LIST OF GOALS"); 
                Console.WriteLine();
                foreach(GoalDescription i in Generales.ToDoGoals)
                {
                    i.DisplayGoals();
                    Console.WriteLine(i.DisplayGoals());
                }
                Thread.Sleep(3000);
                
            }
            else if (userSelection == 3) {
                FileManager.SaveGoals();
                Thread.Sleep(3000);
            }
                
            else if (userSelection == 4) {
                FileManager.LoadFiles();
                
                Thread.Sleep(3000);
            }
            else if (userSelection == 5) {
                Console.Clear();
                Console.WriteLine("RECORD A GOAL");
                Console.WriteLine();
                int counter = 0;
                foreach(GoalDescription i in Generales.ToDoGoals)
                {
                    counter += 1;
                    Console.Write("     ");
                    Console.WriteLine($"{counter}. {i.getName()}");
                }
                Console.WriteLine();
                Console.Write("-> ");
                Console.WriteLine("Which goal did you accomplish? ");
                Console.Write("     - ");
                int goalSelection = int.Parse(Console.ReadLine());
                GoalDescription goal = Generales.ToDoGoals[goalSelection-1];
                goal.goalRecorder(goal);
                Thread.Sleep(3000);
            }
            else if (userSelection == 6) {
                Console.Clear();
                Console.WriteLine("- See you soon!");
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