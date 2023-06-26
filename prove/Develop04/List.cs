public class List:Activity {

    string _activityName = "Listing Activity"; 
    string _activityDescription = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."; 

    List<string> List_Activity_Prompt = new List<string>(){
        "       ----Who are people that you appreciate?----",
        "       ----What are personal strengths of yours?----", 
        "       ----Who are people that you have helped this week?----", 
        "       ----When have you felt the Holy Ghost this month?----", 
        "       ----Who are some of your personal heroes?----"
    }; 

    public string PickRandomPrompt(){
        var random = new Random(); 
        int randomNumber = random.Next(0, List_Activity_Prompt.Count);
        return List_Activity_Prompt[randomNumber];
    }

    public void DisplayPrompt(){
        Console.WriteLine(PickRandomPrompt()); 
         
    }

    public override void ListActivityTimer(){
        Console.WriteLine("- How long, in seconds, would you like for your session? ");
        int requested_Time = int.Parse(Console.ReadLine()); 
        Console.Clear();
        Console.WriteLine("Get Ready..."); 
        Spinner(); 
        Console.WriteLine("- List as many responses as you can to the following prompt: ");
        DisplayPrompt();
        Console.WriteLine();
        Console.Write("- You may begin in: "); 
        DisplayCounter(3);
        DateTime currentTime = DateTime.Now; 
        _startTime = DateTime.Now; 
        _futureTime = _startTime.AddSeconds(requested_Time);
        Console.WriteLine();
        int count = 0; 
        while (currentTime < _futureTime)
        {
            Console.Write("     > "); 
            string userInput = Console.ReadLine();
            currentTime = DateTime.Now; 
            count++; 
        }
        
        Console.WriteLine();
        Console.WriteLine($"You listed {count} items! Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {requested_Time} of the Listing Actvity."); 

    }

    public override void GetActivityName(){
        Console.WriteLine( _activityName);
    }

    public override void GetActivityDescription(){
        Console.Write( _activityDescription);
    }


}