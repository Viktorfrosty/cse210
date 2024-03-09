namespace ca1050
{
    public class PromptGenerator
    {

        public List<string> _prompts = new List<string>()
        {
            "What did I learn today?",
            "What act of kindness did I perform today?",
            "What kind of blessings I received today?",
            "What was the best part of my day?",
            "If I had one thing I could do over today, what would it be?",
            "How did I see the hand of the Lord in my life today?",
            "What am I grateful for today?"
        };
        
        public string GetRandomPrompt()
        {
            Random randomValue = new Random();
            int index = randomValue.Next(_prompts.Count);
            string requiredPrompt = _prompts[index];
            return requiredPrompt;
        }
    }
}