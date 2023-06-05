public class Prompt 
{
    List<string> _prompts = new List<string>(){
        "What am I proud of? Do I credit myself or others in the appropriate ways?",
        "Am I quick to praise or judge someone’s character? How is one or the other beneficial or detrimental to my own mental state?",
        "What hurt do I hold on to? What kind of benefits does this bring to me?", 
        "When was the last time I was moved to tears in joyous laughter? What was the situation and what can I remember about the way it made me feel?", 
        "Do I feel guilty about anything? How can I resolve these feelings and not feel burdened by them?", 
        "Who makes my community? Who are the people I rely on to bring me strength when I can’t find it within myself? How can I make them feel appreciated?", 
        "Am I in love with the things I do every day? Am I surviving or creating a love story with my work?",
        "Are my relationships nurturing my growth? Am I helping others to grow? Am I willing to ask for support?", 
        "What am I excited for in the future that fuels my present?", 
        "How are you changing the world? Would you want to live in the world you create?",
    }; 

    public string PickRandomPrompt() 
    {
        var random = new Random(); 
        int randomNumber = random.Next(0, _prompts.Count);
        return _prompts[randomNumber];
    }

}