
public class Activity{
   protected string _time;
   List<string> SpinnerItems = new List<string>(){
     "|", "/", "-", "\\"
   }; 

    List<int> CounterNums = new List<int>(){
     1,2,3,4,5,6,7,8,9,10
   }; 

    protected DateTime _startTime;
    protected DateTime _futureTime;
   

    public string RequestTime() {
        Console.WriteLine(); 
        Console.WriteLine("- How long, in seconds, would you like for your session? (Type a letter)");
        Console.Write("a. 10 seg \nb. 20 seg \nc. 30 seg \nd. 40 seg \n"); 
        Console.WriteLine(); 
        Console.Write("     > ");
        _time = Console.ReadLine(); 
        return _time;
    }

    public void DisplayFinalStatement(){

    }

    public void Spinner(){
        for (int i=0; i <= 2; i++){
           foreach(string carac in SpinnerItems){
            Console.Write(carac);
            Thread.Sleep(500);
            Console.Write("\b");
           }
        }
    }

    public virtual void ListActivityTimer(){
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int requested_Time = int.Parse(Console.ReadLine()); 
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(requested_Time);
       
    }

    public virtual void ReflectActivityTimer(){
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int requested_time = int.Parse(Console.ReadLine()); 
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(requested_time);
       
    }

    public void DisplayCounter(int progressiveCounter = 5){
       
           for (; progressiveCounter >= progressiveCounter && progressiveCounter >= 0;){
            Console.Write(progressiveCounter);
            Thread.Sleep(1000);
            Console.Write("\b");
            progressiveCounter -= 1;
           }
    }

    public virtual void GetActivityName(){


    }


    public virtual void GetActivityDescription(){

    }


}