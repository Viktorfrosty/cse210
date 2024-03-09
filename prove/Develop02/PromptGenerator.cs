namespace ca1050
{
    public class PromptGenerator
    {

        public List<string> _prompts = new List<string>()
        {
            "prompt1",
            "prompt2",
            "prompt3",
            "prompt4",
            "prompt5",
            "prompt6"
        };
        
        public string GetRandomPrompt()
        {
            Random randomValue = new Random();
            int index = randomValue.Next(_prompts.Count);
            return _prompts[index];
        }
    }
}