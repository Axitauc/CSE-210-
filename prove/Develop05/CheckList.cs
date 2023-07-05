public class CheckList : GoalDescription {

    int _goalBonus; 
    int _goalRepetition;
    int _goalCounter; 

    public CheckList(string goalName, string goalDescription, int goalPoints, int goalBonus, int goalRepetition){
        _goalName = goalName; 
        _goalDescription = goalDescription; 
        _goalPoints = goalPoints;
        _goalBonus = goalBonus; 
        _goalRepetition = goalRepetition; 
    }

    public override void goalRecorder(GoalDescription goal){
        if (_goalCounter < _goalRepetition)
        {
            Generales.totalScore += goal.getPoints();
            _goalCounter += 1;
            if (_goalCounter == _goalRepetition)
            {   
                goal.changeGoalStatus();
            }
        } 
   }

    public override string DisplayGoals(){
        if (_goalStatus)
        {
            _x = "X";
        }   
        return $"[{_x}] - {_goalName}: {_goalDescription} - Currrently Completed: {_goalCounter}/{_goalRepetition}";
   }

    public override string FormatString(){
        {
            return $"Checklist, {_goalStatus}, {_goalName}, {_goalDescription}, {_goalPoints}, {_goalCounter}, {_goalRepetition}";
        }
    }


    
}