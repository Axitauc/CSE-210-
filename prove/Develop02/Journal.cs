public class Journal {

    string _fileName = "test.txt"; 

    List <Entry> Registers = new List<Entry> ();  

    public void AddRegisters(Entry Register){
        Registers.Add(Register);
    }
    
    public void Display() {
        foreach(Entry register in Registers) {
            Console.WriteLine(" ");
            Console.Write("> "); 
            Console.WriteLine(register.DisplayEntry());
            Console.WriteLine(" ");
        }
        
    }

    public void SaveEntries(){
        using (StreamWriter outputFile = new StreamWriter(_fileName))
        {
            // You can add text to the file with the WriteLine method
            foreach (Entry register in Registers) {
                outputFile.WriteLine(register.StrimEntry());
            }
        }
    }

    public void LoadEntries() {
        string[] lines = System.IO.File.ReadAllLines(_fileName);
        // Console.WriteLine(lines.Length);
        foreach (string line in lines)
        {
            // Console.WriteLine("here2");
            string[] parts = line.Split(",");
            string prompt = parts[0];
            string userInput = parts[1];
            string date = parts[2];
            string emotion = parts[3];
            Entry entry = new Entry(prompt, userInput, date, emotion);
            Console.WriteLine(entry.DisplayEntry());
            Registers.Add(entry);
            
        }    
    }
}