public class Entry {
    string _prompt; 
    string _userInput;
    string _emotion;
    string _date; 

    public Entry(string prompt, string userInput, string emotion, string datetime){
        _prompt = prompt;
        _userInput = userInput;
        _emotion = emotion;
        _date = datetime;
    }

    public string DisplayEntry(){
        return $"- {_prompt} \n - {_userInput} \n - {_emotion} \n - {_date} "; 
    }

    public string StrimEntry(){
        return $"{_prompt},{_userInput},{_emotion},{_date}"; 
    }

}