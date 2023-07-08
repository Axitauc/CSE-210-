public class Authentication {
    protected string _userName;
    protected string _password;
    string _oldPassword; 
    string _newPassword1; 
    string  _newPassword2;
    int _numberSeries = 9999999; 
    
    public Authentication()
    {

    }

    public void SignUp()
    {
        Console.WriteLine("=> Type a username: ");
        Console.Write("     -");
        _userName = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("=> Type a password: ");
        Console.Write("     -");
        _password = Console.ReadLine();

        Console.WriteLine();

        string YNOrder = "";

        while (YNOrder != "Y" && YNOrder != "N")
        {
            Console.WriteLine("--> Your credentials are: ");
            Console.WriteLine(      $"Username: {_userName}");
            Console.WriteLine(      $"Password: {_password}"); 
            Console.WriteLine("     > Type 'Y' to verify your credentials.");
            Console.WriteLine("     > Type 'N' to change your credentials.");
            Console.Write("     -");
            YNOrder = Console.ReadLine();

            if (YNOrder == "Y")
            {
                // Crear el usuario 
                User user = new User(_userName, _password);
                _numberSeries -=1; 
                user.CreateAccountNumber(_numberSeries);
                Database.UsersInformation.Add(user); 
                Database.SaveUsers(user);
                Console.WriteLine("[ANIMATION] Congrats! You created a new account.");

            }
            else if(YNOrder == "N")
            {
                // Go back to the beggining. 
                SignUp();
            }
            else
            {
                // [ANIMATION] 
                Console.WriteLine("Invalid answer. Try again.");
            }
        }
    }

    public bool Login()
    {
        Console.WriteLine("=> Type your username: ");
        Console.Write("     -");
        _userName = Console.ReadLine();
        Console.WriteLine("=> Type your password: ");
        Console.Write("     -");
        _password = Console.ReadLine();

        foreach (User user in Database.UsersInformation)
        {
            if (_userName == user.getUserName() && _password == user.getPassword())
            {
                return true;
            }
            else
            {
               return false;
            }
        }

        return false;
    }

    public void LogOut()
    {   
        string YNOrder = "";
        Console.WriteLine("=> Would you like to finish the session? (Y/N) "); 
        Console.Write("     -");
        YNOrder = Console.ReadLine();
        if (YNOrder == "Y")
        {
            // [Animation] Comeback soon! 
        }
        else if(YNOrder!= ("N"))
        {
            // Stays.
        }
        else
        {
            // [Animation] Invalid answer. Try again.
        }
    }

    public void EditPassword()
    {
        string YNOrder = "";
        Console.WriteLine("=> Would you like to change your password? (Y/N) "); 
        Console.Write("     -");
        YNOrder = Console.ReadLine();
         if (YNOrder == "Y")
        {
            Console.Write("=> Type old password: "); 
            _oldPassword = Console.ReadLine(); 

            if (_oldPassword == _password)
            {
                Console.Write("=> Type new password: ");
                _newPassword1 = Console.ReadLine();
                Console.Write("=> Type again your new password: ");
                _newPassword2 = Console.ReadLine();
                if (_newPassword1 == _newPassword2)
                {
                    // [Animation] You changed your password! 
                }
                else
                {
                    // [Animation] Incorrect. Try again.

                }
            }
            else 
            {
                // [Animation] Incorrect. Try again.
            }

        }
        else if(YNOrder!= ("N"))
        {
            // Stays.
        }
        else
        {
            // [Animation] Invalid answer. Try again.
        }
        Console.WriteLine("[Animation] Thank you, come back soon!");
    }

}