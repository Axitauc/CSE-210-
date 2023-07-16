public class Transaction 
{
    double _transactionAmount; 
    DateTime _transactionDate; 
    public bool _inOut;
    double _balance; 
         
    public Transaction(double transactionAmount, string transactionDate, bool transactionType, double balance)
    {
        _transactionAmount = transactionAmount;
        _transactionDate = DateTime.Parse(transactionDate);
        _balance = balance;
        _inOut = transactionType; 
    }

    public Transaction(double transactionAmount, double balance, string transactionType)
    {
        _transactionAmount = transactionAmount;
        _balance = balance;
        _transactionDate = DateTime.Now;
        if (transactionType == "W")
        {   

            _inOut = false;
        }
        else 
        {
            _inOut = true;
        }
    }

    public double GetTransactionAmount()
    {
        return _transactionAmount;
    }

    public DateTime GetTransactionDate()
    {
        return _transactionDate;
    }

    public bool GetInOut()
    {
        return _inOut;
    }

    public double GetBalance()
    {
        return _balance;
    }

    public string strimTransaction(){
        return $"{_transactionAmount},{_transactionDate},{_inOut},{_balance}";
    }

}