public class Eternal : GoalDescription {

    public Eternal(string goalName, string goalDescription, int goalPoints){
        _goalName = goalName; 
        _goalDescription = goalDescription; 
        _goalPoints = goalPoints;
    }

    public override string DisplayGoals(){ 
        return $"[{_x}] - {_goalName}: {_goalDescription}";
   }

   public override void goalRecorder(GoalDescription goal){
        Generales.totalScore += goal.getPoints();   
   }
    public override string FormatString(){
        {
            return $"Eternal, {_goalStatus}, {_goalName}, {_goalDescription}, {_goalPoints}";
        }
    }

    
}