using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int userSelection = 0; 

        Journal AxaUribeJournal = new Journal(); 

        while(userSelection != 5) {
            Console.WriteLine("> Please, select one of the options: ");
            Console.WriteLine(" ");
            Console.WriteLine(" 1.Write");
            Console.WriteLine(" 2.Display");
            Console.WriteLine(" 3.Load");
            Console.WriteLine(" 4.Save"); 
            Console.WriteLine(" 5.Quit"); 
            Console.WriteLine(" ");
            Console.Write("> "); 
            userSelection = int.Parse(Console.ReadLine());
            Console.WriteLine(" ");

            if (userSelection == 1) {
                // Crea un prompt nuevo. 
                Prompt prompt = new Prompt(); 
                // Elige la pregunta. 
                string randomPrompt = prompt.PickRandomPrompt();
                // Crea la nueva entrada y pasa la pregunta random. 
                DateTime theCurrentTime = DateTime.Now;
                string date = theCurrentTime.ToShortDateString();
                Console.WriteLine(" "); 
                Console.Write("- ");
                Console.WriteLine(randomPrompt);
                Console.WriteLine(" "); 
                Console.Write("> ");
                string userInput = Console.ReadLine();
                Console.WriteLine(" ");
                Console.WriteLine("- How are you feeling today?");
                Console.WriteLine(" "); 
                Console.Write("> ");
                string emotion = Console.ReadLine();
                Console.WriteLine(" ");
                Entry newEntry = new Entry(randomPrompt, userInput, emotion, date);
                // Solicita la respeusta del usuario a la pregunta random seleccionada. 
               
                // Pasando ela entrada ya lista al registro del Diario. 
                AxaUribeJournal.AddRegisters(newEntry);
            }
            else if (userSelection == 2) {
                AxaUribeJournal.Display();
            }
            else if (userSelection == 3) {
                AxaUribeJournal.LoadEntries();
            }
            else if (userSelection == 4) {
                AxaUribeJournal.SaveEntries();
            }
            else if (userSelection == 5) {
                Console.WriteLine("- I will be waiting for you!");
                break;
            }
            else {
                Console.WriteLine("- Please entry a valid option.");
                Console.WriteLine(" ");
            }

        } 
        
    }
}