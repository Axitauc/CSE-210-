public static class Database {

    public static List<User> UsersInformation = new List<User>(); 
    

    public static void SaveUsers(User user)
    {
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

    public static void Load()
    {
        string _filePath = "ListaDeUsuarios.txt";
        string[] lines = System.IO.File.ReadAllLines(_filePath);
        foreach (string line in lines)
        {         
            string[] parts = line.Split(",");
            string _userName = parts[0];
            string _password = parts[1];
            string _accountNumber = parts[2];
            double _balance = double.Parse(parts[3]);

            User DataUser = new User(_userName, _password, _accountNumber, _balance);
            DataUser.SetAccountNumber(_accountNumber);
            DataUser.SetBalance(_balance);
            UsersInformation.Add(DataUser);
        }
    }

    public static void EditUser(User actualUser)
    {
        int counter = 1;
        foreach(User user in UsersInformation){
           if(user == actualUser){
            break;
           }
           counter += 1;
        }
     
        string[] arrLine = File.ReadAllLines("ListaDeUsuarios.txt");
        arrLine[counter - 1] = actualUser.StrimUser();
        File.WriteAllLines("ListaDeUsuarios.txt", arrLine);
    }   


    






}