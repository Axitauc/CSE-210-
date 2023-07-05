
public abstract class GoalDescription{
   protected string  _goalName; 
    protected string  _goalDescription; 
   protected int _goalPoints; 
   protected bool _goalStatus = false;
   protected string _x = "";

   public abstract string DisplayGoals();

   public void changeGoalStatus(){
      _goalStatus = true; 
   }


   public abstract void goalRecorder(GoalDescription goal);

   public string getName(){
      return _goalName;
   }

   public int getPoints(){
      return _goalPoints; 
   }

   public abstract string FormatString();

   

   
}