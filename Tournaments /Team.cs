public class Team {
    private List<Player> _roster = new List<Player>(); 
    private List<string> _sponsor = new List<string>();
    private string _name; 
    private int _wins = 0; 
    private int _looses = 0; 

    public Team(string name){
        _name = name;
    }

    public void AddPlayer(Player p){

        foreach (Player existingPlayer in _roster)
        {
            if (p.GetJersey() == existingPlayer.GetJersey()){
                Console.WriteLine("Can't add a player with the same jersey number.");
                return;
            }
        }
        _roster.Add(p);
    }

    public void AddWin()
    {
        _wins +=1;
    }

    public void AddLoss()
    {
        _looses +=1;
    }

    public void Display(){
        Console.WriteLine($"{_name} {_wins}/{_looses}");
        foreach(Player p in _roster){
            p.Display();
        }
    }

    public string GetTeamName()
    {
        return _name;
    }
}
