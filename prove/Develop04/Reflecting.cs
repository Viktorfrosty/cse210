namespace Mindfulness
{

    public class ReflectingActivity: Activity
    {

        private List<string> _prompts = new List<string>
        {
            "prompt test1",
            "prompt test2"
        };

        private List<string> _questions = new List<string>
        {
            "question test1",
            "question test2"
        };


        public ReflectingActivity(string name, string description): base(name, description)
        {

            //

        }
        
        public void Run()
        {
            
            DisplayPrompt();

            Console.WriteLine("Considering the next prompt:");

            DisplayQuestion();

        }

        public string GetRandomPrompt()
        {

            Random random = new Random();

            int randomIndex = random.Next(0, _prompts.Count());

            return _prompts[randomIndex];

        }

        public string GetRandomQuestion()
        {

            Random random = new Random();

            int randomIndex = random.Next(0, _questions.Count());

            return _questions[randomIndex];

        }

        public void DisplayPrompt()
        {
            
            Console.WriteLine(GetRandomPrompt());

        }

        public void DisplayQuestion()
        {
            
            Console.WriteLine(GetRandomQuestion());

        }
        
    }

}