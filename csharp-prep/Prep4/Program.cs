using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        // We declare a random number so the while condition is filled and is started. 
        //However it will be easier with a do-while loop. 
        Console.WriteLine("> Enter a list of numbers, type 0 when finished.");

        int enterNumber = -1;
        while (enterNumber != 0)
        {
            Console.Write("> Enter number: "); 

            string response = Console.ReadLine();
            enterNumber = int.Parse(response);
            
            if (enterNumber != 0)
            {
                numbers.Add(enterNumber);
            }
        }
        
        int sum = 0; 
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine(" "); 
        Console.WriteLine($"- The sum is: {sum}.");
        Console.WriteLine(" "); 

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"- The average is: {average}.");
        Console.WriteLine(" "); 

        // Assigns the max value to the first element, and while the foreach loop is iterating, 
        // it will replace the original value with the biggest number. 
        
        int max = numbers[0];
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"- The max is: {max}");
        Console.WriteLine(" "); 
    }
}