
class Scripture {
    Reference _reference; 
    string _content = "I say unto you, can you imagine to yourselves that ye hear the voice of the Lord, saying unto you, in that day: Come unto me ye blessed, for behold, your works have been the works of righteousness upon the face of the earth?"; 
    List<Word> wordSet = new List<Word>();  


  

    public Scripture(Reference reference){ 
        _reference = reference;
    }

    public void splitScripture(){
        foreach(string word in _content.Split(" ")){
            Word objectWord = new Word (word);
            wordSet.Add(objectWord);
        }
    }

   public void pickWord(){
        var random = new Random(); 
        int randomWord = random.Next(0, wordSet.Count);
        int randomWord2 = random.Next(0, wordSet.Count);
        wordSet[randomWord].changeStatus();
        wordSet[randomWord2].changeStatus();
   }

    

    public void displayScripture(){
        foreach(Word word in wordSet){
            Console.Write($" {word.statusDisplay()}"); 
        }
    }



}