using System;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0;   
        int userAction = 0;
        Authentication Autenticador = new Authentication();

        while(userSelection != 4) 
        {
            Console.Clear(); 
            Console.WriteLine("--> Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine("     1.Create Account");
            Console.WriteLine("     2.Log In");
            Console.WriteLine("     3.Change Password");
            Console.WriteLine("     4.Quit"); 
            Console.WriteLine(" ");
            Console.Write("     - "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (userSelection == 1) 
            {
                Console.Clear();
                Console.WriteLine("---SIGN UP---");
                // Call Sign Up function
                Autenticador.SignUp();
            }
            else if (userSelection == 2) 
            {
                Console.Clear();
                Console.WriteLine("---LOG IN---");
                // Call Log In function.
                if (Autenticador.Login())
                // Si el usuario y la contrasena encajan. 
                // [ANIMATION] Welcome!
                {
                    
                    Console.WriteLine("--> Please, select the action:");
                    Console.WriteLine(" ");
                    Console.WriteLine("     1.Deposit");
                    Console.WriteLine("     2.Withdrawn");
                    Console.WriteLine("     3.Transference");
                    Console.WriteLine(" ");
                    Console.Write("     - "); 

                    userAction = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    switch (userAction)
                    {
                    case 1:
                    // Call the Deposit Method.
                    break;
                    case 2: 
                    // Call the Withdraw method. 
                    break;
                    case 3: 
                    // Call the Transference Method. 
                    break;
                    }
                }
                else 
                {
                    // [ANIMATION] Incorrect credentials. Try again. 
                    continue;
                }

            }
            else if (userSelection == 3) 
            {
                // Console.Clear();
                Console.WriteLine("---CHANGE PASSWORD---");
                // Call changePassword Function.
            }
            else if (userSelection == 4) 
            {
                // Console.Clear();
                // [ANIMATION] See you soon. 
                break;
            }
            else 
            {
                // Console.Clear();
                // [ANIMATION] Invalid option. 
                Console.WriteLine();
            }
        } 
    }
}