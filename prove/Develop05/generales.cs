public static class Generales{
    public static List<GoalDescription> ToDoGoals = new List<GoalDescription>();
    public static int totalScore = 0; 

   

    public static void CreateGoal(string goalType){

        // Preguntas Basicas 
        Console.WriteLine("-> What is the name of your goal? "); 
        Console.Write("     - ");
        string goalName = Console.ReadLine();
        Console.WriteLine("-> What is the description of it? ");
        Console.Write("     - ");
        string goalDescription = Console.ReadLine();
        Console.WriteLine("-> What is the amount of points associated with this goal? ");
        Console.Write("     - ");
        int goalPoints = int.Parse(Console.ReadLine());


        // Creamos la meta
        if (goalType == "SimpleGoal"){
            SimpleGoal SimpleGoal = new SimpleGoal(goalName, goalDescription, goalPoints);
            ToDoGoals.Add(SimpleGoal);
            
        }
        else if(goalType == "EternalGoal"){
            Eternal EternalGoal = new Eternal(goalName, goalDescription, goalPoints);
            ToDoGoals.Add(EternalGoal);
        }
        else if(goalType == "ChecklistGoal"){
            // Preguntas Adicionales para the CheckList Goal 
            Console.WriteLine("-> How many time does this goal need to be acdomplished for a bonus? "); 
            Console.Write("     - ");
            int goalRepetition = int.Parse(Console.ReadLine());
            Console.WriteLine("-> What is the bonus for accomplishing it that many times? "); 
            Console.Write("     - ");
            int goalBonus = int.Parse(Console.ReadLine());
            // Crea la meta para Cheklist Goal
            CheckList checkList = new CheckList(goalName, goalDescription, goalPoints, goalBonus, goalRepetition);  
            ToDoGoals.Add(checkList);
        }
        
    }

    

}