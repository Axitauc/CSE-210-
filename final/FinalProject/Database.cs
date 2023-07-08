public static class Database {

    public static List<User> UsersInformation = new List<User>(); 
    

    public static void SaveUsers(User user)
    {
        // string _filePath = AppDomain.CurrentDomain.BaseDirectory + @"ListaDeUsuarios.txt";
        string _filePath = "/Users/axauribe/Documents/Spring 2023 - BYUI/Programming With Classes /CSE-210-/final/FinalProject/ListaDeUsuarios.txt";
        if (File.Exists(_filePath))
        {
            // Agregar ultima linea. 
            
            using (StreamWriter outputFile = File.AppendText(_filePath))
            {
                
                outputFile.WriteLine(user.StrimUser());
            }
        }
        else
        {
            // Crear el archivo de 0. 
            using(StreamWriter outputFile = new StreamWriter("ListaDeUsuarios.txt"))
            {
                outputFile.WriteLine(""); 
                foreach(User i in UsersInformation)
                {
                    outputFile.WriteLine(i.StrimUser());
                }
            }
        }
    }










}