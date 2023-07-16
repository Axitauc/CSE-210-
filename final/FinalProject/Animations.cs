public class Animations 
{
    List<string> SpinnerItems = new List<string>(){
     "|", "/", "-", "\\"
   }; 


    public Animations()
    {

    }

    public void Spinner()
    {
        for (int i=0; i <= 2; i++){
           foreach(string carac in SpinnerItems){
            Console.Write(carac);
            Thread.Sleep(500);
            Console.Write("\b");
           }
        }
    }

    public void IncorrectCredentials()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ============================================================================================="); 
        Console.WriteLine("                                               I       N       C       O       R       R       E       C       T");
        Console.WriteLine("                                       C       R       E       D       E       N       T       I       A       L       S");
        Console.WriteLine("                                  ============================================================================================="); 
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void Welcome()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ====================================================================="); 
        Console.WriteLine("                                          W       E       L       C       O       M       E");
        Console.WriteLine("                                  ====================================================================="); 
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void SeeYouSoon()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ================================================================"); 
        Console.WriteLine("                                          S       E       E           Y       O       U");
        Console.WriteLine("                                                    S       O       O       N");
        Console.WriteLine("                                  ================================================================"); 
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void InvalidOption()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  =============================================================="); 
        Console.WriteLine("                                       I       N       V       A       L       I       D");
        Console.WriteLine("                                           O       P       T       I       O       N");
        Console.WriteLine("                                  =============================================================="); 
        Thread.Sleep(3000);
        Console.Clear();      
    }

    public void CompleteTransaction()
    {  
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine(); 
        Console.WriteLine("                                  ============================================================================================"); 
        Console.WriteLine("                                              C       O       M       P       L       E       T       E");
        Console.WriteLine("                                      T       R       A       N       S       A       C       T       I       O       N");
        Console.WriteLine("                                  ============================================================================================");  
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void NewUserCreated()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ==================================================================================================================="); 
        Console.WriteLine("                                        N      E       W        U      S       E       R       C       R       E       A       T       E       D");
        Console.WriteLine("                                  ==================================================================================================================="); 
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void PasswordChanged()
    {
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ====================================================================="); 
        Console.WriteLine("                                       P      A       S       S       W       O       R       D");
        Console.WriteLine("                                           C       H       A       N       G       E       D");
        Console.WriteLine("                                  ====================================================================="); 
        Thread.Sleep(3000);
        Console.Clear();
    }

    public void Loading()
    {   
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("                                  ====================================================================="); 
        Console.WriteLine("                                          L       O       A       D       I       N       G");
        Console.WriteLine("                                  ====================================================================="); 
        Thread.Sleep(3000);
        Console.Clear();   
    }

    
}