public class User: Authentication {
    
    string _accountNumber; 
    int _balance = 0;
    int _numberSeries;
    
    public User(string userName, string password){
        _userName = userName; 
        _password = password; 
    }

    public string getUserName()
    {
        return _userName;
    }

    public string getPassword()
    {
        return _password;
    }

    public void PrintUserInformation()
    {
        Console.WriteLine($"{_userName}, {_password}, {_accountNumber}, {_balance}");
    }

    public string StrimUser()
    {
        return $"{_userName},{_password},{_accountNumber},{_balance}";
    }
    
    public void CreateAccountNumber(int _numberSeries)
    {
        char letter1 = char.ToUpper(_userName[0]);
        char letter2 = char.ToUpper(_userName[1]);
        _accountNumber = $"{letter1}{letter2}{_numberSeries}";
    }
    
    


}