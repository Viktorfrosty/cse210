namespace Mindfulness
{

    public class ListingActivity: Activity
    {

        private int _count;

        private List<string> _prompts = new List<string>
        {

            "when you have felt the Holy Ghost this week?",
            "What did you learn in your personal and companionship study this week?",
            "How have the Savior and His work blessed your life?"

        };

        public ListingActivity(string name, string description): base(name, description)
        {

            //

        }
        
        public void Run()
        {

            GetRandomPrompt();

            List<string> list = GetListFromUser();

            EntriesCount(list);   

        }

        private void GetRandomPrompt()
        {

            Random random = new Random();

            int randomIndex = random.Next(0, _prompts.Count());

            Console.WriteLine(_prompts[randomIndex]);

        }

        private List<string> GetListFromUser()
        {

            List<string> userList = new List<string> {};

            Console.Write("\nWrite everything that comes into your mind before the time's over.\nYou may begin in: ");

            ShowCountDown(5);

            Console.WriteLine("");

            DateTime startTime = DateTime.Now;

            DateTime futureTime = startTime.AddSeconds(_duration);

            while (DateTime.Now < futureTime)
            {

                Console.Write("> ");
                string userInput = Console.ReadLine();

                userList.Add(userInput);

                _count++;

            }

            return userList;

        }

        private void EntriesCount(List<string> userList)
        {

            _count = userList.Count();

            Console.WriteLine($"You wrote {_count} entries. Press 'Enter' Button to continue.");

            Console.ReadLine();

        }
        
    }

}