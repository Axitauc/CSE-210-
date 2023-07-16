public static class FileManager {
    public static string fileName = "goals.txt";


    public static void SaveGoals(){   
        using (StreamWriter saveDocument = new StreamWriter(fileName))
        {
            saveDocument.WriteLine(Generales.totalScore);
            // You can add text to the file with the WriteLine method
            foreach(GoalDescription i in Generales.ToDoGoals){ 
                saveDocument.WriteLine(i.FormatString());
            }
            
        }
    }

    public static void LoadFiles(){
        string[] lines = System.IO.File.ReadAllLines(FileManager.fileName);
        foreach (string line in lines)
        {   
            if(line == lines[0]){
                string ns = lines[0];
                Generales.totalScore = int.Parse(ns);
                Console.Write(Generales.totalScore);
                continue;
            }
            
            string[] parts = line.Split(",");
            string _goalType = parts[0];
            string _goalStatus = parts[1];
            string _goalName = parts[2];
            string _goalDescription = parts[3];
            int _goalPoints = int.Parse(parts[4]);
            if(_goalType == "Simple")
            {
                SimpleGoal SimpleGoal = new SimpleGoal(_goalName, _goalDescription, _goalPoints);
                Generales.ToDoGoals.Add(SimpleGoal);
            }
            else if(_goalType == "Eternal")
            {
                Eternal EternalGoal = new Eternal(_goalName, _goalDescription, _goalPoints);
                Generales.ToDoGoals.Add(EternalGoal);
            }
            else if(_goalType == "Checklist")
            {
                int _goalCounter = int.Parse(parts[5]);
                int _goalRepetition = int.Parse(parts[6]);
                CheckList checkList = new CheckList(_goalName, _goalDescription, _goalPoints, _goalCounter, _goalRepetition);
                Generales.ToDoGoals.Add(checkList);
                
            }
        }
    }

}