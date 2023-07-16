using System;

class Program
{
    static void Main(string[] args)
    {   
        int userSelection = 0;   
        Authentication Autenticador = new Authentication();
        Database.Load();
        Animations Animation = new Animations(); 
        if(userSelection != 3) 
        {
            Console.Clear(); 
            Console.WriteLine("ATM CASHIER || MAIN MENU");
            Console.WriteLine();
            Console.WriteLine("=> Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine("     1.Create Account");
            Console.WriteLine("     2.Log In");
            Console.WriteLine("     3.Quit"); 
            Console.WriteLine(" ");
            Console.Write("     - "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userSelection == 1) 
            {
                Console.Clear();
                Console.WriteLine("ATM CASHIER || SIGN UP");
                Console.WriteLine();
                // Call Sign Up function
                Autenticador.SignUp();
                Program.Main(args);

            }
            else if (userSelection == 2) 
            {
                Console.Clear();
                Console.WriteLine("ATM CASHIER || LOG IN");
                Console.WriteLine();
                // Call Log In function.
                bool loggedIn = Autenticador.Login();
                int TimesTried = 0;

                while (loggedIn == false && TimesTried < 3){
                    Console.Clear();
                    Console.WriteLine("ATM CASHIER || LOG IN");
                    Console.WriteLine();
                    loggedIn = Autenticador.Login();
                    TimesTried++;
                }

                // Si el usuario y la contrasena encajan. 
                if(loggedIn == true)
                {   
                    Console.Clear();
                    Animation.Welcome();
                    while(UserActions(Animation, Autenticador)){
                        UserActions(Animation, Autenticador);
                    }
                    
                }
                else 
                {
                    Console.Clear();
                    Animation.IncorrectCredentials();
                    Program.Main(args);
                }

            }
            else if (userSelection == 3) 
            {
                Console.Clear();
                Animation.SeeYouSoon();
                
            }
            else 
            {
                Console.Clear();
                Animation.InvalidOption();

            }
        } 
    }

    public static bool UserActions(Animations Animation, Authentication Autenticador)
    {
        bool repeatUserActions = false;
        int userAction = 0;
        CheckIn checkInTransferences = new CheckIn();
        Summary summary = new Summary();
        // summary.LoadSummary(Autenticador._actualUser.getAccountNumber());
        Console.Clear();
                    // Console.WriteLine(Autenticador._actualUser.getBalance());
                    Console.WriteLine("ATM CASHIER || NEW TRANSACTION");
                    Console.WriteLine();
                    Console.WriteLine("=> Please, select the action:");
                    Console.WriteLine(" ");
                    Console.WriteLine("     1.Deposit");
                    Console.WriteLine("     2.Withdrawn");
                    Console.WriteLine("     3.Display Transactions(make sure to realize at least one transaction to check this option)");
                    Console.WriteLine("     4.Log Out");
                    Console.WriteLine();
                    Console.Write("     - "); 

                    userAction = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (userAction)
                    {
                        case 1:
                        // Call the Deposit Method 
                        Console.Clear();
                        double[] DepositMovimientos = checkInTransferences.Deposit(Autenticador);
                        Autenticador._actualUser.SetBalance(DepositMovimientos[0]);
                        Transaction DTransaction = new Transaction(DepositMovimientos[1], DepositMovimientos[0], "D");
                        summary.AddMovimientos(DTransaction);
                        summary.CreateAccountSummary(Autenticador._actualUser.getAccountNumber(), DTransaction);
                        summary.LoadSummary(Autenticador._actualUser.getAccountNumber());
                        Console.WriteLine();
                        Console.WriteLine($"    - TOTAL BALANCE: {Autenticador._actualUser.getBalance()}");
                        repeatUserActions = Autenticador.ContinueOperation();
                        break;

                        case 2: 
                        // Call the Withdraw method
                        Console.Clear();
                        double[] WithdrawMovimientos =  checkInTransferences.Withdraw(Autenticador);
                        Autenticador._actualUser.SetBalance(WithdrawMovimientos[0]);
                        Transaction WTransaction = new Transaction(WithdrawMovimientos[1], WithdrawMovimientos[0], "W");
                        summary.AddMovimientos(WTransaction);
                        summary.CreateAccountSummary(Autenticador._actualUser.getAccountNumber(), WTransaction);
                        summary.LoadSummary(Autenticador._actualUser.getAccountNumber());
                        Console.WriteLine();
                        Console.WriteLine($"    - TOTAL BALANCE: {Autenticador._actualUser.getBalance()}");
                        repeatUserActions = Autenticador.ContinueOperation();
                        break;

                        case 3: 
                        Console.Clear();
                        // Method to Display Transactions   
        
                        summary.LoadSummary(Autenticador._actualUser.getAccountNumber());
                        summary.DisplayMovimientos();

                            // Console.WriteLine("You do not have previous transactions. Please perform a transaction first.");
                            // Thread.Sleep(3000);
                            // Animations animation = new Animations();
                            // Program.UserActions(animation, Autenticador);

                        Console.WriteLine();
                        repeatUserActions = Autenticador.ContinueOperation(); 
                        break;

                        case 4: 
                        Console.Clear();
                        Animation.SeeYouSoon();
                        break;
                    }
                     // When the users log ing the program loads/create the summary txt file
                    Database.EditUser(Autenticador._actualUser);
                    return repeatUserActions;

    }
}