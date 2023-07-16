public class Authentication {
    protected string _userName;
    protected string _password;
    int _numberSeries = 9999999; 
    public User _actualUser; 
    Animations Animation = new Animations();
    
    public Authentication()
    {

    }

    public void SignUp()
    {
        Console.WriteLine("=> Type a username: ");
        Console.WriteLine();
        Console.Write("     - ");
        _userName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("=> Type a password: ");
        Console.WriteLine();
        Console.Write("     - ");
        _password = Console.ReadLine();
        Console.WriteLine();

        string YNOrder = "";


        while (YNOrder != "y" && YNOrder != "n")
        {   
            Console.Clear();
            Console.WriteLine("ATM CASHIER || SIGN UP VERIFICATION");
            Console.WriteLine();
            Console.WriteLine("    > Your credentials are: ");
            Console.WriteLine();
            Console.WriteLine($"            Username: {_userName}");
            Console.WriteLine($"            Password: {_password}"); 
            Console.WriteLine();
            Console.WriteLine("- Type 'y' to verify your credentials.");
            Console.WriteLine("- Type 'n' to change your credentials.");
            Console.WriteLine();
            Console.Write("             - ");
            YNOrder = Console.ReadLine();
            Console.WriteLine();

            if (YNOrder == "y")
            {
                // Crear el usuario 
                User user = new User(_userName, _password);
                _numberSeries -=1; 
                user.CreateAccountNumber(_numberSeries);
                Database.UsersInformation.Add(user); 
                Database.SaveUsers(user);
                Console.Clear();
                Animation.NewUserCreated();

            }
            else if(YNOrder == "n")
            {
                // Go back to the beggining. 
                Console.Clear();
                Console.WriteLine("ATM CASHIER || SIGN UP VERIFICATION");
                Console.WriteLine();
                SignUp();
            }
            else
            {
                Console.Clear(); 
                Animation.InvalidOption();
            }
        }
    }

    public bool Login()
    {
        Console.WriteLine("=> Type your username: ");
        Console.WriteLine();
        Console.Write("     - ");
        _userName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("=> Type your password: ");
        Console.WriteLine();
        Console.Write("     - ");
        _password = Console.ReadLine();

        foreach (User user in Database.UsersInformation)
        {
            if (_userName == user.getUserName() && _password == user.getPassword())
            {
                _actualUser = user; 
                return true;
            }
            else
            {
               continue;
            }
        }
        return false;
    }

    public void LogOut()
    {   
        string YNOrder = "";
        Console.WriteLine("=> Would you like to finish the session? (y/n) "); 
        Console.Write("     -");
        YNOrder = Console.ReadLine();
        if (YNOrder == "y")
        {
            Console.Clear();
            Animation.SeeYouSoon();
        }
        else if(YNOrder!= ("n"))
        {
            // Stays.
            Login();
        }
        else
        {
            Console.Clear();
            Animation.InvalidOption();
        }
    }

    public bool ContinueOperation()
    {
        Console.WriteLine();
        Console.WriteLine("ATM CASHIER || NEW TRANSACTION");
        Console.WriteLine();
        Console.WriteLine("=> Would you like to process another transaction? (y/n)"); 
        Console.WriteLine();
        Console.Write("     - "); 
        string YNOrder = Console.ReadLine();
        Console.WriteLine();
        if (YNOrder == "y")
        {
            // Llamar UserActions
            return true;
        }
        else
        {
            Animation.SeeYouSoon();
            // Romper el programa. 
            return false;
        }
    }

}