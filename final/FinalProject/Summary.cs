public class Summary 
{
    List<Transaction> Movimientos = new List<Transaction>(); 
    Authentication Autenticador = new Authentication();


    public void DisplayMovimientos()
    {
        Console.WriteLine("ATM || LIST OF TRANSACTIONS"); 
        Console.WriteLine();
        int counter = 1;
   
        foreach(Transaction i in Movimientos){
        Console.WriteLine($"> TRANSACTION {counter}");
        Console.WriteLine($"        DATE: {i.GetTransactionDate().ToLongDateString()}");
        if ( i.GetInOut() == true)
        {
            Console.Write($"        AMOUNT: +");
        }
        else
        {
            Console.Write($"        AMOUNT: -");
        }
        Console.WriteLine($"{i.GetTransactionAmount()}");
        Console.WriteLine($"        TOTAL BALANCE: {i.GetBalance()}");
        Console.WriteLine();
        Console.WriteLine();
        counter += 1; 
        }

    }
    
    public void AddMovimientos(Transaction transaction)
    {
        Movimientos.Add(transaction);
    }

    public void CreateAccountSummary(string fileName, Transaction transaction)
    {
        fileName = $"{fileName}.txt";
        string _filePath = $"/Users/axauribe/Documents/Spring 2023 - BYUI/Programming With Classes /CSE-210-/final/FinalProject/{fileName}";
        if (File.Exists(_filePath))
        {
            // Agregar ultima linea.           
            using (StreamWriter outputFile = File.AppendText(_filePath))
            {
                
                outputFile.WriteLine(transaction.strimTransaction());
            }
        }
        else
        {
            // Crear el archivo de 0. 
            using(StreamWriter outputFile = new StreamWriter(fileName))
            {
                foreach(Transaction i in Movimientos){
                    outputFile.WriteLine(i.strimTransaction());
                }
              
            }
       }
    }

    public void LoadSummary(string fileName)
    {
        fileName = $"{fileName}.txt";
        string[] lines = System.IO.File.ReadAllLines(fileName);
        foreach (string line in lines)
        {         
            string[] parts = line.Split(",");
            double _transactionAmount = double.Parse(parts[0]);
            string _transactionDate = parts[1];
            bool _inOut = bool.Parse(parts[2]);
            double _balance = double.Parse(parts[3]);

            Transaction transaction = new Transaction(_transactionAmount, _transactionDate, _inOut, _balance);
            Movimientos.Add(transaction);
        }
    }

}