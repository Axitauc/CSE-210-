class Word
{
 
    string _word; 
    bool _status = true; 
    string _dashes;

    public Word(string word)
    {
        _word = word;
    }

    public void changeStatus()
    {
        _status = false; 
    }

    public string statusDisplay()
    {
        if(_status)
        {
            return _word;
        }
        else{
            _dashes = "";

            foreach(char letter in _word){
               if(Char.IsLetter(letter)){

                    _dashes +="_";

               }
               else{
                    _dashes += letter;
               } 
               
            }

            return _dashes;
        }
       
    }

}