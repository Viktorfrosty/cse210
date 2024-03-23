namespace Mindfulness
{

    public class ReflectingActivity: Activity
    {

        private List<string> _prompts = new List<string>
        {
            "prompt test1",
            "prompt test2"
        };

        private List<string> _Questions = new List<string>
        {
            "question test1",
            "question test2"
        };


        public ReflectingActivity(string name, string description, int duration): base(name, description, duration)
        {

            //

        }
        
        public void Run()
        {
            
            //

        }

        public string GetRandomPrompt()
        {

            string prompt = "test";

            return prompt;

        }

        public string GetRandomQuestion()
        {

            string question = "test";

            return question;

        }

        public void DisplayPrompt()
        {
            
            //

        }

        public void DisplayQuestion()
        {
            
            //

        }
        
    }

}