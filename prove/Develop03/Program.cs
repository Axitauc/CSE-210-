using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // La referencia contiene los valores atuales de mi programa. 
        Reference scriptureAlma5_16 = new Reference("Alma", 5, "16");
        Scripture scripture = new Scripture(scriptureAlma5_16); 
        scripture.splitScripture();


        string userInput = " "; 
        while (userInput != "quit"){
            Console.Clear();
            scripture.displayScripture();

            Console.WriteLine("\n > Type enter if you want to continue or quite if you want to end the program:  ");
            userInput = Console.ReadLine();
            scripture.pickWord();
        }

    }   

    


}