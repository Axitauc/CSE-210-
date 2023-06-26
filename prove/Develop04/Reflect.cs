public class Reflect:Activity{
    string _activityName = "Reflecting Activity"; 
    string _activityDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."; 

    List<string> Reflect_Activity_Prompt = new List<string>(){
        "       ----Think of a time when you stood up for someone else.----", 
        "       ----Think of a time when you did something really difficult.----", 
        "       ----Think of a time when you helped someone in need.----",
        "       ----Think of a time when you did something truly selfless.----"
    }; 

    public string PickRandomPrompt(){
        var random = new Random(); 
        int randomNumber = random.Next(0, Reflect_Activity_Prompt.Count);
        return Reflect_Activity_Prompt[randomNumber];
    }

    public void DisplayPrompt(){
        Console.WriteLine(PickRandomPrompt()); 
         
    }

    List<string> Reflect_Activity_Questions = new List<string>(){
        "       ----Why was this experience meaningful to you?----",
        "       ----Have you ever done anything like this before?----",
        "       ----How did you get started?----",
        "       ----How did you feel when it was complete?----",
        "       ----What made this time different than other times when you were not as successful?----",
        "       ----What is your favorite thing about this experience?----",
        "       ----What could you learn from this experience that applies to other situations?----",
        "       ----What did you learn about yourself through this experience?----",
        "       ----How can you keep this experience in mind in the future?----",
    }; 

   public override void ReflectActivityTimer(){
        Console.WriteLine();
        Console.Write("- How long, in seconds, would you like for your session? ");
        int requested_time = int.Parse(Console.ReadLine()); 
        Console.Clear();
        Console.WriteLine("Get Ready..."); 
        Spinner(); 
        Console.WriteLine(); 
        DisplayPrompt();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue."); 
        Console.ReadLine();
        Console.WriteLine(); 
        Console.Write("You may begin in: "); 
        DisplayCounter(5);
        Console.Clear(); 
        DateTime currentTime = DateTime.Now; 
        _startTime = DateTime.Now; 
        _futureTime = _startTime.AddSeconds(requested_time);
        

        while (currentTime < _futureTime)
        {
            for(int i = 0; i < Reflect_Activity_Questions.Count; i++)
            {
                currentTime = DateTime.Now; 
                Console.WriteLine(Reflect_Activity_Questions[i]);
                Spinner();
                if (currentTime >= _futureTime){
                    break;
                }
            }    
        }

        Console.WriteLine();
        Console.WriteLine("Well done!");
        Console.WriteLine();
        Console.WriteLine($"You have completed another {requested_time} of the Reflecting Actvity.");
        
    } 

    public override void GetActivityName(){
        Console.WriteLine( _activityName);
    }

    public override void GetActivityDescription(){
        Console.Write( _activityDescription);
    }

}