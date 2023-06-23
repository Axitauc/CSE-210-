
public class Breath:Activity{
    string _activityName = "Breathing Activity"; 
    string _activityDescription = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing."; 
    int _seconds = 1;
   
    // int _time;

    public Breath(){

    }

    public void BreathingInstructions(int iterations = 1){

        for (int i=0; i <= iterations; i++){
            Console.Clear();
            Console.Write("--> Breath In..."); 
            DisplayCounter(_seconds += 1);
            Console.WriteLine();
            Console.Write("<-- Breath Out..."); 
            DisplayCounter(_seconds);
            Console.WriteLine();
        }
    }

    public override void GetActivityName(){
        Console.WriteLine( _activityName);
    }

    public override void GetActivityDescription(){
        Console.Write( _activityDescription);
    }











}