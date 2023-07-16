public class User: Authentication {
    
    string _accountNumber; 
    double _balance = 0;

    public User(string userName, string password){
        _userName = userName; 
        _password = password; 
    }

    public User(string userName, string password, string accountNumber, double balance){
        _userName = userName; 
        _password = password; 
        _accountNumber = accountNumber;
        _balance = balance; 
    }

    public string getUserName()
    {
        return _userName;
    }

    public string getAccountNumber()
    {
        return _accountNumber;
    }

    public string getPassword()
    {
        return _password;
    }

    public double getBalance()
    {
        return _balance;
    }

    public string GetAccountNumber()
    {
        return _accountNumber;
    }

    public void SetAccountNumber(string accountNumber)
    {
        _accountNumber = accountNumber;
    }

    public void SetBalance (double balance)
    {
        _balance = balance; 
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