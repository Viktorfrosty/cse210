namespace Mindfulness
{

    public class ReflectingActivity: Activity
    {

        Random random = new Random();

        private List<string> usedIndex = new List<string> {};

        private List<string> _prompts = new List<string>
        {

            "Think of a time when you did something very difficult.",
            "Think of a time when you did something very easy.",
            "Think of a time when you help others."

        };

        private List<string> _questions = new List<string>
        {

            "How would you like to feel about the situation; what steps could you take to achieve that?",
            "How have your feelings about it evolved or changed since it occurred?",
            "Have your feelings about the situation influenced your actions or decisions in any way?",
            "How has your perspective on that situation changed over time?",
            "Can you describe the emotions you experienced as a result of the situation?",
            "What was your initial reaction?",
            "What has been the most challenging part of dealing with the situation?",
            "Can you describe the experience in your own words?",
            "What was the most memorable part of the experience?",
            "What surprised you the most about the experience?",
            "If you could change one thing about the experience, what would it be?",
            "How will this experience influence your future decisions or actions?"

        };


        public ReflectingActivity(string name, string description): base(name, description)
        {

            // no modifications.

        }
        
        public void Run()
        {
            
            DisplayPrompt();

            DisplayQuestion();

        }

        private string GetRandomPrompt()
        {

            int randomIndex = random.Next(0, _prompts.Count());

            return _prompts[randomIndex];

        }

        private string GetRandomQuestion()
        {

            int randomIndex;

            if (usedIndex.Count == _questions.Count())
            {

                usedIndex.Clear();

            }

            do
            {

                randomIndex = random.Next(0, _questions.Count());

            } 
            
            while (usedIndex.Contains(randomIndex.ToString()));

            usedIndex.Add(randomIndex.ToString());

            return _questions[randomIndex];

        }

        private void DisplayPrompt()
        {

            string prompt = GetRandomPrompt();
            
            Console.WriteLine($"Considering the next prompt:\n\n--- {prompt} ---\n\nWhen you have something in your mind press enter to continue.");

            Console.ReadLine();

        }

        private void DisplayQuestion()
        {

            Console.Write("\nNow ponder on each of the following questions as they related to this experience\nYou may begin in: ");

            ShowCountDown(5);

            DateTime startTime = DateTime.Now;

            DateTime futureTime = startTime.AddSeconds(_duration);

            Console.Clear();

            while (DateTime.Now < futureTime)
            {

                string question = GetRandomQuestion();
                
                Console.Write($"\n> {question} ");

                ShowSpinner(10);

            }

        }
        
    }

}