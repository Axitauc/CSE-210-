Player michael = new Player("Michael", "Jordan", 12); 

michael.UpdateJersey(45);
michael.UpdateJersey(23);

// michael.Display(); 

Player axa = new Player ("Axa", "uribe", 10);

Team fireballs = new Team 
("Fireballs"); 

fireballs.AddPlayer(axa); 
fireballs.AddPlayer(michael);

fireballs.AddWin(); 
fireballs.AddLoss(); 
fireballs.AddWin();

fireballs.Display();

