public class CheckIn : Account
{
    Animations Animation = new Animations();

    public CheckIn()
    {

    }

    public override double[] Withdraw(Authentication Autenticador)
    {
        Console.Clear();
        Console.WriteLine("ATM CASHIER || WITHDRAW");
        Console.WriteLine(); 
        Console.WriteLine("=> What is the amount to be withdrawn?"); 
        Console.WriteLine(); 
        Console.Write("     - "); 
        double TransactionAmount = double.Parse(Console.ReadLine()); 

        if (Autenticador._actualUser.getBalance() < TransactionAmount)
        {
            Animation.InvalidOption();
            Withdraw(Autenticador);
        }
        
        double balance = Autenticador._actualUser.getBalance() - TransactionAmount;
        double[] transactionValues = {balance, TransactionAmount};   
        
        return transactionValues;
    }

    public override double[] Deposit(Authentication Autenticador)
    {
        Console.Clear();
        Console.WriteLine("ATM CASHIER || DEPOSIT");
        Console.WriteLine(); 
        Console.WriteLine("=> Type the amount to deposit:");
        Console.WriteLine(); 
        Console.Write("     - "); 
        double TransactionAmount = double.Parse(Console.ReadLine()); 
        Console.WriteLine();
        double balance = Autenticador._actualUser.getBalance() +  TransactionAmount;
        double[] transactionValues = {balance, TransactionAmount};
        return transactionValues; 
    }


}