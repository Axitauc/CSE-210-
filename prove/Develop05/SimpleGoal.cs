
public class SimpleGoal : GoalDescription {

    public SimpleGoal(string goalName, string goalDescription, int goalPoints){
        _goalName = goalName; 
        _goalDescription = goalDescription; 
        _goalPoints = goalPoints;
    }

    public override string DisplayGoals(){
        if (_goalStatus)
        {
            _x = "X";
        }   
        return $"[{_x}] - {_goalName}: {_goalDescription}";
   }


   public override void goalRecorder(GoalDescription goal){
        goal.changeGoalStatus();
        Generales.totalScore += goal.getPoints();   
    }

    public override string FormatString(){
        {
            return $"Simple, {_goalStatus}, {_goalName}, {_goalDescription}, {_goalPoints}";
        }
    }

}